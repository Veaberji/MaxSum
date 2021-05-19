using System;
using System.Collections.Generic;

namespace MaxSum
{
    public class UserInteraction
    {
        public static string SelectPath(string[] args)
        {
            if (args.Length > 0)
                return args[0];

            return InputPath();
        }

        public static string InputPath()
        {
            Console.Write("Enter the path to a file \n>>> ");
            string path = Console.ReadLine();

            return path;
        }

        public static void OutputMaxSumContent(int maxSumLine, List<int> defectiveLines)
        {
            if (maxSumLine == 0)
                Console.WriteLine("The file doesn't contain any supported data");
            else
                Console.WriteLine($"Line {maxSumLine} has a max sum.");

            if (defectiveLines.Count != 0)
            {
                Console.WriteLine("Defective lines:");
                foreach (int line in defectiveLines)
                {
                    Console.Write(line + " ");
                }
            }
        }
    }
}
