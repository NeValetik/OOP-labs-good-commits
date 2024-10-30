using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.task3
{
    public class PumkinSpiceLatte:Cappuccino
    {
        private int _mgOfPumkinkSpice;
        public int mgOfPumkinSpice { get { return _mgOfPumkinkSpice; } }

        public PumkinSpiceLatte(Intensity PcoffeIntensity, string? PcoffyName, int PmlOfMilk, int PmgOfPumkinkSpice) : base(PcoffeIntensity, PcoffyName, PmlOfMilk)
        {
            Console.WriteLine("Adding " + PmgOfPumkinkSpice + " mg of pumking spice");
            _mgOfPumkinkSpice = PmgOfPumkinkSpice;
        }

        public override void printCoffeDetails()
        {
            base.printCoffeDetails();
            Console.WriteLine("Milligrams of Pumkin Spice: " + mgOfPumkinSpice);
        }
    }
}
