using System;

namespace MaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = UserInteraction.SelectPath(args);
                var manager = new FileContentManager(path);

                var defectiveLines = manager.GetDefectiveLines();
                int maxSumLine = manager.GetMaxSumLine();

                UserInteraction.OutputMaxSumContent(maxSumLine, defectiveLines);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
