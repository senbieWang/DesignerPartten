using ObserverPartern.Subjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPartern.Observers
{
    public class ConcreteObserverA2 : Observer
    {
        private ConcreteSubjectA ConcreteSubjectA;

        public int ObserverState;
        public ConcreteObserverA2(ConcreteSubjectA concreteSubjectA)
        {
            ConcreteSubjectA = concreteSubjectA;

        }

        public override void Update()
        {
            ObserverState = ConcreteSubjectA.SubjectState;
            Console.WriteLine($"ConcreteObserverA2 state {ObserverState} .");
        }
    }
}
