using System;
using System.Collections.Generic;
using System.Text;

namespace StatePartern
{
    abstract class TCPState
    {
        protected void ChangeState(TCPConnection tCPConnection, TCPState tCPState)
        {
            tCPConnection.ChangeState(tCPState);
        }

        public virtual void Acknowledge(TCPConnection tCPConnection)
        {
            Console.WriteLine("------------------------------");
        }

        public virtual void Synchronize(TCPConnection tCPConnection)
        {
            Console.WriteLine("------------------------------");
        }

        public virtual void Close(TCPConnection tCPConnection)
        {
            Console.WriteLine("------------------------------");
        }

        //主动打开
        public virtual void ActiveOpen(TCPConnection tCPConnection)
        {
            Console.WriteLine("------------------------------");
        }

        //被动打开
        public virtual void PassiveOpen(TCPConnection tCPConnection)
        {
            Console.WriteLine("------------------------------");
        }

        public virtual void Send(TCPConnection tCPConnection)
        {
            Console.WriteLine("------------------------------");
        }

        public virtual void Transmit(TCPConnection tCPConnection, TCPOctetStream tCPOctetStream)
        {
            Console.WriteLine("------------------------------");
        }
        
    }

    //已建立连接的情况下如何处理三种请求

    class TCPEstablished : TCPState
    {
        private static TCPEstablished tCPEstablished = new TCPEstablished();
        private TCPEstablished() { }
        public static TCPState Instance()
        {
            return tCPEstablished;
        }              

        public override void Close(TCPConnection tCPConnection)
        {
            Console.WriteLine("--------------EstablishedState----------------");
            Console.WriteLine("Close ---send FIN,receive ack of FIN. ");
            ChangeState(tCPConnection, TCPListen.Instance());
            Console.WriteLine("--------------ListeningState----------------");
        }            

        public override void Transmit(TCPConnection tCPConnection, TCPOctetStream tCPOctetStream)
        {         
            tCPConnection.ProcessOctetStream(tCPOctetStream);
        }
     
    }

    class TCPListen : TCPState
    {   
        private static TCPListen tCPListen = new TCPListen();
        private TCPListen() { }
        public static TCPState Instance()
        {
            return tCPListen;
        }          

        public override void Send(TCPConnection tCPConnection)
        {
            Console.WriteLine("--------------ListeningState----------------");
            Console.WriteLine("--------------send Syn ,receive syn ,ack ,etc----------------");
            ChangeState(tCPConnection,TCPEstablished.Instance());
            Console.WriteLine("--------------EstablishedState----------------");
        }
        
    }

    class TCPClosed : TCPState
    {
        private static TCPClosed tCPClosed = new TCPClosed();
        private TCPClosed() { }
        public static TCPState Instance()
        {
            return tCPClosed;
        }   

        public override void ActiveOpen(TCPConnection tCPConnection)
        {
            Console.WriteLine("--------------ClosedState----------------");
            Console.WriteLine("ActiveOpen ---send Syn,receive syn、ack,etc. ");
            ChangeState(tCPConnection,TCPEstablished.Instance());
            Console.WriteLine("--------------EstablishedState----------------");
        }    

        public override void PassiveOpen(TCPConnection tCPConnection)
        {
            Console.WriteLine("--------------ClosedState----------------");
            Console.WriteLine("PassiveOpen  ");
            ChangeState(tCPConnection, TCPListen.Instance());
            Console.WriteLine("--------------ListeningState----------------");
        }

    }

}
