using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPatternExample.Ducks;

namespace ObserverPatternExample {
    public interface IFlock {
        void Attach(IDuck duck);
        void Detach(IDuck duck);
        void Notify();
    }
}
