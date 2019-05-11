using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPartern.Subjects
{
    public class ConcreteSubjectB : Subject
    {
        public string SubjectState { get; set; }
        public ConcreteSubjectB(string subjectState)
        {
            SubjectState = subjectState;
        }
    }
}
