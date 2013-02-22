using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;

namespace SimpleBandwidthTester
{
    public partial class FormMain : Form
    {

        private BandwidthServer bandwidthServer;

        private BandwidthClient bandwidthClient;

        public FormMain()
        {
            InitializeComponent();

            bandwidthServer = new BandwidthServer();

            bandwidthClient = new BandwidthClient();

            bandwidthServer.PrintEvent = new EventHandler(serverPrintEvent);

            buttonStopServer.Enabled = false;
            buttonStartServer.Enabled = true;
        }

        private void buttonStartServer_Click(object sender, EventArgs e)
        {

            buttonStopServer.Enabled = true;
            buttonStartServer.Enabled = false;

            radioButtonClientMode.Enabled = false;

            // TODO: sanity check this input

            int port = Convert.ToInt32(textBoxServerServerPort.Text);

            bandwidthServer.Start(port);
        }

        private void serverPrintEvent(object sender, EventArgs e)
        {
            this.print(((PrintEventArgs)e).ResponceString);
        }

        private void print(string text)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(print), new object[] { text });
                return;
            }

            this.textBoxOutput.AppendText("[ " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + " ] " + text + "\n");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            print("Application Loaded.");

            this.radioButtonServerMode.Checked = false;
            this.radioButtonClientMode.Checked = false;

            this.groupBoxClientControls.Enabled = false;
            this.groupBoxServerControls.Enabled = false;

        }

        private void radioButtonServerMode_CheckedChanged(object sender, EventArgs e)
        {
            updateModeChange(OperationMode.Server);
        }

        private void radioButtonClientMode_CheckedChanged(object sender, EventArgs e)
        {
            updateModeChange(OperationMode.Client);
        }

        private void updateModeChange(OperationMode opMode)
        {
            switch (opMode)
            {
                case OperationMode.Client:
                    
                    this.radioButtonServerMode.Checked = false;
                    //this.radioButtonClientMode.Checked = true;

                    this.groupBoxClientControls.Enabled = true;
                    this.groupBoxServerControls.Enabled = false;

                    break;

                case OperationMode.Server:
                    
                    //this.radioButtonServerMode.Checked = true;
                    this.radioButtonClientMode.Checked = false;

                    this.groupBoxClientControls.Enabled = false;
                    this.groupBoxServerControls.Enabled = true;

                    break;

                case OperationMode.Error:
                case OperationMode.None:
                default:

                    // uh, wat?

                    break;
            }
        }

        private void buttonStopServer_Click(object sender, EventArgs e)
        {
            buttonStopServer.Enabled = false;
            buttonStartServer.Enabled = true;
            radioButtonClientMode.Enabled = true;

            if (bandwidthServer != null)
            {
                bandwidthServer.Stop();
            }
        }

        private List<int> runTests(List<int> packetSizes)
        {
            DateTime start;
            TimeSpan timeTaken;

            List<int> bytesPerSecond = new List<int>();

            int bytesPerSec = -1;

            foreach (int packetSize in packetSizes)
            {
                print("Sending (128) " + Convert.ToString((int)(packetSize/1024)) + " KByte Packets ...");

                start = DateTime.Now;
                for (int i = 0; i < 128; i++)
                {
                    bandwidthClient.SendPacket(packetSize);
                }
                timeTaken = DateTime.Now - start;

                print("Done.");

                bytesPerSec = (int)((128 * packetSize) / timeTaken.TotalSeconds);

                print("Stats: ");
                print("\tBandwidth = " + Convert.ToString(bytesPerSec) + " Bytes/Second");

                bytesPerSecond.Add(bytesPerSec);
            }

            return bytesPerSecond;
        }

        private void buttonStartText_Click(object sender, EventArgs e)
        {

            radioButtonServerMode.Enabled = false;

            string host = textBoxClientServerAddress.Text;
            int port = Convert.ToInt32(textBoxClientServerPort.Text);

            print("Connecting to Server ...");

            bool success = bandwidthClient.Connect(host, port);

            if( success == false )
            {
                print("Unable to connect to server, check connection settings and media.");
            }
            else
            {

                List<int> bytesPerSecond = new List<int>();

                List<int> packetSizes = new List<int>();

                packetSizes.Add(1024);
                packetSizes.Add(1024*5);
                packetSizes.Add(1024*32);
                packetSizes.Add(1024*128);

                bytesPerSecond = runTests(packetSizes);

                print("=============================================");
                print("Tests Complete.");
                print("Final Bandwidths:");
                print("\tMax = " + Convert.ToString(bytesPerSecond.Max() / 1024) + " KBytes/Second (" + Convert.ToString(Math.Round((double)bytesPerSecond.Max() / (1024.0 * 1024.0),2)) + " MBytes / Second)");
                print("\tMin = " + Convert.ToString(bytesPerSecond.Min() / 1024) + " KBytes/Second (" + Convert.ToString(Math.Round((double)bytesPerSecond.Min() / (1024.0 * 1024.0),2)) + " MBytes / Second");
                print("\tAverage = " + Convert.ToString((int)(bytesPerSecond.Average() / 1024)) + " KBytes/Second (" + Convert.ToString(Math.Round(bytesPerSecond.Average() / (1024.0 * 1024.0),2)) + " MBytes / Second");

            }

            bandwidthClient.Close();

            radioButtonServerMode.Enabled = true;
        }

    }
}
