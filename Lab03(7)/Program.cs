using System;
using System.Collections.Generic;
public class Car
{
    private string model;
    private float fuelAmount;
    private float fuelConsumption;
    private int distanceTraveled = 0;
    public string Model
    {
        get;
    }
    public float FuelAmount
    {
        get;
    }
    public float FuelConsumption
    {
        get;
    }
    public int DistanceTravaled
    {
        set;
        get;
    }
    public Car(string model, float fuelAmount, float fuelConsumption)
    {
        this.model = model;
        this.fuelAmount = fuelAmount;
        this.fuelConsumption = fuelConsumption;
    }
    public Car() { }

    public bool Drive(int kilometers)
    {
        if (kilometers * fuelConsumption > fuelAmount)
        {
            return false;
        }
        else
        {
            fuelAmount -= kilometers * fuelConsumption;
            distanceTraveled += kilometers;
            return true;
        }
    }

    public override string ToString()
    {
        return model + " " + fuelAmount + " " + distanceTraveled;
    }
}
public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<String, Car> carSet = new Dictionary<String, Car>();
        Car c;
        string model;
        float fuelAmount;
        float fuelConsumption;
        for (int i = 0; i < n; i++)
        {
            string[] data = Console.ReadLine().Split(" ");
            model = data[0];
            fuelAmount = float.Parse(data[1]);
            fuelConsumption = float.Parse(data[2]);
            c = new Car(model, fuelAmount, fuelConsumption);
            carSet.Add(model, c);
        }
        string input = "";
        while (!input.Equals("End"))
        {
            input = Console.ReadLine();
            if (input.Equals("End"))
            {
                continue;
            }
            string[] command = input.Split(" ");

            if (command.Length < 3 || !command[0].Equals("Drive") || !carSet.ContainsKey(command[1]))
            {
                Console.WriteLine("Invalid input");
                continue;
            }

            if (!carSet[command[1]].Drive(int.Parse(command[2])))
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
        foreach (KeyValuePair<string, Car> car in carSet)
        {
            Console.WriteLine(car.ToString());
        }
    }
}