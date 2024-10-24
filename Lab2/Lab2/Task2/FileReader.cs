using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Task2
{
    public class FileReader
    {
        public static string? readFileIntoString(string? path) {
            if (string.IsNullOrEmpty(path)) return null;
            return path.Substring(path.LastIndexOf('\\') + 1) + " "+File.ReadAllText(path);
        }
    }
}
