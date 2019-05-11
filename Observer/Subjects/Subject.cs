using ObserverPartern.Observers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPartern.Subjects
{
    public abstract class Subject
    {
        private List<Observer> observers = new List<Observer>();
        public void attach(Observer observer)
        {
            observers.Add(observer);
        }
        public void deltach(Observer observer)
        {
            observers.Remove(observer);
        }
        public void notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
    }
}
