using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPartern.Subjects
{
    public class ConcreteSubjectA : Subject
    {
        public int SubjectState { get; set; }
        public ConcreteSubjectA(int subjectState)
        {
            SubjectState = subjectState;
        }

    }
}
