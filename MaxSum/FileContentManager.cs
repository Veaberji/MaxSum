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
        private bool _isLinesChecked;
        private List<double> _lineNumbers;
        private double? _sum;
        private int _maxSumLine;

        public FileContentManager(string path)
        {
            _defectiveLines = new List<int>();
            Check.Path(path);
            _path = path;
            _fileLines = File.ReadAllLines(_path);
            _isLinesChecked = false;
            _lineNumbers = new List<double>();
            _sum = null;
            _maxSumLine = 0;
        }

        public FileContentManager(string[] array)
        {
            _defectiveLines = new List<int>();
            Check.Array(array);
            _fileLines = array;
            _isLinesChecked = false;
            _lineNumbers = new List<double>();
            _sum = null;
            _maxSumLine = 0;
        }

        public int GetMaxSumLine()
        {
            GetDefectiveLines();

            return _maxSumLine;
        }

        public List<int> GetDefectiveLines()
        {
            if (_isLinesChecked)
                return _defectiveLines;

            for (int i = 0; i < _fileLines.Length; i++)
            {
                var line = _fileLines[i].Split(",");

                for (int j = 0; j < line.Length; j++)
                {
                    bool isNumber = double.TryParse(line[j].Replace('.', ','), out double number);
                    _lineNumbers.Add(number);

                    if (!isNumber)
                    {
                        _defectiveLines.Add(i + 1);
                        _lineNumbers.Clear();
                        break;
                    }
                }

                if (!_sum.HasValue && _lineNumbers.Count > 0 || _sum < _lineNumbers.Sum())
                {
                    _sum = _lineNumbers.Sum();
                    _maxSumLine = i + 1;
                    _lineNumbers.Clear();
                }
            }
            _isLinesChecked = true;
            return _defectiveLines;
        }
    }
}
