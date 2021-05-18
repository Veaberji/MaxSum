using System;
using System.IO;

namespace MaxSum
{
    public class Check
    {
        public static void Path(string path)
        {
            if (!File.Exists(path))
                throw new ArgumentException("Error: file don`t exists " +
                                       "(path must be the first command line argument");
        }

        public static void Array(string[] array)
        {
            if (array == null)
                throw new ArgumentException("Error: 'array' can't be null");
        }

    }
}
