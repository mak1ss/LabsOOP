using Microsoft.EntityFrameworkCore;
using P01_BiilsPaymentSystems.Data.EntityConfig;
using P01_BiilsPaymentSystems.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_BiilsPaymentSystems.Data
{
    public class BillsPaymentSystemContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<BankAccount> BankAccounts => Set<BankAccount>();
        public DbSet<CreditCard> CreditCards => Set<CreditCard>();
        public DbSet<PaymentMethod> PaymentMethods => Set<PaymentMethod>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=billsPaymentSystem;Trusted_Connection=True;Encrypt=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new BankAccountConfiguration());
            modelBuilder.ApplyConfiguration(new CreditCardConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentMethodConfiguration());

            var users = new List<User>
            {
                new User{Id = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", Password = "password123"},
                new User{Id = 2, FirstName = "Maksym", LastName = "Diachuk", Email = "amf.diac@example.com", Password = "password123"},
                new User{Id = 3, FirstName = "Andriy", LastName = "Malkov", Email = "m.andriy@example.com", Password = "password123"}

            };

            var bankAccounts = new List<BankAccount>
            {
                new BankAccount{Id = 1, BankName = "Pumb", SwiftCode = "123141411"},
                new BankAccount{Id = 2, BankName = "Privat", SwiftCode = "139048713"}
            };
            bankAccounts[0].Deposit(1500);
            bankAccounts[1].Deposit(1500);

            var creditCards = new List<CreditCard>
            {
                new CreditCard{Id = 1, ExpirationDate = DateOnly.Parse("2025-10-03")},
                new CreditCard{Id = 2, ExpirationDate = DateOnly.Parse("2027-10-03")}

            };
            creditCards[0].Deposit(50000);
            creditCards[0].Withdraw(34657.45f);

            creditCards[1].Deposit(100000);
            creditCards[1].Withdraw(570.45f);


            var paymentMethods = new List<PaymentMethod>
            {
                new PaymentMethod { Id = 1, BankAccountId = 1, Type = P01_BiilsPaymentSystems.Data.Model.Type.BankAccount, UserId = 1},
                new PaymentMethod { Id = 2, CreditCardId = 1, Type = P01_BiilsPaymentSystems.Data.Model.Type.CreditCard, UserId = 2},
                new PaymentMethod { Id = 3, BankAccountId = 2, Type = P01_BiilsPaymentSystems.Data.Model.Type.BankAccount, UserId = 3},
                new PaymentMethod { Id = 4, CreditCardId = 2, Type = P01_BiilsPaymentSystems.Data.Model.Type.CreditCard, UserId = 3}

            };

            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<BankAccount>().HasData(bankAccounts);
            modelBuilder.Entity<CreditCard>().HasData(creditCards);
            modelBuilder.Entity<PaymentMethod>().HasData(paymentMethods);
        }

    }
}


