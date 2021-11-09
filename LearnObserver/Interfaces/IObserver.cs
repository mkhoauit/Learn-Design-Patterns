using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnObserver.Interfaces
{
    public interface IObserver
    {
        public void Update(ISubject subject);
    }
}
