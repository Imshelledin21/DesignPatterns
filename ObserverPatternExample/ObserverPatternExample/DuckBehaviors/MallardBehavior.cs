using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternExample.DuckBehaviors {
    public class MallardBehavior : IBehavior {
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
                    Console.WriteLine("The Mallard is in a state of limbo. Neither here nor there. Neither coming or going. What are you doing, Mallard?");
                    break;
            }
        }

        private void TakeOff() {
            Console.WriteLine("The Mallard starts to flap its wing, gaining momentum!" + "\r\n");
        }

        private void Flying() {
            Console.WriteLine("The Mallard, as a majestic being, is flying gracefully through the air!" + "\r\n");
        }

        private void OnGround() {
            Console.WriteLine("The Mallard, waddles about on the ground, obviously in search of a nice breadcrumb to snack on." + "\r\n");
        }

        private void OnWater() {
            Console.WriteLine("The Mallard, gracefully swims on top of the water, occasionally dipping his head down into the water to grab a small fish or bug to eat." + "\r\n");
        }

        private void Landing() {
            Console.WriteLine("The Mallard, with his destination found, slows down his flight and drops altitude to make his landing!" + "\r\n");
        }
    }
}
