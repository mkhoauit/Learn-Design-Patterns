using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDecorator.Classes
{
    class ChickenPizza : APizza
    {
        public override string doPizza()
        {
            return "This is a Chicken Pizza";
        }
    }
}
