internal class Program
{
    private static void Main(string[] args)
    {
        string email = Console.ReadLine();

        string username = email.Split('@')[0];
        string domain = email.Split('@')[1];
        string replacement = new string('*', username.Length) + '@' + domain;

        string text = Console.ReadLine();

        Console.WriteLine(text.Replace(email, replacement));
    }
}