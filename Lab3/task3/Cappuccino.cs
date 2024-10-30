using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.task3
{
    public class Cappuccino : Coffee
    {
        private int _mlOfMilk;

        public int mlOfMilk { get { return _mlOfMilk; } set { _mlOfMilk = value; } }

        //public Cappuccino(Intensity PcoffeIntensity, string? PcoffyName, int PmlOfMilk) : base(PcoffeIntensity, PcoffyName)
        //{
        //    _mlOfMilk = PmlOfMilk;
        //}
        public Cappuccino() { }

        public Cappuccino MakeCappuccino(Intensity PcoffeIntensity, string? PcoffyName, int PmlOfMilk) {
            base.makeCoffee(PcoffeIntensity, PcoffyName);
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
