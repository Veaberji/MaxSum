using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MaxSum
{
    public class FileContentManager
    {
        private List<int> _defectiveLines;
        private string _path;
        private string[] _fileLines;
        private bool isLinesCheked;

        public FileContentManager(string path)
        {
            _defectiveLines = new List<int>();
            Check.Path(path);
            _path = path;
            _fileLines = File.ReadAllLines(_path);
        }

        public FileContentManager(string[] array)
        {
            _defectiveLines = new List<int>();
            Check.Array(array);
            _fileLines = array;
        }

        public int GetMaxSumLine()
        {
            var lineNumbers = new List<double>();
            double? sum = null;
            int maxSumLine = 0;

            GetDefectiveLines();

            for (int i = 0; i < _fileLines.Length; i++)
            {
                if (_defectiveLines.Contains(i + 1))
                    continue;

                var line = _fileLines[i].Split(",");

                for (int j = 0; j < line.Length; j++)
                {
                    bool isNumber = double.TryParse(line[j].Replace('.', ','), out double number);

                    lineNumbers.Add(number);
                }

                if (!sum.HasValue && lineNumbers.Count > 0 || sum < lineNumbers.Sum())
                {
                    sum = lineNumbers.Sum();
                    maxSumLine = i + 1;
                    lineNumbers.Clear();
                }
            }

            return maxSumLine;
        }

        public List<int> GetDefectiveLines()
        {
            if (!isLinesCheked)
            {
                for (int i = 0; i < _fileLines.Length; i++)
                {
                    var line = _fileLines[i].Split(",");

                    for (int j = 0; j < line.Length; j++)
                    {
                        bool isNumber = double.TryParse(line[j].Replace('.', ','), out double number);

                        if (!isNumber)
                        {
                            _defectiveLines.Add(i + 1);
                            break;
                        }
                    }
                }
            }

            isLinesCheked = true;
            return _defectiveLines;
        }
    }
}
