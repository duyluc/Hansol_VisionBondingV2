using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Community
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool instanceone = false;
            using(Mutex mtex = new Mutex(true,"Communication",out instanceone))
            {
                if (instanceone)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new ComFrmMain());
                }
                else
                {

                }
            }
            
        }
    }
}
