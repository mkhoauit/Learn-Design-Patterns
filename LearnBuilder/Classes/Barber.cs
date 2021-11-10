using LearnBuilder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnBuilder.Classes
{
    class Barber : IBarber
    {
        private Service _service = new Service();

        
        public Barber()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._service = new Service();
        }
        
        public void CleanEar()
        {

            this._service.Add("CleanEar");
        }

        public void HairCut()
        {
            this._service.Add("HairCut");
            
        }

        public void ShaveBeard()
        {
            this._service.Add("ShaveBeard");
        }
        public Service GetService()
        {
            Service result = this._service;

            this.Reset();

            return result;
        }
    }
}
