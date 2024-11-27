using System;
using Lab4.src.queues.interfaces;

namespace Lab4.src.queues
{
    public class CircularQueue<T> : IQueue<T>
    {
        private T[] _items;
        private int _front;
        private int _rear;
        private int _size;
        private int _capacity;

        public CircularQueue(int capacity = 10)
        {
            _capacity = capacity;
            _items = new T[_capacity];
            _front = 0;
            _rear = -1;
            _size = 0;
        }

        public void Enqueue(T item)
        {
            if (_size == _capacity)
            {
                throw new InvalidOperationException("Queue is full.");
            }

            _rear = (_rear + 1) % _capacity;
            _items[_rear] = item;
            _size++;
        }

        public T? Dequeue()
        {
            if (_size == 0)
            {
                return default;
            }

            T item = _items[_front];
            _front = (_front + 1) % _capacity;
            _size--;

            return item;
        }

        public T? Peek()
        {
            if (_size == 0)
            {
                return default;
            }

            return _items[_front];
        }

        public int Count() => _size;
    }
}