
using P01_BiilsPaymentSystems.Data;
using P01_BiilsPaymentSystems.Data.Model;

internal class Startup
{
    private static BillsPaymentSystemContext context;
    private static void Main(string[] args)
    {
        context = new BillsPaymentSystemContext();
        GetUserById(3);

        PayBills(3, 50_000);
    }
    private static void GetUserById(int id)
    {
        User? user = context.Users.Where(u => u.Id == id).FirstOrDefault();
        if (user == null)
        {
            throw new ArgumentException("Unknown user id: " + id);
        }

        List<BankAccount> bankAccounts = new List<BankAccount>();
        List<CreditCard> creditCards = new List<CreditCard>();
        context.PaymentMethods.Where(pm => pm.User == user).ToList().ForEach(pm =>
        {
            if (pm.Type == P01_BiilsPaymentSystems.Data.Model.Type.BankAccount)
            {
                bankAccounts.Add(context.BankAccounts.Where(b => b.Id == pm.BankAccountId).First());
            }
            else
            {
                creditCards.Add(context.CreditCards.Where(cc => cc.Id == pm.CreditCardId).First());
            }
        });

        Console.WriteLine($"User: {user.FirstName} {user.LastName}");
        if (bankAccounts.Count > 0)
        {
            Console.WriteLine("BankAccounts: ");
            bankAccounts.ForEach(b => Console.WriteLine($"--- ID: {b.Id}\n --- Balance: " +
                $"{b.Balance}\n --- Bank: {b.BankName}\n --- SWIFT: {b.SwiftCode}"));
        }
        if (creditCards.Count > 0)
        {
            Console.WriteLine("Credit Cards: ");
            creditCards.ForEach(cc => Console.WriteLine($"--- ID: {cc.Id}\n --- Limit:" +
                $" {cc.Limit}\n --- Money Owed: {cc.MoneyOwed}\n --- Limit Left: {cc.LimitLeft}\n --- Expiration Date: {cc.ExpirationDate}"));
        }
    }

    private static void PayBills(int id, float amount)
    {
        User? user = context.Users.Where(u => u.Id == id).FirstOrDefault();
        if (user == null)
        {
            throw new ArgumentException("Unknown user id: " + id);
        }

        List<BankAccount> bankAccounts = new List<BankAccount>();
        List<CreditCard> creditCards = new List<CreditCard>();
        context.PaymentMethods.Where(pm => pm.User == user).ToList().ForEach(pm =>
        {
            if (pm.Type == P01_BiilsPaymentSystems.Data.Model.Type.BankAccount)
            {
                bankAccounts.Add(context.BankAccounts.Where(b => b.Id == pm.BankAccountId).First());
            }
            else
            {
                creditCards.Add(context.CreditCards.Where(cc => cc.Id == pm.CreditCardId).First());
            }
        });

        if (bankAccounts.Count != 0)
        {
            foreach (var bankAccount in bankAccounts.OrderBy(b => b.Id).ToList())
            {
                try
                {
                    bankAccount.Withdraw(amount);
                }
                catch (InvalidOperationException ex)
                {
                    Console.Error.WriteLine(ex.Message);
                }
            }
        }
        if (creditCards.Count != 0)
        {
            foreach (var creditCard in creditCards.OrderBy(cc => cc.Id).ToList())
            {
                try
                {
                    creditCard.Withdraw(amount);
                }
                catch (InvalidOperationException ex)
                {
                    Console.Error.WriteLine(ex.Message);
                }
            }
        }
        context.SaveChanges();
    }
}