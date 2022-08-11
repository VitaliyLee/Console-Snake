using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class ConcreteObservable : IObservable
    {
        private List<IObserver> observers;

        public ConcreteObservable()
        {
            observers = new List<IObserver>();
        }

        public void AddObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            //timer = new Timer();
            //timer.Interval = DefoultTimerInterval;
            //timer.Elapsed += ExecutableMethod;
            //timer.AutoReset = true;
            //timer.Enabled = true;
            foreach (IObserver observer in observers)
                observer.Update();
        }

        public void M()
        {
            NotifyObservers();
        }
    }
}
