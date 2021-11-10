using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnBuilder.Classes
{
    class Service
    {
        private List<object> _service = new List<object>();

        public void Add(string service)
        {
            this._service.Add(service);
        }

        public string ListService()
        {
            string str = string.Empty;

            for (int i = 0; i < this._service.Count; i++)
            {
                str += this._service[i] + ", ";
            }

            str = str.Remove(str.Length - 2); // removing last ",c"

            return "Service: " + str + "\n";
        }
    }
}
