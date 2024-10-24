using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2.Task4
{
    public static class Program
    {
        /**/
        public static void Main(string[] args)
        {
            List<TextData> textDatas = new();
            foreach (string arg in args)
            {
                textDatas.Add(new TextData(FileReader.readFileIntoString(arg)));
            }
            foreach (TextData textData in textDatas)
            {
                Console.WriteLine(textData.ToString());
            }

        }
        /**/
    }
}
