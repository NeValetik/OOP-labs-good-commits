using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.src
{
    internal class Car
    {
        public required int carID { get; set; }
        public required string type { get; set; }
        public required string passengers { get; set; }
        public required bool isDining { get; set; }
        public required int consumption { get; set; }
    }
}
