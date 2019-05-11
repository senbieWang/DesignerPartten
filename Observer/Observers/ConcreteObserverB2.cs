using ObserverPartern.Subjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPartern.Observers
{
    public class ConcreteObserverB2 : Observer
    {
        private ConcreteSubjectB ConcreteSubjectB;

        public string ObserverState;
        public ConcreteObserverB2(ConcreteSubjectB concreteSubjectB)
        {
            ConcreteSubjectB = concreteSubjectB;

        }

        public override void Update()
        {
            ObserverState = ConcreteSubjectB.SubjectState;
            Console.WriteLine($"ConcreteObserverB2 state {ObserverState} .");
        }
    }
}
