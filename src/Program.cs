using Lab4.src.CarStationComponents.interfaces;
using Lab4.src.CarStationComponents;
//using Lab4.src;



//using NUnit.Framework.Internal.Execution;

namespace Lab4.src
{
    public class Program
    {
        public static void Main()
        {
            Semaphore semaphore = new Semaphore();
            semaphore.ReadStream();
        }
    }
}
