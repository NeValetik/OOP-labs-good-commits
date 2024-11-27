using FluentAssertions;
using Lab4.src.CarStationComponents;
using Lab4.src;
using Lab4.src.queues;

using Xunit;
using Lab4.src.queues.interfaces;

namespace tests.Lab4.Tests
{

    public class QueueTests
    {
        [Fact]
        public void Verify_if_array_queue_peeks()
        {
            IQueue<string> queue = new ArrayQueue<string>();
            queue.Enqueue("car");
            queue.Enqueue("car2");

            queue.Peek().Should().Be("car");
        }

        [Fact]
        public void Verify_if_array_queue_deques()
        {
            IQueue<string> queue = new ArrayQueue<string>();
            queue.Enqueue("car");
            queue.Enqueue("car2");
            queue.Dequeue();
            queue.Peek().Should().Be("car2");
        }

        [Fact]
        public void Verify_if_array_queue_counts()
        {
            IQueue<string> queue = new ArrayQueue<string>();
            queue.Enqueue("car");
            queue.Enqueue("car2");
            queue.Dequeue();
            queue.Count().Should().Be(1);
        }
    }
}
