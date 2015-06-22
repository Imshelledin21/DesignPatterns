using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPatternExample.Ducks;

namespace ObserverPatternExample {
    public class Flock : IFlock {
        private readonly List<IDuck> DucksInFlock;
        public DuckStates DuckStates;

        public void ChangeState(DuckStates state) {
            DuckStates = state;
            Notify();
        }

        public Flock() {
            Console.WriteLine("Looks like some ducks are teaming up against the harsh wilderness!" + "\r\n");
            DucksInFlock = new List<IDuck>();
        }

        public void Attach(IDuck duck) {
            DucksInFlock.Add(duck);
            
        }

        public void Detach(IDuck duck) {
            DucksInFlock.Remove(duck);
        }

        public void Notify() {
            for (int i = DucksInFlock.Count - 1; i >= 0; i--) {
                DucksInFlock[i].Update();
            }
        }
    }
}
