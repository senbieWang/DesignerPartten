using ObserverPartern.Observers;
using ObserverPartern.Subjects;
using System;

namespace ObserverPartern
{
    class Program
    {
        static void Main(string[] args)
        {
            //第一组
            ConcreteSubjectA subjectA = new ConcreteSubjectA(1);
            ConcreteObserverA1 observerA1 = new ConcreteObserverA1(subjectA);
            ConcreteObserverA2 observerA2 = new ConcreteObserverA2(subjectA);

            subjectA.attach(observerA1);
            subjectA.attach(observerA2);

            subjectA.notify();

            subjectA.SubjectState = 5;
            subjectA.notify();

            //第二组
            ConcreteSubjectB subjectB = new ConcreteSubjectB("观察对象二");
            ConcreteObserverB1 observerB1 = new ConcreteObserverB1(subjectB);
            ConcreteObserverB2 observerB2 = new ConcreteObserverB2(subjectB);

            subjectB.attach(observerB1);
            subjectB.attach(observerB2);
            subjectB.notify();

            subjectB.SubjectState = "状态变了";
            subjectB.notify();
           
        }
    }
}
