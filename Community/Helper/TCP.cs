using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Net.NetworkInformation;
using ActUtlTypeLib;
using System.Diagnostics;
using System.Threading;

namespace Community.Helper
{
    public class TCP
    {
        ///-->TestMode
        public bool TestMode_ResovleErr = false;
        public int CountErr = 0;
        public enum PlcDataIndex
        {
            Trigger11,
            Trigger12,
            Trigger13,
            Trigger14,
            Trigger15,
            Trigger16,
            Trigger17,
            Trigger21,
            Trigger22,
            Trigger23,
            Trigger24,
            Trigger25,
            Trigger26,
            Trigger27,
            Trigger28
        }

        public string[] ReadPlcPotocol = new string[]
        {
            "M100",
            "M101",
            "M102",
            "M103",
            "M104",
            "M105",
            "M106",
            "M107",
            "M108",
            "M109",
            "M110",
            "M111",
            "M112",
            "M113",
            "M114",
            "M115"
        };

        public string[] WritePlcTopocol = new string[]
        {
            "M0",
            "M1",
            "M3",
            "M4",
        };

        public byte[] ReadPlcData = null;
        public byte[] WritePlcData = new byte[4];
        public byte[] ReadPcData = null;
        public byte[] WritePcData = new byte[18];

        private string _ip;
        private int _port;
        private bool _isConnect = false;
        private bool _isRunning = false;
        private UdpClient _udp;
        private ActUtlType _plc;
        private Stopwatch stopwatch = new Stopwatch();
        public double CycleTime = 0;

        public event EventHandler Connected;
        public void OnConnected()
        {
            if (this.Connected != null)
            {
                this.Connected(this, EventArgs.Empty);
            }
        }

        public event EventHandler Disconnected;
        public void OnDisconnected()
        {
            if (this.Disconnected != null)
            {
                this.Disconnected(this, EventArgs.Empty);
            }
        }

        public event EventHandler Exit;
        public void OnExit()
        {
            if (this.Exit != null)
            {
                Exit(this, EventArgs.Empty);
            }
        }

        public event EventHandler EndCycle;
        public void OnEndCycle()
        {
            if(EndCycle != null)
            {
                this.EndCycle(this, EventArgs.Empty);
            }
        }

        public event EventHandler HasErr;
        public void OnHasErr()
        {
            if(HasErr != null)
            {
                this.HasErr(this, EventArgs.Empty);
            }
        }

        static public int PlcStattionNumber = 1;

        public IPEndPoint Ep;

        public TCP(string ip, int port)
        {
            this.Plc = new ActUtlType();
            Plc.ActLogicalStationNumber = PlcStattionNumber;
            this.Ip = ip;
            this.Port = port;
            
        }

        public async Task Run()
        {
            Task _ = new Task(() =>
            {
                try
                {
                    this.Ep = new IPEndPoint(IPAddress.Parse(this.Ip), this.Port);
                    Udp = new UdpClient();
                    this.IsRunning = true;
                    Ping ping = new Ping();
                    PingReply re = ping.Send(this.Ip);
                    if (!re.Status.ToString().Equals("Success")) throw new Exception($"Can't Connect to {this.Ip}");
                    this.IsConnect = true;
                    this.OnConnected();
                    this.Plc.Open();
                    do
                    {
                        if (TestMode_ResovleErr)
                        {
                            this.TestMode_ResovleErr = false;
                            throw new Exception("TESTMODE - RESOVLE ERROR");
                        }
                        this.stopwatch.Start();
                        ///Doc du lieu PLC
                        byte[] TReadPlcData = this.ReadPlc();
                        if (TReadPlcData.Length != 16)
                        {
                            if (this.ReadPlcData == null) this.ReadPlcData = new byte[16] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                        }
                        else
                        {
                            this.ReadPlcData = TReadPlcData;
                        }

                        Array.Copy(this.ReadPlcData, this.WritePcData, this.ReadPlcData.Length);
                        this.WritePcData[16] = 1;
                        this.WritePcData[17] = 1;
                        ///Ghi du lieu len PC
                        this.WritePc();
                        //Doc du lieu tu PC
                        byte[] TReadPc = null;
                        bool flag = false;
                        System.Threading.Thread _pc = new System.Threading.Thread(() =>
                        {
                            flag = this.ReadPc(out TReadPc);
                        });
                        _pc.Start();
                        int i = 0;
                        while (!flag && i < 100)
                        {
                            System.Threading.Thread.Sleep(5);
                            i++;
                        }
                        if (_pc.IsAlive) _pc.Abort();
                        if (!flag)
                        {
                            TReadPc = new byte[] { 0, 0, 0, 0, 1 };
                            this.ReadPcData = TReadPc;
                        }
                        else if (TReadPc.Length != 5)
                        {
                            if (this.ReadPcData == null) this.ReadPcData = new byte[] { 0, 0, 0, 0, 1 };
                        }
                        else
                        {
                            this.ReadPcData = TReadPc;
                        }
                        //Has PC's Exit cmd
                        if (this.ReadPcData[4] == 0)
                        {
                            Thread __ = new Thread(() =>
                            {
                                this.OnExit();
                            });
                            __.Start();
                            break;
                        }
                        Array.Copy(this.ReadPcData, this.WritePlcData, 4);
                        ///Ghi du lieu xuong PLC
                        this.WritePlc();
                        this.CycleTime = stopwatch.Elapsed.TotalMilliseconds;
                        this.stopwatch.Stop();
                        this.stopwatch.Reset();
                        this.OnEndCycle();
                        this.CountErr = 0;
                    }
                    while (IsRunning && IsConnect);
                    this.IsRunning = false;
                }
                catch (Exception t)
                {
                    System.Windows.Forms.MessageBox.Show(t.Message);
                    if (this.CountErr < 3)
                    {
                        this.OnHasErr();
                        this.CountErr++;
                    }
                }
            });
            _.Start();
            await _;
            this.IsConnect = false;
            this.OnDisconnected();
        }

        public byte[] ReadPlc()
        {
            byte[] data = new byte[16];
            for(int i = 0; i < 16; i++)
            {
                int _;
                this.Plc.GetDevice(this.ReadPlcPotocol[i],out _);
                data[i] = Convert.ToByte(_);
            }
            return data;
        }

        public void WritePlc()
        {
            for(int i = 0; i < this.WritePlcData.Length; i++)
            {
                this.Plc.SetDevice(this.WritePlcTopocol[i], this.WritePcData[i]);
            }
        }

        public  bool ReadPc(out byte[] data)
        {
            data = this.Udp.Receive(ref this.Ep);
            return true;
        }

        public void WritePc()
        {
            this.Udp.Send(this.WritePcData, this.WritePcData.Length,this.Ep);
        }

        public string Ip
        {
            get
            {
                return _ip;
            }

            set
            {
                _ip = value;
            }
        }

        public int Port
        {
            get
            {
                return _port;
            }

            set
            {
                _port = value;
            }
        }

        public bool IsConnect
        {
            get
            {
                return _isConnect;
            }

            set
            {
                _isConnect = value;
            }
        }

        public bool IsRunning
        {
            get
            {
                return _isRunning;
            }

            set
            {
                _isRunning = value;
            }
        }

        public UdpClient Udp
        {
            get
            {
                return _udp;
            }

            set
            {
                _udp = value;
            }
        }

        public ActUtlType Plc
        {
            get
            {
                return _plc;
            }

            set
            {
                _plc = value;
            }
        }
    }
}
