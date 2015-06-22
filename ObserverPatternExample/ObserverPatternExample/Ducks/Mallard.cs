using System;
using ObserverPatternExample.DuckBehaviors;
using ObserverPatternExample.Ducks;

namespace ObserverPatternExample.Ducks {
    public class Mallard : Duck {
        private DuckStates DuckStates;

        public Mallard(Flock flock, BehaviorFactory behavior) : base(flock, behavior) {
            Console.WriteLine("A wild Mallard has appeared!" + "\r\n");
        }

        public override void Update() {
            DuckStates = Flock.DuckStates;
            Behavior.Act(DuckStates);
        }

    }
}
