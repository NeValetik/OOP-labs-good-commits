using FluentAssertions;
using Lab4.src.CarStationComponents;
using Lab4.src;
using Lab4.src.queues;

//using Lab4.src.CarStationComponents.interfaces;
//using Lab4.src.queues;
using Xunit;

namespace tests.Lab4.Tests
{

    public class CarStationTest
    {
        [Fact]
        public void Verify_if_car_from_queue_dequed_after_serving()
        {
            Console.WriteLine("Here");
            var carStation = new CarStation(new PeopleDinner(), new GasStation(), new ArrayQueue<Car>());
            var queue = carStation.GetQueue();
            var car1 = new Car(10, "Type", "PEOPLE", true, 20);
            var car2 = new Car(carID: 11, type: "Type", passengers: "PEOPLE", isDining: true, consumption: 20);
            queue.Enqueue(car1);
            queue.Enqueue(car2);

            carStation.serveCars();
            queue.Peek().Should().Be(car2);
        }

        [Fact]
        public void Verify_if_car_enqued_in_station_after_adding()
        {
            Console.WriteLine("Here");
            var carStation = new CarStation(new PeopleDinner(), new GasStation(), new ArrayQueue<Car>());
            var queue = carStation.GetQueue();
            var car1 = new Car(10, "Type", "PEOPLE", true, 20);
            carStation.addCar(car1);

            queue.Peek().Should().Be(car1);
        }

    }
}
