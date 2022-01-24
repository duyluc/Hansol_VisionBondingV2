using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hansol_VisionBondingV2
{
    public partial class FrmStartup : Form
    {
        static private FrmStartup _instance;

        static public FrmStartup Instance
        {
            get
            {
                return _instance;
            }

            set
            {
                _instance = value;
            }
        }

        public FrmStartup()
        {
            FrmMain.Instance.StartupCompleteEvent += CompleteStartupMainpage;
            FrmMain.Instance.Hide();
            InitializeComponent();
            Instance = this;
        }

        private void FrmStartup_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        //static public async Task ShowStartupPage()
        //{
        //    Task _ = new Task(() =>
        //    {
        //        FrmStartup.Instance = new FrmStartup();
        //    })
        //}
        public void CompleteStartupMainpage()
        {
            FrmMain.Instance.Show();
            this.Close();
        }
    }
}
