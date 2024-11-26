using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab4.src.queues.interfaces;


namespace Lab4.src.queues
{
    internal class ArrayQueue<T> : IQueue<T>
    {
        protected List<T> _queue = new List<T>();

        public void Enqueue(T item)
        {
            _queue.Add(item);
        }

        public T? Dequeue()
        {
            if (_queue.Count == 0)
                return default;

            T item = _queue[0];
            _queue.RemoveAt(0);
            return item;
        }

        public T? Peek()
        {
            if (_queue.Count == 0)
                return default;

            return _queue[0];
        }

        public int Count() => _queue.Count;
        
    }
}
