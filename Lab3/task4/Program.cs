using ClassLibrary;
public static class Program
{

    public static void Main(string[] args)
    {
        Barista bar = new("Dima");
        bar.getCoffeeOrder("Cappuccino","Americano","Coffee","Pumkin Spice Latte");
        bar.prepareCoffee();
    }
}
