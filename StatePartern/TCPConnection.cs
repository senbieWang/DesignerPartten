using System;
using System.Collections.Generic;
using System.Text;

namespace StatePartern
{
    class TCPConnection
    {
        //表示TCP连接当前状态
        private TCPState TCPState { get; set; }
        public void ChangeState(TCPState tCPState)
        {
            TCPState = tCPState;
        }

        public TCPConnection()
        {
            TCPState = TCPClosed.Instance();
        }

        public void Acknowledge()
        {
            TCPState.Acknowledge(this);
        }

        public void Synchronize()
        {
            TCPState.Synchronize(this);
        }

        public  void Close()
        {
            TCPState.Close(this);
        }

        //主动打开
        public  void ActiveOpen()
        {
            TCPState.ActiveOpen(this);
        }

        //被动打开
        public void PassiveOpen()
        {
            TCPState.PassiveOpen(this);

        }

        public void Send()
        {
            TCPState.Send(this);
        }

        public void Transmit(TCPOctetStream tCPOctetStream)
        {
            TCPState.Transmit(this, tCPOctetStream);
        }

        public void ProcessOctetStream(TCPOctetStream tCPOctetStream)
        {
            Console.WriteLine("Handle Data.");
        }

    }
}
