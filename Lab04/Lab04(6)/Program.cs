using Lab04;

internal class Program
{
    private static void Main(string[] args)
    {
        int rows = int.Parse(Console.ReadLine());
        int samRow = 0;
        int samCol = 0;
        int nikoRow = 0;
        Dictionary<int, char[]> inputRoom = new Dictionary<int, char[]>();

        for (int i = 0; i < rows; i++)
        {
            string rowInput = Console.ReadLine();
            if (rowInput.Contains('S'))
            {
                samRow = i;
                samCol = rowInput.ToList().IndexOf('S');
            }
            else if (rowInput.Contains('N'))
            {
                nikoRow = i;
            }
            inputRoom.Add(i, rowInput.ToCharArray());
        }
        Room room = new Room(inputRoom, samRow, samCol, nikoRow);

        char[] instructions = Console.ReadLine().ToCharArray();
        bool lose = false;
        for (int i = 0; i < instructions.Length; i++)
        {
            
            switch (instructions[i])
            {
                case 'U':
                    if (room.moveUp())
                    {
                        if (room.SamWon)
                        {
                            Console.WriteLine("Nikoladze killed!\n" + room.ToString());
                            i = instructions.Length;
                        }
                    }
                    else
                    {
                        lose = true;
                    }
                    break;
                case 'D':
                    if (room.moveDown())
                    {
                        if (room.SamWon)
                        {
                            Console.WriteLine("Nikoladze killed!\n" + room.ToString());
                            i = instructions.Length;
                        }
                    }
                    else
                    {
                        lose = true;
                    }
                    break;
                case 'R':
                    if (!room.moveRight())
                    {
                        lose = true;
                    }
                    break;
                case 'L':
                    if (!room.moveLeft())
                    {
                        lose = true;
                    }
                    break;
                case 'W':
                    if (!room.wait())
                    {
                        lose = true;
                    }
                    break;
            }
            if (lose)
            {
                Console.WriteLine("Sam died at {0}, {1}\n" + room.ToString(), room.GetSamRow(), room.GetSamCol());
                break;
            }
        }
    }
}