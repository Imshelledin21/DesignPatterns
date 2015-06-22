using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPatternExample.Ducks;

namespace ObserverPatternExample.DuckBehaviors {
    public class RubberDuckBehavior : IBehavior {
        private Duck Duck;

        public RubberDuckBehavior(Duck duck) {
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
                    Console.WriteLine("The Rubber Duck is a rubber duck. It doesn't know of it's own existence.");
                    break;
            }
        }

        private void TakeOff() {
            Console.WriteLine("The Rubber Duck is a rubber duck. It doesn't know of it's own existence, nor can it move. The flock starts to move away." + "\r\n");
        }

        private void Flying() {
            Console.WriteLine("The Rubber Duck is a rubber duck. It doesn't know of it's own existence, nor can it fly. It just sits in it's spot, alone." + "\r\n");
            Duck.Flock.Detach(Duck);
            Console.WriteLine("With the flock far in the distance, the Rubber duck is no longer part of the flock. :(" + "\r\n");
        }

        private void OnGround() {
            Console.WriteLine("The Rubber Duck is a rubber duck. It doesn't know of it's own existence. It just sits in it's spot, alone." + "\r\n");
        }

        private void OnWater() {
            Console.WriteLine("The Rubber Duck is a rubber duck. It doesn't know of it's own existence. It just floats on." + "\r\n");
        }

        private void Landing() {
            Console.WriteLine("The Rubber Duck is a rubber duck. It doesn't know of it's own existence. As it never made it into the air, it just sits there, alone." + "\r\n");
        }
    }
}
