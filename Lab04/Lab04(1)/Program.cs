using System;
using System.Collections.Generic;
using Lab04;
public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();
        Car c;
        Model model;
        Engine engine;
        Cargo cargo;
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(" ");
            model = new Model(input[0]);
            engine = new Engine(int.Parse(input[1]), int.Parse(input[2]));
            cargo = new Cargo(int.Parse(input[3]), input[4]);
            List<Tire> tires = new List<Tire>();
            tires.Add(new Tire(double.Parse(input[5]), int.Parse(input[6])));
            tires.Add(new Tire(double.Parse(input[7]), int.Parse(input[8])));
            tires.Add(new Tire(double.Parse(input[9]), int.Parse(input[10])));
            tires.Add(new Tire(double.Parse(input[11]), int.Parse(input[12])));
            cars.Add(new Car(model, engine, cargo, tires));
        }
        string type = Console.ReadLine();
        IEnumerable<Car> resultList = new List<Car>();
        if (type.Equals("fragile"))
        {
            resultList = from car in cars
                         where car.Cargo.Type.Equals("fragile")
                         select car;
            resultList.Where(car => car.Tires.Where(tire => tire.Pressure < 1).Count() > 0).Select(car => car).ToList().ForEach(car => Console.WriteLine(car));
            

        }
        else if (type.Equals("flamable"))
        {
            resultList = from car in cars
                         where car.Cargo.Type.Equals("flamable")
                         select car;
            resultList.Where(car => car.Engine.Power > 250).Select(car => car).ToList().ForEach(car => Console.WriteLine(car));
            
        }
    }
}
