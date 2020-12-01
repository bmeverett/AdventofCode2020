using System;

namespace AdventofCode2020.Puzzles
{
    public class Puzzle1 : IPuzzle
    {
        public static void Run()
        {
            string txt = System.IO.File.ReadAllText("Puzzles\\Puzzle1Input.txt");
            string[] split = txt.Split( new []{
                Environment.NewLine
            }, StringSplitOptions.None);

            bool found = false;
            for (int i = 0; i < split.Length; i++)
            {
                if (found) break;

                if(!int.TryParse(split[i], out int num))
                {
                    continue;
                }

                for (int j = i + 1; j < split.Length -1; j++)
                {
                    int num2 = int.Parse(split[j]);

                    for (int k = j + 1; k < split.Length - 2; k++)
                    {
                        int num3 = int.Parse(split[k]);
                        if (num + num2 + num3 == 2020)
                        {
                            Console.WriteLine("The answer is {0}", num * num2 * num3);
                            found = true;
                            break;
                        }
                    }
                }



            }


        }
    }
}
