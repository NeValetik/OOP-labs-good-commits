using Lab4.src.CarStationComponents.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.src.CarStationComponents
{
    internal class GasStation : IRefuelable
    {
        private static int _count = 0;
        public void Refuel(int? carID)
        {
            Console.WriteLine("Refueling gas car " + carID + ".");
            _count++;
        }

        public static int GetCount() => _count;

    }
}
