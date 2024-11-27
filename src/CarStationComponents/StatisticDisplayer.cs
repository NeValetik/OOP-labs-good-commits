using Lab4.src.CarStationComponents.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.src.CarStationComponents
{
    public class StatisticDisplayer
    {
        public static void DisplayResults()
        {
            Console.WriteLine("\n\nWere served " +(GasStation.GetCount()+ElectricStation.GetCount()) + " cars.");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Gas station cars: " + GasStation.GetCount());
            Console.WriteLine("Electric station cars: " + ElectricStation.GetCount());
            Console.WriteLine("People dinner: " + PeopleDinner.GetCount());
            Console.WriteLine("Robot dinner: " + RobotDinner.GetCount());
        }

    }
}
