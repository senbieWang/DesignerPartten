using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public abstract class HelpHandler
    {
        protected HelpHandler successor;

        public HelpHandler(HelpHandler helpHandler)
        {
            successor = helpHandler;
        }

        public virtual void HandleHelp(Request request)
        {
            Console.WriteLine("Default Help.");
        }
    }


    

    public class Button : HelpHandler
    {
        public Button(HelpHandler widget) : base(widget) { }

        public override void HandleHelp(Request request)
        {
            if (request.RequestType == HelpType.button)
            {
                Console.WriteLine("Button Help.");
            }
            else if(this.successor != null )
            {
                this.successor.HandleHelp(request);
            }               
        }

    }

    public class Dialog : HelpHandler
    {
        public Dialog(HelpHandler helpHandler) : base(helpHandler) { }

        public override void HandleHelp(Request request)
        {
            if (request.RequestType == HelpType.dialog)
            {
                Console.WriteLine("Dialog Help.");
            }
            else if (this.successor != null)
            {
                this.successor.HandleHelp(request);
            }
        }

    }

    public class Application : HelpHandler
    {
        public Application(HelpHandler helpHandler) : base(helpHandler) { }

        public override void HandleHelp(Request request)
        {
            if (request.RequestType == HelpType.application)
            {
                Console.WriteLine("Application Help.");
            }
            else if (this.successor != null)
            {
                this.successor.HandleHelp(request);
            }
        }
    }

    public class Widge : HelpHandler
    {
        public Widge(HelpHandler helpHandler) : base(helpHandler) { }
      
    }

}
