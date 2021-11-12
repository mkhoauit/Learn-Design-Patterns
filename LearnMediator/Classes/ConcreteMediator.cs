using LearnMediator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMediator.Classes
{
    class ConcreteMediator : IMediator
    {
        private Doctor _doctor;

        private Nurse _nurse;

        public ConcreteMediator(Doctor doctor, Nurse nurse)
        {
            this._doctor = doctor;
            this._doctor.SetMediator(this);
            this._nurse = nurse;
            this._nurse.SetMediator(this);
        }

        public void Notify(object sender, string ev)
        {
            if (ev == "A")
            {
                Console.WriteLine("Mediator reacts on event A and triggers folowing operations:");
                Console.WriteLine("Health Check ");
                this._nurse.GiveMedicine();
            }
            

            if (ev == "E")
            {
                Console.WriteLine("Mediator reacts on event C and triggers following operations:");
                Console.WriteLine("Minor Surgery");

                this._doctor.Surgery();
                this._nurse.GiveMedicine();
                
            }
            if (ev == "D")
            {
                Console.WriteLine("Mediator reacts on event D and triggers following operations:");
                Console.WriteLine("Emergency Surgery");
                this._doctor.Surgery();
                this._nurse.GiveMedicine();
                

            }
        }
    }
}
