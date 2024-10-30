using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.task1
{
    public class Cappuccino : Coffee
    {
        private int _mlOfMilk;

        public int mlOfMilk { get { return _mlOfMilk; } }

        public Cappuccino(Intensity PcoffeIntensity, string? PcoffyName,int PmlOfMilk) : base(PcoffeIntensity, PcoffyName) 
        {
            _mlOfMilk = PmlOfMilk;
        }
    }
}
