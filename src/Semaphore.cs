using Lab4.src.CarStationComponents;
using Lab4.src.CarStationComponents.interfaces;
using Lab4.src.queues;
using System.Text.Json;

namespace Lab4.src
{
    internal class Semaphore
    {
        private int _countdown = 0;
        private List<CarStation> _carStations;
        private HashSet<string> _processedFiles = new HashSet<string>();

        public Semaphore(List<CarStation> carStations) {
            _carStations = carStations;
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

        public int ReadDirectory(string directoryPath = "output/")
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
                        Classify(car);
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

            CarStation? station = _carStations.FirstOrDefault(cs =>
                cs.GetRefuelable().GetType() == refuelStation.GetType() &&
                cs.GetDienable().GetType() == dienablePassanger.GetType());
            station?.addCar(car);
        }
    }
}
