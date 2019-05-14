using System;

namespace StatePartern
{
    class Program
    {
        static void Main(string[] args)
        {
            TCPConnection tCPConnection = new TCPConnection();
            tCPConnection.ActiveOpen();
            tCPConnection.Close();
            tCPConnection.Send();
            tCPConnection.Transmit(new TCPOctetStream() );
            tCPConnection.Close();

        }
    }
}
