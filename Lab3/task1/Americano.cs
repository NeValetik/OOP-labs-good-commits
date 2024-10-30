using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.task1
{
    public class Americano : Coffee
    {
        private int _mlOfWater;
        public int mlOfWater { get { return _mlOfWater; } }

        public Americano(Intensity PcoffeIntensity, string? PcoffyName, int PmlOfWater) : base(PcoffeIntensity, PcoffyName)
        {
            _mlOfWater = PmlOfWater;
        }
    }
}
