using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Cappuccino : Coffee
    {
        private int _mlOfMilk;

        public int mlOfMilk { get { return _mlOfMilk; } set { _mlOfMilk = value; } }

        //public Cappuccino(Intensity PcoffeIntensity, string? PcoffyName, int PmlOfMilk) : base(PcoffeIntensity, PcoffyName)
        //{
        //    _mlOfMilk = PmlOfMilk;
        //}
        internal Cappuccino() { }

        internal Cappuccino MakeCappuccino(Intensity PcoffeIntensity, string? PcoffyName, int PmlOfMilk)
        {
            base.MakeCoffee(PcoffeIntensity, PcoffyName);
            Console.WriteLine("Adding " + PmlOfMilk + " mg of milk");
            mlOfMilk = PmlOfMilk;
            return this;
        }

        public override void PrintCoffeDetails()
        {
            base.PrintCoffeDetails();
            Console.WriteLine("Milliliters of milk: " + mlOfMilk);
        }
    }
}
