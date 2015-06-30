using System;
using ObserverPatternExample.Ducks;

namespace ObserverPatternExample.DuckBehaviors
{
    public class GrapeDuckBehavior : IBehavior
    {
        private Duck _duck;

        public GrapeDuckBehavior(Duck duck)
        {
            _duck = duck;
        }

        public void Act(DuckStates state)
        {
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

        private void TakeOff()
        {
            Console.WriteLine("Grape Duck waddles around while the ducks take off.\n");
        }

        private void OnWater()
        {
            Console.WriteLine("Grape Duck waddles on the water, looking for Grapes.\n");
        }

        private void OnGround()
        {
            Console.WriteLine("Grape Duck waddles faster than the other ducks.\n");

        }

        private void Landing()
        {
            Console.WriteLine("Grape Duck catches up with his fast waddling.\n");
        }

        private void Flying()
        {
            Console.WriteLine("Grape Duck doesn't know how to fly, so he waddles away.\n");
            _duck.Flock.Detach(_duck);
            Console.WriteLine("Grape Duck is no longer around.\n");
        }
    }
}