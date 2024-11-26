using Lab4.src.CarStationComponents;
using Lab4.src.CarStationComponents.interfaces;
using Lab4.src.queues;
using System.Text.Json;

namespace Lab4.src
{
    internal class Semaphore
    {
        private int _countdown = 0;
        private int _totalCount = 0;

        public void ReadStream(int n = 5)
        {
            int readCount = 0;

            do
            {
                readCount = ReadDirectory();
                _totalCount += readCount;

                if (readCount != 0)
                    _countdown = 0;
                else
                    _countdown++;

                Thread.Sleep(n * 1000);
            } while (_countdown < 3);

            DisplayResults();
        }

        public int ReadDirectory(string directoryPath = "output/")
        {
            int count = 0;
            try
            {
                string[] jsonFiles = Directory.GetFiles(directoryPath, "*.json");

                foreach (string file in jsonFiles)
                {
                    string? jsonString = File.ReadAllText(file);
                    if (jsonString == null)
                        continue;

                    Car? car = JsonSerializer.Deserialize<Car>(jsonString);
                    if (car != null)
                    {
                        Classify(car);
                        count++;
                        File.Delete(file);
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
        private void Classify(Car car) 
        {
            IRefuelable refuelStation;
            if (car.type == "ELECTRIC")
                refuelStation = new ElectricStation();
            else 
                refuelStation = new GasStation();
            IDienable dienablePassanger;
            if (car.passengers == "PEOPLE")
                dienablePassanger = new PeopleDinner();
            else 
                dienablePassanger = new RobotDinner();

            CarStation station = new(dienablePassanger, refuelStation, QueueDistributor.GetQueue());
            station.addCar(car);
            station.serveCars();
        }
        public void DisplayResults()
        {
            Console.WriteLine("\n\nWere served " + _totalCount + " cars.");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Gas station cars: " + GasStation.GetCount());
            Console.WriteLine("Electric station cars: " + ElectricStation.GetCount());
            Console.WriteLine("People dinner: " + PeopleDinner.GetCount());
            Console.WriteLine("Robot dinner: " + RobotDinner.GetCount());
        }
    }
}
