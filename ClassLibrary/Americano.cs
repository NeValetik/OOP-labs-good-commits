using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Americano : Coffee
    {
        private int _mlOfWater;
        public int mlOfWater { get { return _mlOfWater; } set { _mlOfWater = value; } }

        //public Americano(Intensity PcoffeIntensity, string? PcoffyName, int PmlOfWater) : base(PcoffeIntensity, PcoffyName)
        //{
        //    Console.WriteLine("Adding " + PmlOfWater + " mg of water");
        //    _mlOfWater = PmlOfWater;
        //}

        internal Americano() { }

        internal Americano MakeAmericano(Intensity PcoffeIntensity, string? PcoffyName, int PmlOfWater)
        {
            base.MakeCoffee(PcoffeIntensity, PcoffyName);
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
