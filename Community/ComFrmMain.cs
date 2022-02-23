using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Community
{
    public partial class ComFrmMain : Form
    {
        public Helper.TCP Tcp;

        private byte _trigger11;
        private byte _trigger12;
        private byte _trigger13;
        private byte _trigger14;
        private byte _trigger15;
        private byte _trigger16;
        private byte _trigger17;
        private byte _trigger18;
        private byte _trigger21;
        private byte _trigger22;
        private byte _trigger23;
        private byte _trigger24;
        private byte _trigger25;
        private byte _trigger26;
        private byte _trigger27;
        private byte _trigger28;

        public string Ip;
        public int Port = 0;
        public string DatabaseFolder = ".\\Database";

        public byte Trigger11
        {
            get
            {
                return _trigger11;
            }

            set
            {
                if (Trigger11 == value) return;
                _trigger11 = value;
                if(value == 1)
                {
                    this.InvokeMethod(this.LedTrigger11, Color.Green);
                }
                else
                {
                    this.InvokeMethod(this.LedTrigger11, Color.Gray);
                }
            }
        }

        public byte Trigger12
        {
            get
            {
                return _trigger12;
            }

            set
            {
                if (_trigger12 == value) return;
                _trigger12 = value;
                if (value == 1)
                {
                    this.InvokeMethod(this.LedTrigger12, Color.Green);
                }
                else
                {
                    this.InvokeMethod(this.LedTrigger12, Color.Gray);
                }
            }
        }

        public byte Trigger13
        {
            get
            {
                return _trigger13;
            }

            set
            {
                if (_trigger13 == value) return;
                _trigger13 = value;
                if (value == 1)
                {
                    this.InvokeMethod(this.LedTrigger13, Color.Green);
                }
                else
                {
                    this.InvokeMethod(this.LedTrigger13, Color.Gray);
                }
            }
        }

        public byte Trigger14
        {
            get
            {
                return _trigger14;
            }

            set
            {
                if (_trigger14 == value) return;
                _trigger14 = value;
                if (value == 1)
                {
                    this.InvokeMethod(this.LedTrigger14, Color.Green);
                }
                else
                {
                    this.InvokeMethod(this.LedTrigger14, Color.Gray);
                }
            }
        }

        public byte Trigger15
        {
            get
            {
                return _trigger15;
            }

            set
            {
                if (_trigger15 == value) return;
                _trigger15 = value;
                if (value == 1)
                {
                    this.InvokeMethod(this.LedTrigger15, Color.Green);
                }
                else
                {
                    this.InvokeMethod(this.LedTrigger15, Color.Gray);
                }
            }
        }

        public byte Trigger16
        {
            get
            {
                return _trigger16;
            }

            set
            {
                if (_trigger16 == value) return;
                _trigger16 = value;
                if (value == 1)
                {
                    this.InvokeMethod(this.LedTrigger16, Color.Green);
                }
                else
                {
                    this.InvokeMethod(this.LedTrigger16, Color.Gray);
                }
            }
        }

        public byte Trigger17
        {
            get
            {
                return _trigger17;
            }

            set
            {
                if (_trigger17 == value) return;
                _trigger17 = value;
                if (value == 1)
                {
                    this.InvokeMethod(this.LedTrigger17, Color.Green);
                }
                else
                {
                    this.InvokeMethod(this.LedTrigger17, Color.Gray);
                }
            }
        }

        public byte Trigger18
        {
            get
            {
                return _trigger18;
            }

            set
            {
                if (_trigger18 == value) return;
                _trigger18 = value;
                if (value == 1)
                {
                    this.InvokeMethod(this.LedTrigger18, Color.Green);
                }
                else
                {
                    this.InvokeMethod(this.LedTrigger18, Color.Gray);
                }
            }
        }

        public byte Trigger21
        {
            get
            {
                return _trigger21;
            }

            set
            {
                if (Trigger21 == value) return;
                _trigger21 = value;
                if (value == 1)
                {
                    this.InvokeMethod(this.LedTrigger21, Color.Green);
                }
                else
                {
                    this.InvokeMethod(this.LedTrigger21, Color.Gray);
                }
            }
        }

        public byte Trigger22
        {
            get
            {
                return _trigger22;
            }

            set
            {
                if (_trigger22 == value) return;
                _trigger22 = value;
                if (value == 1)
                {
                    this.InvokeMethod(this.LedTrigger22, Color.Green);
                }
                else
                {
                    this.InvokeMethod(this.LedTrigger22, Color.Gray);
                }
            }
        }

        public byte Trigger23
        {
            get
            {
                return _trigger23;
            }

            set
            {
                if (_trigger23 == value) return;
                _trigger23 = value;
                if (value == 1)
                {
                    this.InvokeMethod(this.LedTrigger23, Color.Green);
                }
                else
                {
                    this.InvokeMethod(this.LedTrigger23, Color.Gray);
                }
            }
        }

        public byte Trigger24
        {
            get
            {
                return _trigger24;
            }

            set
            {
                if (_trigger24 == value) return;
                _trigger24 = value;
                if (value == 1)
                {
                    this.InvokeMethod(this.LedTrigger24, Color.Green);
                }
                else
                {
                    this.InvokeMethod(this.LedTrigger24, Color.Gray);
                }
            }
        }

        public byte Trigger25
        {
            get
            {
                return _trigger25;
            }

            set
            {
                if (_trigger25 == value) return;
                _trigger25 = value;
                if (value == 1)
                {
                    this.InvokeMethod(this.LedTrigger25, Color.Green);
                }
                else
                {
                    this.InvokeMethod(this.LedTrigger25, Color.Gray);
                }
            }
        }

        public byte Trigger26
        {
            get
            {
                return _trigger26;
            }

            set
            {
                if (_trigger26 == value) return;
                _trigger26 = value;
                if (value == 1)
                {
                    this.InvokeMethod(this.LedTrigger26, Color.Green);
                }
                else
                {
                    this.InvokeMethod(this.LedTrigger26, Color.Gray);
                }
            }
        }

        public byte Trigger27
        {
            get
            {
                return _trigger27;
            }

            set
            {
                if (_trigger27 == value) return;
                _trigger27 = value;
                if (value == 1)
                {
                    this.InvokeMethod(this.LedTrigger27, Color.Green);
                }
                else
                {
                    this.InvokeMethod(this.LedTrigger27, Color.Gray);
                }
            }
        }

        public byte Trigger28
        {
            get
            {
                return _trigger28;
            }

            set
            {
                if (_trigger28 == value) return;
                _trigger28 = value;
                if (value == 1)
                {
                    this.InvokeMethod(this.LedTrigger28, Color.Green);
                }
                else
                {
                    this.InvokeMethod(this.LedTrigger28, Color.Gray);
                }
            }
        }

        public void InvokeMethod(Button subject, Color color)
        {
            subject.Invoke(new Action(() =>
            {
                subject.BackColor = color;
            }));
        }


        public ComFrmMain()
        {
            InitializeComponent();
            ToolTip MyTooltip = new ToolTip();
            MyTooltip.InitialDelay = 300;
            MyTooltip.ShowAlways = true;

            if (!Directory.Exists(this.DatabaseFolder)) Directory.CreateDirectory(this.DatabaseFolder);

            MyTooltip.SetToolTip(this.BtnConnect, "Connect");
            this.Ip = this.TbxIp.Text;
            this.Port = Convert.ToInt32(this.TbxPort.Text);
            this.Tcp = new Helper.TCP(this.Ip, this.Port);
            this.Tcp.Connected += Tcp_Connected;
            this.Tcp.Disconnected += Tcp_Disconnected;
            this.Tcp.Exit += Tcp_Exit;
            this.Tcp.EndCycle += Tcp_EndCycle;
            this.Tcp.HasErr += Tcp_HasErr;
            Task _ = this.Tcp.Run();
        }

        private void Tcp_HasErr(object sender, EventArgs e)
        {
            Task _ = Tcp_HasErr_Support();
            
        }

        private async Task Tcp_HasErr_Support()
        {
            Task _ = new Task(() =>
            {
                while (this.Tcp.IsRunning) ;
                Task __ = this.Tcp.Run();
            });
            _.Start();
            await _;
        }

        private void Tcp_EndCycle(object sender, EventArgs e)
        {
            this.Trigger11 = this.Tcp.ReadPlcData[0];
            this.Trigger12 = this.Tcp.ReadPlcData[1];
            this.Trigger13 = this.Tcp.ReadPlcData[2];
            this.Trigger14 = this.Tcp.ReadPlcData[3];
            this.Trigger15 = this.Tcp.ReadPlcData[4];
            this.Trigger16 = this.Tcp.ReadPlcData[5];
            this.Trigger17 = this.Tcp.ReadPlcData[6];
            this.Trigger18 = this.Tcp.ReadPlcData[7];
            this.Trigger21 = this.Tcp.ReadPlcData[8];
            this.Trigger22 = this.Tcp.ReadPlcData[9];
            this.Trigger23 = this.Tcp.ReadPlcData[10];
            this.Trigger24 = this.Tcp.ReadPlcData[11];
            this.Trigger25 = this.Tcp.ReadPlcData[12];
            this.Trigger26 = this.Tcp.ReadPlcData[13];
            this.Trigger27 = this.Tcp.ReadPlcData[14];
            this.Trigger28 = this.Tcp.ReadPlcData[15];
            this.LabelCycletime.Text = $"Cycle Time: {Convert.ToInt32(this.Tcp.CycleTime).ToString()} ms";
        }

        private void Tcp_Disconnected(object sender, EventArgs e)
        {
            this.LabelConnectStatus.Text = "STATUS: DISCONNECT";
        }

        private void Tcp_Exit(object sender, EventArgs e)
        {
            Thread _ = new Thread(() =>
            {
                while (this.Tcp.IsRunning) ;
            });
            _.Start();
            _.Join();
            this.Close();
        }

        private void Tcp_Connected(object sender, EventArgs e)
        {
            this.LabelConnectStatus.Text = "STATUS: CONNECT";
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            this.Tcp.CountErr = 0;
            this.Ip = this.TbxIp.Text;
            this.Port = Convert.ToInt32(this.TbxPort.Text);
            this.Tcp.IsConnect = false;
            System.Threading.Thread _t = new System.Threading.Thread(() =>
            {
                while (this.Tcp.IsRunning);
                this.Tcp.Ip = this.Ip;
                this.Tcp.Port = this.Port;
            });
            _t.Start();
            _t.Join();
            Task _ = this.Tcp.Run();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            this.Tcp.TestMode_ResovleErr = true;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit?", "Warning", MessageBoxButtons.OKCancel) != DialogResult.OK) return;
            this.Tcp.IsConnect = false;
            System.Threading.Thread _ = new System.Threading.Thread(() =>
            {
                while (this.Tcp.IsRunning) ;
            });
            _.Start();
            _.Join();
            this.Close();
        }

        private void ComFrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Tcp.Udp.Send(new byte[18] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,0 },18,this.Tcp.Ep);
        }
    }
}
