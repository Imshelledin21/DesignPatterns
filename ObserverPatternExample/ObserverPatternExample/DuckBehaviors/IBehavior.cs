using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternExample.DuckBehaviors {
    public interface IBehavior {
        void Act(DuckStates state);
    }
}
