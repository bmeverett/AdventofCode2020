using System;
namespace AdventofCode2020.Puzzles
{
    public class Puzzle3
    {
        public static void Run(int part)
        {

            //System.IO.StreamReader file = new System.IO.StreamReader("Puzzles/Puzzle3/Puzzle3Input.txt");
            //string line;

            //while ((line = file.ReadLine()) != null)
            //{

            //}

            //file.Close();

            string[] input = System.IO.File.ReadAllLines("Puzzles/Puzzle3/Puzzle3Input.txt");


            if (part == 1)
            {
                Part1(input);
            }
            else if (part == 2)
            {
                Part2();
            }
        }

        private static void Part1(string[] input)
        {
            bool exit = false;
            int trees = 0;
            int x = 0;
            int y = 1;

            while (!exit)
            {
                if (x > input.Length -1)
                {
                    exit = true;
                    break;
                }

                if(input[x][y] == '#')
                {
                    trees += 1;
                }

                int rowLength = input[x].ToCharArray().Length - 1;
                int temp = y + 3;
                y += 3;

                //for (; y < temp; y++)
                //{
                //    if ((y > rowLength && input[x][y - rowLength] == '#') || (y <= rowLength && input[x][y] == '#'))
                //    {
                //        //trees += 1;
                //    }
                //}

                if(y > rowLength)
                {
                    y -= rowLength;
                }

                x += 1;
            }

            Console.WriteLine("Trees encountered: {0}", trees);
        }

        private static void Part2()
        {

        }

    }
}
