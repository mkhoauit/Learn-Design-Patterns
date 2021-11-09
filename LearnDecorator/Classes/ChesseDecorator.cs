using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDecorator.Classes
{
    public class ChesseDecorator : APizzaDecorator
    {
        public ChesseDecorator(APizza pizza) : base(pizza)
        {
        }
        
        public override String doPizza()
        {
            String type = mPizza.doPizza();
            return type + addCheese();
        }

        
        // It adds cheese to an existing pizza
        private String addCheese()
        {
            return "+ Cheese";
        }
    }
}
