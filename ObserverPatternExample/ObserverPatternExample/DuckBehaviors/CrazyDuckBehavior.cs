using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternExample.DuckBehaviors {
    public class CrazyDuckBehavior : IBehavior {
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
                    Console.WriteLine("The Crazy Duck is in a state of limbo. Neither here nor there. Neither coming or going. But this is it's normal state...");
                    break;
            }
        }

        private void TakeOff() {
            Console.WriteLine("The Crazy Duck starts to flap its wings wildly, quacking up a storm! Is this normal?" + "\r\n");
        }

        private void Flying() {
            Console.WriteLine("The Crazy Duck, somehow managing to stay airborne, is doing loops and spirals!" + "\r\n");
        }

        private void OnGround() {
            Console.WriteLine("The Crazy Duck, is doing rollies on the ground! Embarrassing!" + "\r\n");
        }

        private void OnWater() {
            Console.WriteLine("The Crazy Duck, is splashing about wildly. Nobody can relax with this guy around!" + "\r\n");
        }

        private void Landing() {
            Console.WriteLine("The Crazy Duck dives down, and face plants! Though it seems to have no change for the mental state of this idiot duck." + "\r\n");
        }
    }
}
