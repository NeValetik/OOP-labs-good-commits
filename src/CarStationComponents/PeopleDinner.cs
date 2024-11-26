using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab4.src.CarStationComponents.interfaces;

namespace Lab4.src.CarStationComponents
{
    internal class PeopleDinner : IDienable
    {
        private static int _count = 0;
        public void ServeDinner(int? carID)
        {
            Console.WriteLine("Served dinner to person in car " + carID + ".");
            _count++;
        }

        public static int GetCount() => _count;
    }
}
