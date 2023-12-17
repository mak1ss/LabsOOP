using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_BiilsPaymentSystems.Data.Model
{
    public class BankAccount
    {
        public int Id { get; set; }
        public float Balance { get; private set; }
        public string BankName { get; set; }
        public string SwiftCode { get; set; }

        public int PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        public void Deposit(float amount)
        {
            Balance += amount;
        }

        public void Withdraw(float amount)
        {
            
            Balance -= Balance - amount > 0 ? amount : throw new InvalidOperationException($"Insufficient funds at BankAccount ID: {Id}!"); 
        }

    }
}
