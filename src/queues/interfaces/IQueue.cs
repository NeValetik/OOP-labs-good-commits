using System;
using System.Collections.Generic;

namespace Lab4.src.queues.interfaces
{
    public interface IQueue<T>
    {
        public void Enqueue(T item);
        public T? Dequeue();
        public T? Peek();
        public int Count();
    }
}