using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab4.src.queues.interfaces;


namespace Lab4.src.queues
{
    public class PriorityQueue<T> : IQueue<T>
    {
        private int _currentPriority;
        protected SortedDictionary<int, Queue<T>> priorityQueues;

        public PriorityQueue()
        {
            priorityQueues = new SortedDictionary<int, Queue<T>>();
            _currentPriority = 1;
        }

        public void Enqueue(T item)
        {
            if (!priorityQueues.ContainsKey(_currentPriority))
                priorityQueues[_currentPriority] = new Queue<T>();

            priorityQueues[_currentPriority].Enqueue(item);
            _currentPriority++;
        }

        public T? Dequeue()
        {
            if (priorityQueues.Count == 0)
                return default;

            var highestPriority = priorityQueues.Keys.Min();
            var queue = priorityQueues[highestPriority];

            T value = queue.Dequeue();
            if (queue.Count == 0)
                priorityQueues.Remove(highestPriority);

            return value;
        }

        public T? Peek()
        {
            if (priorityQueues.Count == 0)
                return default;

            var highestPriority = priorityQueues.Keys.Min();
            var queue = priorityQueues[highestPriority];

            return queue.Peek();
        }

        public int Count() => priorityQueues.Values.Sum(q => q.Count);
    }
}
