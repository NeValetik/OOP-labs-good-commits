using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Task2
{
    public static class Program
    {
        /**/
        public static void Main(string[] args)
        {
            TextData textData = new(FileReader.readFileIntoString(args[0]));
            Console.WriteLine(textData.ToString());
            
        }
        /**/
    }
}
