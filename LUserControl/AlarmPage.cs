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
    public partial class AlarmPage : UserControl
    {
        public class AlarmInfo
        {
            public string Timeslap { get; set; }
            public string Sender { get; set; }
            public string Message { get; set; }
            public string Level { get; set; } = "Info";
            public string Code { get; set; } = "0x00";
            public string Note { get; set; } = "None";
        }
        static private AlarmPage _instance;
        static public List<AlarmInfo> AlarmList = new List<AlarmInfo>();
        
        public AlarmPage()
        {
            InitializeComponent();
            var bindinglist = new BindingList<AlarmInfo>(AlarmList);
            var source = new BindingSource(bindinglist, null);
            this.AlarmGridView.DataSource = source;
        }

        static public bool AddAlarm(string timeslap, string sender, string message, string level = "Info", string code = "0x00", string note = "None")
        {
            if (AlarmList == null) return false;
            AlarmList.Add(new AlarmInfo
            {
                Timeslap = timeslap,
                Sender = sender,
                Message = message,
                Level = level,
                Code = code,
                Note = note
            });
            return true;
        }

        public static AlarmPage Instance
        {
            get
            {
                if (_instance == null) _instance = new AlarmPage();
                return _instance;
            }

            set
            {
                _instance = value;
            }
        }

        private void FlowAlarmBtn_Click(object sender, EventArgs e)
        {
            //if (PopupWindow.FrmAlarmPopup.Instance != null) return;
            PopupWindow.FrmAlarmPopup.Instance.Show();
        }
    }
}
