using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cognex.VisionPro;
using Cognex.VisionPro.Display;

namespace Hansol_VisionBondingV2.LUserControl
{
    public partial class MainPage : UserControl
    {
        public enum DisplayPosision
        {
            UpperRight,
            RightRight,
            BottomRight,
            LeftRight,
            UpperLeft,
            RightLeft,
            BottomLeft,
            LeftLeft
        }
        public List<CogDisplay> DisplayList = new List<CogDisplay>();
        public List<CogDisplay> BufferDisplayList = new List<CogDisplay>();
        static private MainPage _instance;
        public MainPage()
        {
            InitializeComponent();
            DisplayList.AddRange(new CogDisplay[]
            {
                this.UpperRightDisplay,
                this.RightRightDisplay,
                this.BottomRightDisplay,
                this.LeftRightDisplay,
                this.UpperLeftDisplay,
                this.RightLeftDisplay,
                this.BottomLeftDisplay,
                this.LeftLeftDisplay
            });
            BufferDisplayList.AddRange(new CogDisplay[]
            {
                this.UpperRightBufferDisplay,
                this.RightRightBufferDisplay,
                this.BottomRightBufferDisplay,
                this.LeftRightBufferDisplay,
                this.UpperLeftBufferDisplay,
                this.RightLeftBufferDisplay,
                this.BottomLeftBufferDisplay,
                this.LeftLeftBufferDisplay
            });
            
            for(int i = 0; i < 8; i++)
            {
                this.DisplayList[i].BackColor = Color.Green;
                this.DisplayList[i].AutoFit = true;
                this.BufferDisplayList[i].BackColor = Color.Green;
                this.BufferDisplayList[i].AutoFit = true;

            }
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
