internal class Rectangle
{   
    public string id { get; }
    public int x { get; }  
    public int y { get; }
    public int width { get; }
    public int height { get; }

    public Rectangle(string id, int width, int height, int x, int y)
    {
        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;
    }
    public bool CheckIntersection(Rectangle other)
    {
        if(other == null) {  return false; }
        if(this.x == other.x && this.y == other.y) { return true; }
        if (this.y < other.y) 
        {
           if((other.y - other.height) > this.y)
           {
                return false;
           } else
           {
                if(other.x < this.x)
                {
                    return (other.x + other.width) >= this.x ;
                } else
                {
                    return (this.x + this.width) >= other.x;
                }
           }
        } else if((this.y - height) > other.y)
        {

            return false;
        } else
        {
            if (other.x < this.x)
            {
                return (other.x + other.width) >= this.x;
            }
            else
            {
                return (this.x + this.width) >= other.x;
            }
        }
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, Rectangle> recs = new Dictionary<string, Rectangle>();
        string[] input = Console.ReadLine().Split(" ");
        int N = int.Parse(input[0]);
        int M = int.Parse(input[1]);
        for(int i = 0; i < N; i++)
        {
            input = Console.ReadLine().Split(" ");
            if(input.Length != 5)
            {
                Console.WriteLine("Invalid input");
                i--;
                continue;
            }
            recs.Add(input[0], new Rectangle(input[0], int.Parse(input[1]), int.Parse(input[2]), int.Parse(input[3]), int.Parse(input[4])));
        }
        for(int i = 0; i < M; i++)
        {
            input = Console.ReadLine().Split(" ");
            if (input.Length != 2 || (!recs.ContainsKey(input[0]) || !recs.ContainsKey(input[1])))
            {
                Console.WriteLine("Invalid id");
                i--;
                continue;
            }
            Rectangle rec1 = recs[input[0]];
            Rectangle rec2 = recs[input[1]];
            Console.WriteLine(rec1.CheckIntersection(rec2));
        }
    }
}