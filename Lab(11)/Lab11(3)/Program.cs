using Lab11_3_;

internal class Program
{
    private static void Main(string[] args)
    {
        PremitiveCalculator calculator = new PremitiveCalculator();

        string input;

        while (!(input = Console.ReadLine()).ToLower().Equals("end"))
        {
            string[] @params = input.Split(' ');
            if (@params[0].Equals("mode"))
            {
                if (@params[1].Length > 1)
                {
                    Console.WriteLine($"Operation name is too long: {@params[1]}");
                    continue;
                }
                calculator.ChangeStrategy(@params[1][0]);
            }
            else
            {
                int firstOperand, secondOperand = 0;

                if (int.TryParse(@params[0], out firstOperand) && int.TryParse(@params[1], out secondOperand))
                {
                    try
                    {
                        Console.WriteLine(calculator.Calculate(firstOperand, secondOperand));
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                        continue;
                    }

                }
                else
                {
                    Console.WriteLine("Invalid operands passed");
                    continue;
                }
            }

        }
    }
}