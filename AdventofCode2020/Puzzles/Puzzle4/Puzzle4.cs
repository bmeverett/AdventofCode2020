using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventofCode2020.Puzzles
{
    public class Puzzle4
    {
        private static HashSet<string> RequiredKeys = new HashSet<string> { "byr", "iyr", "eyr", "hgt", "hcl", "ecl", "pid" };
        private static int Count = 0;
        public static void Run(int part)
        {
            Process(part);

        }

        private static void Process(int part)
        {
            string line;
            using (StreamReader reader = new StreamReader("Puzzles\\Puzzle4\\Puzzle4.txt"))
            {
                string passport = "";
                while ((line = reader.ReadLine()) != null)
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        passport += " " + line;
                    }
                    else
                    {
                        ProcessPassport(passport, part);
                        passport = string.Empty;

                    }
                }

                // process last passport
                ProcessPassport(passport, part);
            }

            Console.WriteLine("The number of valid passports is {0}", Count);
        }

        private static void ProcessPassport(string passport, int part)
        {
            // process passport
            string[] split = passport.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            HashSet<string> values = new HashSet<string>();

            foreach (var data in split)
            {
                string[] passportData = data.Split(":");
                string key = passportData[0];
                string value = passportData[1];
                if (part == 1)
                {
                    values.Add(key);
                }
                else if (part == 2)
                {
                    // validate keys
                    bool valid = false;
                    int intVal;
                    if(key == "byr" && int.TryParse(value, out intVal))
                    {
                        valid = 1920 <= intVal && intVal <= 2002;
                    }
                    else if(key == "iyr" && int.TryParse(value, out intVal))
                    {
                        valid = 2010 <= intVal && intVal <= 2020;
                    }
                    else if (key == "eyr" && int.TryParse(value, out intVal))
                    {
                        valid = 2020 <= intVal && intVal <= 2030;
                    }
                    else if (key == "hgt")
                    {
                        if (value.Contains("cm"))
                        {
                            valid = int.TryParse(value.Split("cm")[0], out intVal) && intVal >= 150 && intVal <= 193;

                        }
                        else if (value.Contains("in"))
                        {
                            valid = int.TryParse(value.Split("in")[0], out intVal) && intVal >= 59 && intVal <= 76;
                        }
                    }
                    else if (key == "hcl")
                    {
                        Regex regex = new Regex("^#(?:[0-9a-fA-F]{3}){1,2}$");
                        valid = regex.IsMatch(value);
                    }
                    else if (key == "ecl")
                    {
                        valid = new [] {"amb", "blu", "brn", "gry", "grn", "hzl", "oth"}.Contains(value);
                    }
                    else if (key == "pid")
                    {
                        valid = int.TryParse(value, out intVal) && value.Length == 9;
                    }

                    if(valid)
                    {
                        values.Add(key);
                    }
                }
            }

            if (!RequiredKeys.Except(values).Any())
            {
                // valid
                Count++;
            }
        }
    }
}
