using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_BiilsPaymentSystems.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_BiilsPaymentSystems.Data.EntityConfig
{
    public class PaymentMethodConfiguration : IEntityTypeConfiguration<PaymentMethod>
    {
        void IEntityTypeConfiguration<PaymentMethod>.Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder.Property(pm => pm.Type).IsRequired();

            builder.HasIndex(pm => new { pm.UserId, pm.BankAccountId, pm.CreditCardId }).IsUnique();

            builder.Property(pm => pm.BankAccountId).IsRequired(false);
            builder.Property(pm => pm.CreditCardId).IsRequired(false);

            builder.HasCheckConstraint("CK_EitherBankAccountOrCreditCard", "((BankAccountId IS NOT NULL AND CreditCardId IS NULL) OR (BankAccountId IS NULL AND CreditCardId IS NOT NULL))");

            builder.HasOne(pm => pm.User).WithMany(u => u.PaymentMethods).HasForeignKey(pm => pm.UserId);
            builder.HasOne(pm => pm.BankAccount).WithOne(ba => ba.PaymentMethod).HasForeignKey<PaymentMethod>(pm => pm.BankAccountId);
            builder.HasOne(pm => pm.CreditCard).WithOne(cc => cc.PaymentMethod).HasForeignKey<PaymentMethod>(pm => pm.CreditCardId);
        }
    }
}
