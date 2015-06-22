using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPatternExample.DuckBehaviors;
using ObserverPatternExample.Ducks;

namespace ObserverPatternExample {
    class Program {
        static void Main(string[] args) {
            Console.ReadKey();
            BehaviorFactory duckBehaviorFactory = new BehaviorFactory();
            Flock flock = new Flock();

            Duck mallard = new Mallard(flock, duckBehaviorFactory);
            Duck sicklyDuck = new SicklyDuck(flock, duckBehaviorFactory);
            Duck rubberDuck = new RubberDuck(flock, duckBehaviorFactory);

            flock.Attach(mallard);
            flock.Attach(sicklyDuck);
            flock.Attach(rubberDuck);

            DuckStory(flock, rubberDuck, sicklyDuck, duckBehaviorFactory);

            Console.WriteLine("\r\n" + "Thanks for learning!" + "\r\n");
            Console.ReadLine();
        }

        private static void DuckStory(Flock flock, IDuck rubberDuck, IDuck sicklyDuck, BehaviorFactory duckBehaviorFactory) {
            Console.WriteLine("The flock notices a potential threat! Time to fly away!" + "\r\n");

            flock.ChangeState(DuckStates.TakingOff);

            Console.WriteLine("\r\n" + "-----------------------------------------------------------------------" + "\r\n");

            Console.WriteLine("We're in the air now! Hold on to your butts!" + "\r\n");

            flock.ChangeState(DuckStates.Flying);

            Console.WriteLine("\r\n" + "-----------------------------------------------------------------------" + "\r\n");

            Console.WriteLine("With the danger far off, it's time to give the wings a break, and find a snack!" + "\r\n");

            flock.ChangeState(DuckStates.Landing);

            Console.WriteLine("\r\n" + "-----------------------------------------------------------------------" + "\r\n");

            Console.WriteLine("Now on the other side of the lake, the water seems like the safest place to be right now." + "\r\n");

            flock.ChangeState(DuckStates.OnWater);

            Console.WriteLine("\r\n" + "-----------------------------------------------------------------------" + "\r\n");

            Console.WriteLine("The rubber duck, having been picked up by the tide, floats back to the flock." + "\r\n");
            flock.Attach(rubberDuck);
            flock.ChangeState(DuckStates.OnWater);

            Console.WriteLine("\r\n" + "-----------------------------------------------------------------------" + "\r\n");

            Console.WriteLine("Suddenly, a large splash hits the water!" + "\r\n");
            Duck crazyDuck = new CrazyDuck(flock, duckBehaviorFactory);
            flock.Attach(crazyDuck);

            Console.WriteLine("\r\n" + "-----------------------------------------------------------------------" + "\r\n");

            Console.WriteLine("The flock wants nothing to do with this duck, and makes way for land." + "\r\n");
            flock.ChangeState(DuckStates.OnGround);

            Console.WriteLine("\r\n" + "-----------------------------------------------------------------------" + "\r\n");

            Console.WriteLine("Unable to get away from this Crazy Duck, the flock takes flight." + "\r\n");
            flock.ChangeState(DuckStates.TakingOff);

            Console.WriteLine("\r\n" + "-----------------------------------------------------------------------" + "\r\n");

            Console.WriteLine("The Crazy Duck is still following, but there is another duck flying in to join! It's the sickly Duck!" + "\r\n");
            flock.Attach(sicklyDuck);
            flock.ChangeState(DuckStates.Flying);

            Console.WriteLine("\r\n" + "-----------------------------------------------------------------------" + "\r\n");
        }
    }
}
