using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Widge widge = new Widge(null);
            Application application = new Application(widge);
            Dialog dialog = new Dialog(application);
            Button button = new Button(dialog);

            Request request = new Request();
            request.RequestType = HelpType.button;
            request.MessageBody = "Test";

            button.HandleHelp(request);

            request.RequestType = HelpType.application;
            application.HandleHelp(request);

            request.RequestType = HelpType.dialog;
            dialog.HandleHelp(request);

        }
    }
}
