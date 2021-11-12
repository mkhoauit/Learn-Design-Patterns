using LearnCommand.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCommand.Classes
{
    class BuyProduct : IOrder
    {
        private Product _product;
        public BuyProduct(Product product) 
        {
            _product = product;
        }
        public void execute()
        {
            _product.buy();   
        }
    }
}
