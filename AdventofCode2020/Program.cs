using System;
using AdventofCode2020.Puzzles;
using AdventofCode2020.Puzzles.Puzzle2;

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
                case "2a":
                    Puzzle2.Run(1);
                    break;
                case "2b":
                    Puzzle2.Run(2);
                    break;
                case "3a":
                    Puzzle3.Run(1);
                    break;
                case "4a":
                    Puzzle4.Run(1);
                    break;
                case "4b":
                    Puzzle4.Run(2);
                    break;
                default:
                    Console.WriteLine("Puzzle not found");
                    break;
            }
        }
    }
}
