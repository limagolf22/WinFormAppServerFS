using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using SuperSocket.WebSocket;

using Microsoft.FlightSimulator.SimConnect;
using System.Runtime.InteropServices;


namespace WinFormsAppServerFS
{
    public partial class Form1 : Form
    {
        private static WebSocketServer WS;
        private static List<WebSocketSession> client_list;
        private static int list_nbr;

        private static int nport=9002;
        private static int freqWS = 500;
        
        private static System.Timers.Timer WStimer;

        private static string RPOS_STR="",RREF_STR="";

        public SimConnect simconnect = null; 

        public Form1()
        {
            InitializeComponent();

            trackBarfrequency.Value = 2;
            client_list = new List<WebSocketSession>();
            list_nbr = 0;

            initSimEvents();

            SetTimer();

            trackBarfrequency.ValueChanged += new System.EventHandler(OnTrackValueChanged);

            System.Diagnostics.Debug.WriteLine("App is working");

        }

        protected override void DefWndProc(ref Message m)
        {
            if (m.Msg == 0x402)
            {
                if (simconnect != null)
                {
                    simconnect.ReceiveMessage();
                }
            }
            else
            {
                base.DefWndProc(ref m);
            }
        }


        private static void SetTimer()
        {
            // Create a timer with a two freqWS interval.
            WStimer = new System.Timers.Timer(freqWS);
            // Hook up the Elapsed event for the timer. 
            WStimer.Elapsed += OnTimedEvent;
            WStimer.AutoReset = true;
            WStimer.Enabled = true;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            foreach (WebSocketSession client in client_list)
            {
                client.Send(RPOS_STR);
                client.Send(RREF_STR);
            }
        }

        private void WS_SessionClosed(WebSocketSession session, SuperSocket.SocketBase.CloseReason value)
        {
            client_list.Remove(session);
            list_nbr--;
            ConnectionWSLabel.Invoke(new Action(() =>
            {
                ConnectionWSLabel.Text = "( " + list_nbr + " connected)";
            }));
        }

        private void WS_NewDataReceived(WebSocketSession session, byte[] value)
        {
            System.Diagnostics.Debug.WriteLine("data received");

        }

        private void WS_NewMessageReceived(WebSocketSession session, string value)
        {
            System.Diagnostics.Debug.WriteLine("message received");
            simconnect_parser(value);
        }

        private void WS_NewSessionConnected(WebSocketSession session)
        {
            client_list.Add(session);
            list_nbr++;
            ConnectionWSLabel.Invoke(new Action(() =>
            {
                ConnectionWSLabel.Text = "( " + list_nbr + " connected)";
            }));
            
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            WStimer.Stop();
            
            System.Diagnostics.Debug.WriteLine("WS (re)connection");
            WStimer.Interval = 1 / (float)(trackBarfrequency.Value) * 1000;
            nport = int.Parse(nportBox.Text);
            client_list.Clear();
            list_nbr = 0;
            ConnectionWSLabel.Text = "( " + 0 + " connected)";
            WS = new WebSocketServer();
            WS.Setup(nport);
            WS.NewSessionConnected += WS_NewSessionConnected;
            WS.NewMessageReceived += WS_NewMessageReceived;
            WS.NewDataReceived += WS_NewDataReceived;
            WS.SessionClosed += WS_SessionClosed;
            WS.Start();

            WStimer.Start();
        }

        private void OnTrackValueChanged(object sender, System.EventArgs e)
        {
            TrackValueLabel.Text = trackBarfrequency.Value.ToString();
        }

        private void sendT_Click(object sender, EventArgs e)
        {

        }
    }
}
