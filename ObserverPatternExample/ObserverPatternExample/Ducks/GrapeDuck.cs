using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPatternExample.DuckBehaviors;

namespace ObserverPatternExample.Ducks
{
    class GrapeDuck : Duck
    {
        private DuckStates _duckStates;
        public GrapeDuck(Flock flock, BehaviorFactory behavior) : base(flock, behavior)
        {
        }

        public override void Update()
        {
            _duckStates = Flock.DuckStates;
            Behavior.Act(_duckStates);
        }
    }
}
