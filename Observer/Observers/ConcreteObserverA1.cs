using ObserverPartern.Subjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPartern.Observers
{
    public class ConcreteObserverA1 : Observer
    {
        private ConcreteSubjectA ConcreteSubjectA;

        public int ObserverState;
        public ConcreteObserverA1(ConcreteSubjectA concreteSubjectA)
        {
            ConcreteSubjectA = concreteSubjectA;
            
        }

        public override void Update()
        {
            ObserverState = ConcreteSubjectA.SubjectState;
            Console.WriteLine($"ConcreteObserverA1 state {ObserverState} .");
        }
    }
}
