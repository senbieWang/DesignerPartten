using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public abstract class Mediator
    {
        public abstract void pushMessage(string message, Colleague  enty);

    }

    public class ConcertorMediator : Mediator
    {
        public ColleagueA colleagueA { get; set; }
        public ColleagueB colleagueB { get; set; }

        public override void pushMessage(string message, Colleague enty)
        {
            if (enty == colleagueA)
            {
                colleagueB.GetMessage(message);
            }
            else
            {
                colleagueA.GetMessage(message);
            }
        }
    }
}
