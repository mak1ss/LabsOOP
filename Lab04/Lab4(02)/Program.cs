using Lab4;
internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, Engine> engines = new Dictionary<string, Engine>();
        List<Car> cars = new List<Car>();
        int N = int.Parse(Console.ReadLine());
        Engine engine;
        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split(" ");
            string model = input[0];
            int power = int.Parse(input[1]);
            int displacement;
            string efficiency;
            if (input.Length > 2)
            {
                if (int.TryParse(input[2], out displacement))
                {
                    if (input.Length > 3)
                    {
                        efficiency = input[3];
                        engine = new Engine(model, power, displacement, efficiency);
                    }
                    else
                    {
                        engine = new Engine(model, power, displacement);
                    }
                }
                else
                {
                    efficiency = input[2];
                    engine = new Engine(model, power, efficiency);
                }
            }
            else
            {
                engine = new Engine(model, power);

            }
            engines.Add(model, engine);
        }

        int M = int.Parse(Console.ReadLine());
        Car car;
        for (int i = 0; i < M; i++)
        {
            string[] input = Console.ReadLine().Split(" ");
            string model = input[0];
            if (!engines.ContainsKey(input[1]))
            {
                Console.WriteLine("Unknown engine model");
                i--;
                continue;
            }
            Engine selectedEngine = engines[input[1]];
            int weight;
            string color;
            if (input.Length > 2)
            {
                if (int.TryParse(input[2], out weight))
                {
                    if (input.Length > 3)
                    {
                        color = input[3];
                        car = new Car(model, selectedEngine, weight, color);
                    }
                    else
                    {
                        car = new Car(model, selectedEngine, weight);
                    }
                }
                else
                {
                    color = input[2];
                    car = new Car(model, selectedEngine, color);
                }
            }
            else
            {
                car = new Car(model, selectedEngine);
            }
            cars.Add(car);
        }
        cars.ForEach(car => Console.WriteLine(car.ToString()));
    }
}