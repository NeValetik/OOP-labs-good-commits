using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.task3
{
    public class Americano : Coffee
    {
        private int _mlOfWater;
        public int mlOfWater { get { return _mlOfWater; } set { _mlOfWater = value; } }

        //public Americano(Intensity PcoffeIntensity, string? PcoffyName, int PmlOfWater) : base(PcoffeIntensity, PcoffyName)
        //{
        //    Console.WriteLine("Adding " + PmlOfWater + " mg of water");
        //    _mlOfWater = PmlOfWater;
        //}

        public Americano() { }

        public Americano MakeAmericano(Intensity PcoffeIntensity, string? PcoffyName, int PmlOfWater)
        {
            base.makeCoffee(PcoffeIntensity, PcoffyName);
            Console.WriteLine("Adding " + PmlOfWater + " mg of water");
            mlOfWater = PmlOfWater;
            return this;
        }

        public override void PrintCoffeDetails()
        {
            base.PrintCoffeDetails();
            Console.WriteLine("Milliliters of water: " + mlOfWater);
        }
    }
}
