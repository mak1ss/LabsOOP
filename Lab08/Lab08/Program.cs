using Lab08;

internal class Program
{
    private static int Count<T>(List<T> list, T value) where T : IComparable<T>
    {
        int count = 0;
        list.ForEach(box =>
        {
            if (box.CompareTo(value) > 0)
            {
                count++;
            }
        });
        return count;
    }
    private static void Swap<T>(List<T> list, int i1, int i2)
    {
        var temp = list[i1];
        list[i1] = list[i2];
        list[i2] = temp;
    }
    private static void Main(string[] args)
    {
         /** problem 0
        Box<int> box1 = new Box<int>(123123);
        Box<string> box2 = new Box<string>("life in a box");

        Console.WriteLine(box1);
        Console.WriteLine(box2);

        // problem 1
        int n = int.Parse(Console.ReadLine());
        string input;
        for (int i = 0; i < n; i++)
        {
            input = Console.ReadLine();
            Console.WriteLine(new Box<string>(input));
        }

        //problem 2
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            input = Console.ReadLine();
            Console.WriteLine(new Box<int>(int.Parse(input)));
        }

        //problem 3 
       List<Box<string>> boxes = new List<Box<string>>();
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            input = Console.ReadLine();
            boxes.Add(new Box<string>(input));
        }

        string[] indexes = Console.ReadLine().Split(" ");
        Swap<Box<string>>(boxes, int.Parse(indexes[0]), int.Parse(indexes[1]));
        boxes.ForEach(box => Console.WriteLine(box));

        //problem 4
        List<Box<int>> boxes1 = new List<Box<int>>();
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            input = Console.ReadLine();
            boxes1.Add(new Box<int>(int.Parse(input));
        }

        indexes = Console.ReadLine().Split(" ");
        Swap<Box<int>>(boxes1, int.Parse(indexes[0]), int.Parse(indexes[1]));
        boxes1.ForEach(box => Console.WriteLine(box));

        //problem 5
        int n = int.Parse(Console.ReadLine());
        List<Box<string>> boxes2 = new List<Box<string>>();
        string input;
        for (int i = 0; i < n; i++)
        {
            input = Console.ReadLine();
            boxes2.Add(new Box<string>(input));
        }
        input = Console.ReadLine();
        Console.WriteLine(Count<Box<string>>(boxes2, new Box<string>(input)));**/

        //problem 6
        int n = int.Parse(Console.ReadLine());
        string input;
        List<Box<double>> boxes3 = new List<Box<double>>();
        for (int i = 0; i < n; i++)
        {
            input = Console.ReadLine();
            boxes3.Add(new Box<double>(double.Parse(input)));
        }
        input = Console.ReadLine();
        Console.WriteLine(Count<Box<double>>(boxes3, new Box<double>(double.Parse(input))));
    }
}