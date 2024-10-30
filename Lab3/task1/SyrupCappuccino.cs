using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.task1
{
    public class SyrupCappuccino:Cappuccino
    {
        private SyrupType _syrup;
        public SyrupType syrup { get { return _syrup; } }

        public SyrupCappuccino(Intensity PcoffeIntensity, string? PcoffyName, int PmlOfMilk, SyrupType syrup) : base(PcoffeIntensity, PcoffyName, PmlOfMilk)
        {
            _syrup = syrup;
        }
    }
}
