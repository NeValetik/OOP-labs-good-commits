using Lab4.src.CarStationComponents;
using Lab4.src.CarStationComponents.interfaces;
using Lab4.src.queues;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text.Json;

namespace Lab4.src
{
    public class Semaphore
    {
        private List<CarStation> _carStations;

        public Semaphore(List<CarStation> carStations)
        {
            _carStations = carStations;
        }
        public void Classify(Car car)
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
            if (station != null)
            {
                station.addCar(car);
            }
        }
    }
}
