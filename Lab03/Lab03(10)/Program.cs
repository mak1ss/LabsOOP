internal class Car
{
    public string Model { get; }
    public Engine Engine { get; }
    public int Weight { get; }
    public string Color { get; }

    public Car (string model, Engine engine, int weight, string color)
    {   

        Model = model;
        Engine = engine;
        Weight = weight;
        Color = color == null ? "n/a" : color;
    }

    public override string ToString()
    {   
        string engine = Engine.ToString();
        return Model + ":\n" + "\t" + engine + "\n" + "\tWeight: " + (Weight==0?"n/a":Weight) + "\n" + "\tColor: " + Color;
    }
}

internal class Engine
{
    public string Model { get; }
    public int Power { get; }  
    public int Displacement { get; }
    public string Efficiency { get; }

    public Engine (string model, int power, int displacement, string efficiency)
    {
        Model = model;
        Power = power;
        Displacement = displacement;
        Efficiency = efficiency == null ? "n/a" : efficiency;
    }

    public override string ToString()
    {
        return Model + ":\n" + "\t\tPower: " + Power + "\n" + "\t\tDisplacement: " + (Displacement==0?"n/a":Displacement) + "\n" + "\t\tEfficiency: " + Efficiency;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, Engine> engines = new Dictionary<string, Engine> ();
        List<Car> cars = new List<Car> ();
        int N = int.Parse(Console.ReadLine());
        for(int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split(" ");
            string model = input[0];
            int power = int.Parse(input[1]);
            int displacement = 0;
            string efficiency = null;
            if(input.Length > 2)
            {
                if (input.Length > 2)
                {
                    try
                    {
                        displacement = int.Parse(input[2]);
                        efficiency = input[3];
                    }
                    catch (Exception e)
                    {
                        if (!(e is IndexOutOfRangeException))
                        {
                            efficiency = input[2];
                        }
                    }
                }
            }

            engines.Add(model, new Engine(model, power, displacement, efficiency));
        }

        int M = int.Parse(Console.ReadLine());
        for (int i = 0;i < M; i++)
        {
            string[] input = Console.ReadLine().Split(" ");
            string model = input[0];
            if (!engines.ContainsKey(input[1]))
            {
                Console.WriteLine("Unknown engine model");
                i--;
                continue;
            }
            Engine engine = engines[input[1]];
            int weight = 0;
            string color = null;
            if(input.Length > 2)
            {
                try
                {
                    weight = int.Parse(input[2]);
                    color = input[3];
                } catch (Exception e)
                {
                    if(!(e is IndexOutOfRangeException))
                    {
                        color = input[2];
                    }
                }
            }
            cars.Add(new Car(model, engine, weight, color));
        }
        cars.ForEach(car => Console.WriteLine(car.ToString()));
    }
}