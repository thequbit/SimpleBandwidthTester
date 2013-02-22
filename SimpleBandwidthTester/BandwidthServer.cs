using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Net.Sockets;

using System.Threading;

namespace SimpleBandwidthTester
{
    class BandwidthServer
    {
        public EventHandler PrintEvent;

        private TcpListener tcpListener;
        private Thread listenThread;

        private bool running = true;

        public BandwidthServer()
        {

        }

        public void Start(int port )
        {
            print("Starting Server ...");

            this.running = true;

            this.tcpListener = new TcpListener(IPAddress.Any, port);
            this.listenThread = new Thread(new ThreadStart(ListenForClients));
            this.listenThread.Start();

            print("Server Started Successfully.");
        }

        public void Stop()
        {
            print("Stopping Server ...");

            this.running = false;
            
            this.tcpListener.Stop();
            
            this.listenThread.Abort();

            while (listenThread.IsAlive) ;

            print("Server Stopped Successfully.");
        
        }

        private void ListenForClients()
        {
            this.tcpListener.Start();

            //while (running == true)
            //{
                //blocks until a client has connected to the server
                //TcpClient client = this.tcpListener.AcceptTcpClient();

                // starts the async call back for a client connecting.
                tcpListener.BeginAcceptTcpClient(new AsyncCallback(DoAcceptClientCallBack), tcpListener);
            //}
        }

        private void DoAcceptClientCallBack(IAsyncResult asyncResult)
        {
            //try
            //{
                // Get the listener that handles the client request.
                TcpListener listener = (TcpListener)asyncResult.AsyncState;

                TcpClient client = listener.EndAcceptTcpClient(asyncResult);

                //create a thread to handle communication 
                //with connected client
                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));
                clientThread.Start(client);
            //}
            //catch
            //{
                // meh ...
            //}
        }

        private void HandleClientComm(object client)
        {
            print("Accepting Client Connection ...");

            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();

            int packetSize = ((int)Math.Pow(2,20) * 10); // 10 megabytes

            byte[] message = new byte[packetSize];
            int bytesRead;

            while (true)
            {
                bytesRead = 0;

                try
                {
                    //print("Waiting for Client to send Data Packet ...");

                    //blocks until a client sends a message
                    bytesRead = clientStream.Read(message, 0, packetSize);

                    //print("Data Packet Recieved Successfully.");
                }
                catch
                {
                    print("A Socket Error Occured.");

                    //a socket error has occured, exit
                    break;
                }

                if (bytesRead == 0)
                {
                    print("The Client has Disconnected From the Server.");

                    //the client has disconnected from the server, exit
                    break;
                }

                //message has successfully been received
                ASCIIEncoding encoder = new ASCIIEncoding();
                string responceText = encoder.GetString(message, 0, bytesRead);

                //
                //if( running )
                //    print("Packet Recieved, Length = " + Convert.ToString(responceText.Length));

            }

            // close the socket
            print("Closing Client Connection.");
            tcpClient.Close();

            // start listening again
            tcpListener.BeginAcceptTcpClient(new AsyncCallback(DoAcceptClientCallBack), tcpListener);
        }

        private void print(string text)
        {
            if (this.PrintEvent != null)
                PrintEvent.Invoke(this, new PrintEventArgs(text));
        }
    }
}
