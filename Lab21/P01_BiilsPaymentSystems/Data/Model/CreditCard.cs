using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_BiilsPaymentSystems.Data.Model
{
    public class CreditCard
    {
        public int Id { get; set; }
        public float Limit { get; private set; }
        public float MoneyOwed { get; private set; }

        [NotMapped]
        public float LimitLeft { get => Limit - MoneyOwed; }
        public DateOnly ExpirationDate { get; set; }

        public int PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        public void Deposit(float amount)
        {
            if(MoneyOwed - amount < 0)
            {
                Limit += amount - MoneyOwed;
                MoneyOwed = 0;
                Console.WriteLine($"Limit of your credit card (ID: {Id}) was extended");
                return;
            }
            MoneyOwed -= amount;
        }

        public void Withdraw(float amount)
        {
            if (LimitLeft == 0)
            {
                throw new InvalidOperationException($"Insufficient funds at CreditCard ID: {Id}!");
            }
            MoneyOwed += amount;
        }
    }
}
