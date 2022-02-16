using FactoryLibrary;
using FactoryLibrary.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pizza myPizza = SimplePizzaFactory.CreatePizza(PizzaType.CHEESE);

            Console.WriteLine(myPizza.Prepare());
            Console.WriteLine(myPizza.Bake());
            Console.WriteLine(myPizza.Cut());
            Console.WriteLine(myPizza.Box());

            Console.ReadKey();
        }
    }
}
