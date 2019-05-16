using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class Request
    {
        public HelpType RequestType { get; set; }

        public string MessageBody { get; set; }
    }

    public enum HelpType
    {
        button,
        dialog,
        application
    } 

}
