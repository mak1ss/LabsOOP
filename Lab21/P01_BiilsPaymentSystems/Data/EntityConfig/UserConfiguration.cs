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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        void IEntityTypeConfiguration<User>.Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.Id).HasColumnName("UserId");
            builder.Property(u => u.FirstName).HasMaxLength(50).IsUnicode();
            builder.Property(u => u.LastName).HasMaxLength(50).IsUnicode();
            builder.Property(u => u.Email).HasMaxLength(80).IsUnicode(false);
            builder.Property(u => u.Password).HasMaxLength(25).IsUnicode(false);

            builder.HasMany(u => u.PaymentMethods).WithOne(pm => pm.User).HasForeignKey(pm => pm.UserId);
        }

    }
}
