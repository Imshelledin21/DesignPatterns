using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPatternExample.Ducks;

namespace ObserverPatternExample.DuckBehaviors {
    public class BehaviorFactory {
        public IBehavior CreateBehavior(Duck duckType) {
            if (duckType.GetType() == typeof (Mallard)) {
                return new MallardBehavior();
            }

            if (duckType.GetType() == typeof (SicklyDuck)) {
                return new SicklyDuckBehavior(duckType);
            }

            if (duckType.GetType() == typeof (RubberDuck)) {
                return new RubberDuckBehavior(duckType);
            }

            if (duckType.GetType() == typeof (CrazyDuck)) {
                return new CrazyDuckBehavior();
            }

            throw new Exception("Duck Type is not valid.");
        }
    }
}
