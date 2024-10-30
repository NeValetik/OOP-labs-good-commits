
namespace Lab3.task2{
    public static class Program
    {

        public static void Main(string[] args)
        {
            Coffee cof = new SyrupCappuccino(Intensity.LIGHT, "SyrupCappucino", 10, SyrupType.CARAMEL);
            cof.printCoffeDetails();
        }
    }
}