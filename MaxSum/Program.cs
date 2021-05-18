using System;

namespace MaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = Selector.SelectPath(args);
                var manager = new FileContentManager(path);

                var defectiveLines = manager.GetDefectiveLines();
                int maxSumLine = manager.GetMaxSumLine();

                Output.MaxSumContent(maxSumLine, defectiveLines);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
