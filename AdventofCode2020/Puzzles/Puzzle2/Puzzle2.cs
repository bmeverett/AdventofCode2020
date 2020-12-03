using System;
namespace AdventofCode2020.Puzzles.Puzzle2
{
    public class Puzzle2
    {
        public static void Run(int part)
        {
            string input = System.IO.File.ReadAllText("Puzzles/Puzzle2/Puzzle2Input.txt");
            string[] lines = input.Split(Environment.NewLine);

            if (part == 1)
            {
                Part1(lines);
            }
            else if (part == 2)
            {
                Part2(lines);
            }


        }

        private static void Part1(string[] lines)
        {
            int count = 0;
            foreach (var line in lines)
            {
                string[] split = line.Split(" ");

                string[] numbersSplit = split[0].Split("-");
                int min = int.Parse(numbersSplit[0]);
                int max = int.Parse(numbersSplit[1]);

                char letter = char.Parse(split[1].Split(":")[0]);
                string password = split[2];

                int letterCount = 0;
                foreach (var c in password)
                {
                    if (c == letter)
                    {
                        letterCount += 1;
                    }
                }

                if (min <= letterCount && letterCount <= max)
                {
                    count += 1;
                }

            }

            Console.WriteLine("The count is {0}", count);
        }

        private static void Part2(string[] lines)
        {
            int count = 0;
            foreach (var line in lines)
            {
                string[] split = line.Split(" ");

                string[] numbersSplit = split[0].Split("-");
                int min = int.Parse(numbersSplit[0]) - 1;
                int max = int.Parse(numbersSplit[1]) -1;

                char letter = char.Parse(split[1].Split(":")[0]);
                string password = split[2];

                if(password[min] == letter && password[max] ==letter)
                {
                    continue;
                }
                else if(password[min] == letter || password[max] == letter)
                {
                    count += 1;
                }

            }

            Console.WriteLine("The count is {0}", count);
        }

    }
}
