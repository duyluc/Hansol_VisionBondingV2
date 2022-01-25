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
    public partial class TeachingPage : UserControl
    {
        static private TeachingPage _instance;

        public TeachingPage()
        {
            InitializeComponent();
        }

        public static TeachingPage Instance
        {
            get
            {
                if (_instance == null) _instance = new TeachingPage();
                return _instance;
            }

            set
            {
                _instance = value;
            }
        }
    }
}
