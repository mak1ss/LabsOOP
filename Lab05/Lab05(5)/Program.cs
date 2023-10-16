using Lab05_5_;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                string pizzaName = Console.ReadLine().Split(" ")[1];
                string[] doughInput = Console.ReadLine().ToLower().Split(" ");
                Dough dough = new Dough(doughInput[1], doughInput[2], int.Parse(doughInput[3]));
                Pizza pizza = new Pizza(pizzaName, dough);

                string toppingInput = "";
                while (!(toppingInput = Console.ReadLine()).Equals("END"))
                {
                    try
                    {
                        string[] toppingParams = toppingInput.ToLower().Split(" ");
                        Topping topping = new Topping(toppingParams[1], int.Parse(toppingParams[2]));
                        pizza.AddTopping(topping);
                    }
                    catch (Exception ex) when (ex is ArgumentException || ex is ArgumentOutOfRangeException)
                    {
                        Console.WriteLine(ex.Message);
                        continue;
                    }
                }
                Console.WriteLine(pizza.CalcTotalCalories());
                break;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                continue;
            } 
        }
    }
}