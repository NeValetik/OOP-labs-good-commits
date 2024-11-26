using Lab4.src.queues.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.src.queues
{
    public class QueueDistributor
    {
        public static IQueue<Car> GetQueue() {
            double rnd = new Random().NextDouble();
            if (rnd < 1 / 3)
                return new ArrayQueue<Car>();
            if (rnd < 2 / 3 )
                return new LinkedQueue<Car>();
            else
                return new PriorityQueue<Car>();
        }
    }
}
