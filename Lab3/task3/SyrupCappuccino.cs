using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.task3
{
    public class SyrupCappuccino:Cappuccino
    {
        private SyrupType _syrup;
        public SyrupType syrup { get { return _syrup; } }

        //public SyrupCappuccino(Intensity PcoffeIntensity, string? PcoffyName, int PmlOfMilk, SyrupType syrup) : base(PcoffeIntensity, PcoffyName, PmlOfMilk)
        //{
        //    Console.WriteLine("Adding " + syrup + " syrup");
        //    _syrup = syrup;
        //}
        public SyrupCappuccino() { }

        public SyrupCappuccino MakeSyrupCappuccino(Intensity PcoffeIntensity, string? PcoffyName, int PmlOfMilk, SyrupType syrup)
        {
            base.MakeCappuccino(PcoffeIntensity, PcoffyName, PmlOfMilk);
            Console.WriteLine("Adding " + syrup + " syrup");
            _syrup = syrup;
            return this;
        }

        public override void PrintCoffeDetails()
        {
            base.PrintCoffeDetails();
            Console.WriteLine("Syrup: " + syrup);
        }
    }
}
