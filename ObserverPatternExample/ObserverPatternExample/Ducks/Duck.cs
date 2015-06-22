using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPatternExample.DuckBehaviors;

namespace ObserverPatternExample.Ducks {
    public abstract class Duck : IDuck {
        public IBehavior Behavior;
        public Flock Flock;

        protected Duck(Flock flock, BehaviorFactory behavior) {
            Behavior = behavior.CreateBehavior(this);
            Flock = flock;
        }

        public abstract void Update();

    }
}
