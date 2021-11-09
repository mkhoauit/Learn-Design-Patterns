using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDecorator.Classes
{
    public class PepperDecorator : APizzaDecorator
    {
        public PepperDecorator(APizza pizza) : base(pizza)
        {
        }

        public override String doPizza()
        {
            String type = mPizza.doPizza();
            return type + addPepper();
        }


        // It adds pepper to an existing pizza
        private String addPepper()
        {
            return "+ Pepper";
        }
    }
}
