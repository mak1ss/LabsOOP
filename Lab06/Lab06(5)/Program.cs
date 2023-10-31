using Lab06_5_;
using Lab06_5_.Factories.Abstractions;
using Lab06_5_.Factories.Implementations;


internal class Program
{
    private static void Main(string[] args)
    {
        //string[] input = Console.ReadLine().ToLower().Split(" ");
        string[] input = "Cram melon honeyCake Cake".ToLower().Split(" ");
        Gandalf gandalf = new Gandalf();
        FoodFactory foodFactory = new FoodFactoryImpl();
        for(int i = 0; i < input.Length; i++)
        {
            gandalf.Feed(foodFactory.GetFood(input[i]));
        }

        Console.WriteLine($"{gandalf.happines} \n {gandalf.GetMood().GetType().Name}");
    }
}