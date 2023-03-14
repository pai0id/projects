using System;
using System.Threading;

namespace epil
{
    class Program
    {
        static void Main(string[] args)
        {
            int col = 0;
            while (true)
            {
                for(int x = 9999;x<10000000;x++)
                {
                    Console.Write("000 0 000");
                    if (col == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green; col++;
                    }
                    else if (col == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green; col++;
                    }
                    else if (col == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red; col++;
                    }
                    else if (col == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red; col++;
                    }
                    else if (col == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue; col++;
                    }
                    else if (col == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue; col = 0;
                    }
                }
                Thread.Sleep(100);
            }
        }
    }
}
