using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPatternExample.DuckBehaviors;

namespace ObserverPatternExample.Ducks {
    public class CrazyDuck : Duck {
        private DuckStates DuckStates;

        public CrazyDuck(Flock flock, BehaviorFactory behavior) : base(flock, behavior) {
            Console.WriteLine("A Crazy-Ass Duck has appeared!" + "\r\n");
        }

        public override void Update() {
            DuckStates = Flock.DuckStates;
            Behavior.Act(DuckStates);
        }
    }
}
