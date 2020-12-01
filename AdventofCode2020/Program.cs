using System;
using AdventofCode2020.Puzzles;

namespace AdventofCode2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which puzzle would you like to run?");
            string puzzle = Console.ReadLine();

            switch (puzzle)
            {
                case "1":
                    Puzzle1.Run();
                    break;
                default:
                    Console.WriteLine("Puzzle not found");
                    break;
            }
        }
    }
}
