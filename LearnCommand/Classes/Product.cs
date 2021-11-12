using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCommand.Classes
{
    class Product 
    {
        private String name = "Cookie";
        private int quantity = 10;

        public void buy()
        {
            Console.WriteLine( $" Product Name: {name } , Quantity: { quantity }  (Bought)");
        }
        public void sell()
        {
            Console.WriteLine($" Product Name: {name } , Quantity: { quantity }  (Sold)");
        }
    }
}
