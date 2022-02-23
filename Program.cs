using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hansol_VisionBondingV2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool IsOneInstance = false;
            using(Mutex mutex = new Mutex(true, "VisionBonding",out IsOneInstance))
            {
                if (IsOneInstance)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new FrmMain());
                }
                else
                {
                    MessageBox.Show("Application is Running");
                }
            }
        }
    }
}
