using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bubblegum_sequencer
{
    public abstract class IObserverable
    {
        List<IObserver> observers;

        public IObserverable()
        {
            observers = new List<IObserver>();
        }

        public void add(IObserver beobachter)
        {
            observers.Add(beobachter);
            beobachter.update(this);
        }

        public void delete(IObserver beobachter)
        {
            observers.Remove(beobachter);
        }

        protected void notify()
        {
            foreach (IObserver o in observers)
            {
                o.update(this);
            }
        }
    }
}
