using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Barista
    {
        private string _name;
        private List<Coffee> _orderList = new List<Coffee>();

        internal List<Coffee> GetOrderList()
        { return _orderList; }
        public Barista(string name)
        {
            _name = name;
        }

        public void getCoffeeOrder(List<string> coffees)
        {
            List<Coffee> list = GetOrderList();
            foreach (string cof in coffees)
            {
                list.Add(ClassifyCoffee(cof));
            }

        }
        public void getCoffeeOrder(string coffee)
        {
            List<Coffee> list = GetOrderList();
            list.Add(ClassifyCoffee(coffee));
        }

        public void getCoffeeOrder(params string[] coffees)
        {
            List<Coffee> list = GetOrderList();
            foreach (string cof in coffees) {
                list.Add(ClassifyCoffee(cof));
            }
        }

        public void prepareCoffee()
        {
            List<Coffee> list = GetOrderList();
            foreach (Coffee coffee in list)
            {
                switch (coffee)
                {
                    case Coffee c when c.GetType() == typeof(Coffee):
                        c.MakeCoffee(Intensity.LIGHT, "Coffee");
                        break;
                    case Americano c when c.GetType() == typeof(Americano):
                        c.MakeAmericano(Intensity.LIGHT, "Americano", 10);
                        break;
                    case Cappuccino c when c.GetType() == typeof(Cappuccino):
                        c.MakeCappuccino(Intensity.LIGHT, "Cappuccino", 10);
                        break;
                    case SyrupCappuccino c when c.GetType() == typeof(SyrupCappuccino):
                        c.MakeSyrupCappuccino(Intensity.LIGHT, "SyrupCappuccino", 10, SyrupType.MACADAMIA);
                        break;
                    case PumkinSpiceLatte c when c.GetType() == typeof(PumkinSpiceLatte):
                        c.MakePumkinSpiceLatte(Intensity.LIGHT, "PumkinSpiceLatte", 10, 20);
                        break;
                }
                //coffee.PrintCoffeDetails();
            }
        }

        private Coffee? ClassifyCoffee(string cof)
        {
            switch (cof) {
                case "Americano":
                    return new Americano();

                case "Cappuccino":
                    return new Cappuccino();

                case "Coffee":
                    return new Coffee();

                case "Syrup Cappuccino":
                    return new SyrupCappuccino();

                case "Pumkin Spice Latte":
                    return new PumkinSpiceLatte();

                default:
                   return null;
                    
            }
        }
    }
}
