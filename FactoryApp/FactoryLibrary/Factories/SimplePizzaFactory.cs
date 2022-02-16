using FactoryLibrary.Pizzas;
using Microsoft.Build.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibrary.Factories
{
    public class SimplePizzaFactory
    {
        public static Pizza CreatePizza(PizzaType pizzaType)
        {
            switch(pizzaType)
            {
                case PizzaType.CHEESE:
                    return new CheesePizza();
                case PizzaType.VEGGIE:
                    return new VeggiePizza();
                case PizzaType.CLAM:
                    return new ClamPizza();
                case PizzaType.PEPPERONI:
                    return new PepperoniPizza();
                default:
                    throw new ArgumentException("Pizza type is invalid");
            }
        }
    }
}
