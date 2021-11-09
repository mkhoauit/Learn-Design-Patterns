using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDecorator.Classes
{
    public abstract class APizzaDecorator : APizza
    {
        protected APizza mPizza;
        public APizzaDecorator(APizza pizza) 
        {
            mPizza = pizza;
        }
        public APizza getPizza()
        {
            return mPizza;
        }

        public void setPizza(APizza mPizza)
        {
            this.mPizza = mPizza;
        }

    }
}
