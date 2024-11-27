using Lab4.src.CarStationComponents.interfaces;
using Lab4.src.CarStationComponents;
using Lab4.src.queues;
//using Lab4.src;



//using NUnit.Framework.Internal.Execution;

namespace Lab4.src
{
    public class Program
    {
        public static void Main()
        {
            List<CarStation> carStations = new List<CarStation> 
            {
                new CarStation(new PeopleDinner(), new GasStation(), QueueDistributor.GetQueue()),
                new CarStation(new PeopleDinner(), new ElectricStation(), QueueDistributor.GetQueue()),
                new CarStation(new RobotDinner(), new GasStation(), QueueDistributor.GetQueue()),
                new CarStation(new RobotDinner(), new ElectricStation(), QueueDistributor.GetQueue())
            };
            Semaphore semaphore = new Semaphore(carStations);
            JsonReader jsonReader = new JsonReader(semaphore);
            jsonReader.ReadStream();
            foreach(CarStation cs in carStations){
                cs.serveCars();
            }
            StatisticDisplayer.DisplayResults();
        }
    }
}
