using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.task2
{
    public class Coffee
    {   
        private Intensity _coffeIntensity;
        private string? _coffeName;

        public string? coffeName { get { return _coffeName; }}
        public Intensity coffeIntensity{ get { return _coffeIntensity; }}

        public Coffee(Intensity PcoffeIntensity) {
            this._coffeIntensity = PcoffeIntensity;
            this._coffeName = "Coffe";
        }

        public Coffee(Intensity PcoffeIntensity, string? PcoffeName)
        {
            this._coffeIntensity = PcoffeIntensity;
            this._coffeName = PcoffeName;
        }

        public virtual void printCoffeDetails() {
            Console.WriteLine("Coffe Intensity: " + coffeIntensity + "\nCoffe Name: " + coffeName);
        }
    }
}
