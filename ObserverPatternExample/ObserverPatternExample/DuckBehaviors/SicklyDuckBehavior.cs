using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPatternExample.Ducks;

namespace ObserverPatternExample.DuckBehaviors {
    public class SicklyDuckBehavior : IBehavior {
        private Duck Duck;

        public SicklyDuckBehavior(Duck duck) {
            Duck = duck;
        }

        public void Act(DuckStates state) {
            switch (state) {
                case DuckStates.Flying:
                    Flying();
                    break;
                case DuckStates.Landing:
                    Landing();
                    break;
                case DuckStates.OnGround:
                    OnGround();
                    break;
                case DuckStates.OnWater:
                    OnWater();
                    break;
                case DuckStates.TakingOff:
                    TakeOff();
                    break;
                default:
                    Console.WriteLine("The Sickly Duck is in a state of limbo. Neither here nor there. Neither coming or going. What are you doing, Mallard?");
                    break;
            }
        }

        private void TakeOff() {
            Console.WriteLine("The Sickly Duck starts to flap its wings weakly, attempting to gain momentum, to take off in flight and not lose the flock!" + "\r\n");
        }

        private void Flying() {
            Console.WriteLine("The Sickly Duck, just managing to take flight, is struggling to maintain momentum.. falling behind the flock!" + "\r\n");
        }

        private void OnGround() {
            Console.WriteLine("The Sickly Duck, just sits there, too weak to do anything more. Maybe a nice human will throw it a breadcrumb or two." + "\r\n");
        }

        private void OnWater() {
            Console.WriteLine("The Sickly Duck, slowly swims across the water, falling over at times. Poor little guy." + "\r\n");
        }

        private void Landing() {
            Console.WriteLine("The Sickly Duck, far behind the flock now, must take a rest, but has lost the flock." + "\r\n");
            Duck.Flock.Detach(Duck);
        }
    }
}
