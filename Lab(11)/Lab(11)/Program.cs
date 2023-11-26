using Lab_11_;

internal class Program
{
    private static void Main(string[] args)
    {
        Dispatcher  dispatcher = new Dispatcher();
        Handler handler = new Handler();
        dispatcher.NameChange += handler.OnDispatcherNameChange;

        string input;
        while (!(input = Console.ReadLine()).Equals("End"))
        {
            dispatcher.Name = input;
        }

    }
}