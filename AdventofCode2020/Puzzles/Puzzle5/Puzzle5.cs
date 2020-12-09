using System;

namespace AdventofCode2020.Puzzles
{
    public class Puzzle5
    {
        public static void Run(int part)
        {
            string[] tickets = System.IO.File.ReadAllLines("Puzzles/Puzzle5/Puzzle5.txt");
            int maxSeat = 0;

            foreach (string ticket in tickets)
            {
                int min = 0;
                int max = 127;
                int seatMin = 0;
                int seatMax = 7;
                int row = 0;
                int seat = 0;

                for (int i = 0; i < ticket.Length; i++)
                {
                    if (ticket[i] == 'F')
                    {
                        max = (min + max) / 2;

                        if (i == 6)
                        {
                            row = max;
                        }

                    }
                    else if (ticket[i] == 'B')
                    {
                        min = (min + max) / 2;
                        if (i == 6)
                        {
                            row = min;
                        }
                    }
                    else if (ticket[i] == 'L')
                    {
                        seatMax = (seatMin + seatMax) / 2;
                        if (i == ticket.Length - 1)
                        {
                            seat = seatMax;
                        }
                    }
                    else if (ticket[i] == 'R')
                    {
                        seatMin = (seatMin + seatMax) / 2 + 1;
                        if (i == ticket.Length - 1)
                        {
                            seat = seatMin;
                        }
                    }

                }

                int newSeat = (row * 8) + seat;
                maxSeat = Math.Max(maxSeat, newSeat);

            }

            // 903 to low
            // Answer is 904 off by 1
            Console.WriteLine("The max seatID is {0}", maxSeat);
        }
    }
}
