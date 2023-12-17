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
    public class BankAccountConfiguration : IEntityTypeConfiguration<BankAccount>
    {
        void IEntityTypeConfiguration<BankAccount>.Configure(EntityTypeBuilder<BankAccount> builder)
        {
            builder.Property(ba => ba.Id).HasColumnName("BankAccountId");
            builder.Property(ba => ba.Balance).IsRequired();
            builder.Property(ba => ba.BankName).HasMaxLength(50).IsUnicode();
            builder.Property(ba => ba.SwiftCode).HasMaxLength(20).IsUnicode(false);

            builder.HasOne(ba => ba.PaymentMethod).WithOne(pm => pm.BankAccount).HasForeignKey<BankAccount>(ba => ba.PaymentMethodId);
        }
    }
}
