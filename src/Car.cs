using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.src
{
    public class Car
    {
        public int id { get; set; }
        public string type { get; set; }
        public string passengers { get; set; }
        public bool isDining { get; set; }
        public int consumption { get; set; }
        public Car(int id, string type, string passengers, bool isDining, int consumption)
        {
            this.id = id;
            this.type = type;
            this.passengers = passengers;
            this.isDining = isDining;
            this.consumption = consumption;
        }
    }
}
