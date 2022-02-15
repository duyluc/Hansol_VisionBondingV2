using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hansol_VisionBondingV2.LUserControl
{
    public partial class SettingPage : UserControl
    {
        static private UserControl _instance;
        
        public SettingPage()
        {
            Instance = this;
            InitializeComponent();
            //Helper.ProgramHelper.WriteLog("Master", "Opened Setting Page");
            if(FrmMain.Instance.VisionOperator.Cam3D != null)
            {
                this.AcFifoSetting.Subject = FrmMain.Instance.VisionOperator.Cam3D;
            }
        }

        public static UserControl Instance
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

        private void BtnConnect_Click(object sender, EventArgs e)
        {

        }
    }
}
