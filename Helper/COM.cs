using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;

namespace Hansol_VisionBondingV2.Helper
{
    public class COM
    {
        public bool IsRunning = false;
        public bool IsConnect = false;

        public event EventHandler Connected;
        public void OnConnected()
        {
            if (this.Connected != null) this.Connected(this, EventArgs.Empty);
        }

        public event EventHandler Disconnected;
        public void OnDisconnected()
        {
            if (this.Disconnected != null) this.Disconnected(this, EventArgs.Empty);
        }

        public string ComBridgePath = ".\\Community\\Community.exe";

        public Socket Udp;

        public IPEndPoint Ep;

        public string Ip;
        public int Port;

        public byte[] RecieveData = new byte[18];
        public byte[] SendData = new byte[5];

        public EndPoint Client;

        public COM(string ip, int port)
        {
            this.Ip = ip;
            this.Port = port;
            this.Ep = new IPEndPoint(IPAddress.Any, this.Port);
            //-->TestMode
            this.SendData = new byte[5] { 0, 0, 0, 0, 1 };
        }

        public async Task Run()
        {
            Task _ = new Task(() =>
            {
                try
                {
                    this.IsRunning = true;
                    this.IsConnect = true;
                    //this.Udp.Connect(this.Ep);
                    this.Udp = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                    this.Udp.Bind(this.Ep);
                    do
                    {
                        this.Client = new IPEndPoint(IPAddress.Any, 0);
                        var length = this.Udp.ReceiveFrom(this.RecieveData,ref this.Client);
                        if(length == 18)
                        {
                            if (this.RecieveData[17] == 0)
                            {
                                break;
                            }
                        }
                        this.Udp.SendTo(this.SendData,this.Client);
                        Array.Clear(this.RecieveData,0, 18);
                    }
                    while (this.IsRunning&&this.IsConnect);
                    this.Udp.Close();
                    this.IsRunning = false;
                }
                catch(Exception t)
                {
                    this.Udp.Close();
                    Helper.ProgramHelper.WriteLog(t,false,true);
                }
            });
            _.Start();
            await _;
            this.IsRunning = false;
        }

        public bool RunBridge()
        {
            try
            {
                System.Diagnostics.Process.Start(this.ComBridgePath);
                return true;
            }
            catch(Exception t)
            {
                System.Windows.Forms.MessageBox.Show(t.Message);
                return false;
            }
        }
        public bool InteruptBridge()
        {
            byte[] data = new byte[] { 0, 0, 0, 0, 0 };
            //byte isrunning = 0;
            Thread _ = new Thread(() =>
            {
                this.IsConnect = false;
                while (this.IsRunning) ;
                this.Udp = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                this.Udp.Bind(this.Ep);
                this.Udp.SendTo(data, this.Client);
                Thread.Sleep(500);
                this.Udp.SendTo(this.SendData, this.Client);
            });
            _.Start();
            _.Join();
            this.Udp.Close();
            return true;
        }
    }
}
