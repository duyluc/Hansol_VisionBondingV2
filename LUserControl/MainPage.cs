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
    public partial class MainPage : UserControl
    {
        static private MainPage _instance;
        public MainPage()
        {
            InitializeComponent();
        }

        public static MainPage Instance
        {
            get
            {
                if (_instance == null) _instance = new MainPage();
                return _instance;
            }

            set
            {
                _instance = value;
            }
        }
    }
}
