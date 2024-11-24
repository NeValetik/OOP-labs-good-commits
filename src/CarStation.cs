using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab4.src.queues;
using Lab4.src.CarStationComponents.interfaces;
using Lab4.src.queues.interfaces;

namespace Lab4.src
{
    internal class CarStation
    {
        private IDienable _dienableService;
        private IRefuelable _refuelableService;
        private IQueue<Car> _carQueue;

        public CarStation(IDienable dienable, IRefuelable refuelable, IQueue<Car> queue) 
        {
            _dienableService = dienable;
            _refuelableService = refuelable;
            _carQueue = queue;
        }

        public void serveCars() 
        {
            Car? car = _carQueue.Dequeue();
            
            if (car == null) return; 
            
            if (car.isDining) 
                _dienableService.ServeDinner(car.carID);
            _refuelableService.Refuel(car.carID);
        }

        public void addCar(Car car)
        {
            _carQueue.Enqueue(car);
        }

    }
}
