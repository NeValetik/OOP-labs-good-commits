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

        public int mlOfMilk { get { return _mlOfMilk; } }

        public Cappuccino(Intensity PcoffeIntensity, string? PcoffyName, int PmlOfMilk) : base(PcoffeIntensity, PcoffyName)
        {
            Console.WriteLine("Adding " + PmlOfMilk + " mg of milk");
            _mlOfMilk = PmlOfMilk;
        }

        public override void printCoffeDetails()
        {
            base.printCoffeDetails();
            Console.WriteLine("Milliliters of milk: " + mlOfMilk);
        }
    }
}
