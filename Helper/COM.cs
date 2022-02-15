using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public COM(string ip, int port)
        {

        }

        public async Task Run()
        {
            Task _ = new Task(() =>
            {

            });
            _.Start();
            await _;
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
                return false;
            }
        }
    }
}
