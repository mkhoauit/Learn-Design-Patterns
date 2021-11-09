using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAdapter.Classes
{
    class Adaptee2
    {
        public string GetSpecificRequest()
        {
            return "A balloon with oxygen inside";
        }
        public string GetColor()
        {
            return "blue";
        }
    }
}
