using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPatternExample.DuckBehaviors;

namespace ObserverPatternExample.Ducks {
    public class SicklyDuck : Duck {
        private DuckStates DuckStates;

        public SicklyDuck(Flock flock, BehaviorFactory behavior) : base(flock, behavior) {
            Console.WriteLine("A wild duck has appeared! Though this one is a bit sickly.");
        }

        public override void Update() {
            DuckStates = Flock.DuckStates;
            Behavior.Act(DuckStates);
        }

    }
}
