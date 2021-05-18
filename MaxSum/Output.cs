using System;
using System.Collections.Generic;

namespace MaxSum
{
    class Output
    {
        public static void MaxSumContent(int maxSumLine, List<int> defectiveLines)
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
