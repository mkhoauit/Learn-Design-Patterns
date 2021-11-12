using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMediator.Classes
{
    class Doctor : BaseComponent
    {
        public void Examining()
        {
            Console.WriteLine("Doctor examines patients.");

            this._mediator.Notify(this, "A");
        }

        public void Surgery()
        {
            Console.WriteLine("Doctor surgery patient.");

            this._mediator.Notify(this, "B");
        }
    }
}
