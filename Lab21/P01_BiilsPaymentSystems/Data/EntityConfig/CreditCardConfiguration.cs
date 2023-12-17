using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_BiilsPaymentSystems.Data.Model;


namespace P01_BiilsPaymentSystems.Data.EntityConfig
{
    public class CreditCardConfiguration : IEntityTypeConfiguration<CreditCard>
    {
        void IEntityTypeConfiguration<CreditCard>.Configure(EntityTypeBuilder<CreditCard> builder)
        {
            builder.Property(cc => cc.Id).HasColumnName("CreditCardId");
            builder.Property(cc => cc.Limit).IsRequired();
            builder.Property(cc => cc.MoneyOwed).IsRequired();
            builder.Property(cc => cc.ExpirationDate).IsRequired();

            builder.HasOne(cc => cc.PaymentMethod).WithOne(pm => pm.CreditCard).HasForeignKey<CreditCard>(cc => cc.PaymentMethodId);
        }
    }
}
