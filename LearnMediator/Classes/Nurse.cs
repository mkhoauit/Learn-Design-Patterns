using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMediator.Classes
{
    class Nurse : BaseComponent
    {
        public void GiveMedicine()
        {
            Console.WriteLine("Nurse gives medicine to patient.");

            this._mediator.Notify(this, "C");
        }

        public void Support()
        {
            Console.WriteLine("Nurse supports doctor.");

            this._mediator.Notify(this, "D");
        }
        public void BodyTemperature() 
        {
            Console.WriteLine("Nurse measure body temperature.");

            this._mediator.Notify(this, "E");

        }
    }
}
