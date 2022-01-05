using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hansol_VisionBondingV2.PopupWindow
{
    public partial class FrmAlarmPopup : Form
    {
        static private FrmAlarmPopup _instance;

        public FrmAlarmPopup()
        {
            InitializeComponent();
        }

        public static FrmAlarmPopup Instance
        {
            get
            {
                if (_instance == null) _instance = new FrmAlarmPopup();
                return _instance;
            }

            set
            {
                _instance = value;
            }
        }

        private void FrmAlarmPopup_Load(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Add(LUserControl.AlarmPage.Instance);
        }

        private void FrmAlarmPopup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Quit Alarm Popup?","Warning",MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                FrmAlarmPopup._instance = null;
                if(FrmMain.Instance.MasterPanel.Controls.Count == 0)
                {
                    FrmMain.Instance.MasterPanel.Controls.Add(LUserControl.AlarmPage.Instance);
                }
            }
        }
    }
}
