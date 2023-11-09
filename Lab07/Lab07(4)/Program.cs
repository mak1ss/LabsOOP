using Lab07_4_;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] phoneNumbers = Console.ReadLine().Split(" ");
        string[] siteNames = Console.ReadLine().Split(" ");

        Phone phone = new Phone();
        foreach (string number in phoneNumbers)
        {
            try
            {
                phone.Call(number);

            } catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        foreach (string site in siteNames)
        {
            try
            {
                phone.Browse(site);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}