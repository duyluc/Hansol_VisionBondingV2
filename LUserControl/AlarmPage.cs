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
            public string Timeslap;
            public string Sender;
            public string Message;
            public string Level;
            public string Code = "0x00";
            public string Note = "None";
        }
        static private AlarmPage _instance;
        //static private List<>

        public AlarmPage()
        {
            InitializeComponent();
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
    }
}
