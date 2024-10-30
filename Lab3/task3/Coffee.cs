using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.task3
{
    public class Coffee
    {   
        private Intensity _coffeIntensity;
        private string? _coffeName;

        public string? coffeName { get { return _coffeName; }}
        public Intensity coffeIntensity{ get { return _coffeIntensity; }}

        //public Coffee(Intensity PcoffeIntensity, string? PcoffeName)
        //{
        //    Console.WriteLine("Making " + PcoffeName);
        //    Console.WriteLine("Intensity set to " + PcoffeIntensity);
        //    this._coffeIntensity = PcoffeIntensity;
        //    this._coffeName = PcoffeName;
        //}
        protected Coffee() { }

        public Coffee makeCoffee(Intensity PcoffeIntensity, string? PcoffeName) {
            Console.WriteLine("Making " + PcoffeName);
            Console.WriteLine("Intensity set to " + PcoffeIntensity);
            this._coffeIntensity = PcoffeIntensity;
            this._coffeName = PcoffeName;
            return this;
        }

        public virtual void PrintCoffeDetails() {
            Console.WriteLine("Coffe Intensity: " + coffeIntensity + "\nCoffe Name: " + coffeName);
        }
    }
}
