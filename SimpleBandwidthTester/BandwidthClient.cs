using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Net.Sockets;

namespace SimpleBandwidthTester
{
    class BandwidthClient
    {

        private TcpClient client;

        public BandwidthClient()
        {
             this.client = new TcpClient();
        }

        public bool Connect(string host, int port)
        {
            IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse(host), port);

            client.Connect(serverEndPoint);

            return client.Connected;
        }

        public void Close()
        {
            client.Close();
        }

        public void SendPacket(int size)
        {
            NetworkStream clientStream = client.GetStream();

            // generate a random string that is the right size
            string randomString = getRandomString(size);

            // encode string into bytes
            ASCIIEncoding encoder = new ASCIIEncoding();
            byte[] buffer = encoder.GetBytes(randomString);

            // send the packet and record how long it takes
            //DateTime start = DateTime.Now;

                clientStream.Write(buffer, 0, buffer.Length);
                clientStream.Flush();

            //TimeSpan timeTaken = DateTime.Now - start;

            // return the bytes / second value
            //return (int)(size / timeTaken.TotalSeconds);
        }

        private string getRandomString(int size)
        {
            Random random = new Random((int)DateTime.Now.Ticks);

            StringBuilder builder = new StringBuilder();

            char ch;
            
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));                 
                builder.Append(ch);
            }

            return builder.ToString();
        }

    }
}
