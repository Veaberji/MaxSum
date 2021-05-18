using System;

namespace MaxSum
{
    public class Input
    {
        public static string UserPath()
        {
            Console.Write("Enter the path to a file \n>>> ");
            string path = Console.ReadLine();

            return path;
        }
    }
}
