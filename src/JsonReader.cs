using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lab4.src
{   
    public class JsonReader
    {
        private Semaphore _semaphore;
        private int _countdown = 0;
        private HashSet<string> _processedFiles = new HashSet<string>();

        public JsonReader(Semaphore semaphore)
        {
            _semaphore = semaphore;
        }

        public void ReadStream(int n = 3)
        {
            int readCount = 0;

            do
            {
                readCount = ReadDirectory();

                if (readCount != 0)
                    _countdown = 0;
                else
                    _countdown++;

                Thread.Sleep(n * 1000);
            } while (_countdown < 3);
        }

        public int ReadDirectory(string directoryPath = "../../../queue/")
        {
            int count = 0;
            try
            {

                string[] jsonFiles = Directory.GetFiles(directoryPath, "*.json");

                foreach (string file in jsonFiles)
                {
                    if (_processedFiles.Contains(file))
                        continue;

                    string? jsonString = File.ReadAllText(file);
                    if (jsonString == null)
                        continue;

                    Car? car = JsonSerializer.Deserialize<Car>(jsonString);
                    if (car != null)
                    {
                        _semaphore.Classify(car);
                        count++;
                        _processedFiles.Add(file);
                    }
                }
                Console.WriteLine($"Successfully read {count} files.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }


            return count;
        }
    }
}
