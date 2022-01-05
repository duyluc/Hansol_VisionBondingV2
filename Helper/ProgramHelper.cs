using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hansol_VisionBondingV2.Helper
{
    public class ProgramHelper
    {
        static public bool WriteLog(Exception t, bool alarm = true, bool popup = false)
        {
            try
            {
                if (alarm)
                {
                    if (LUserControl.AlarmPage.AddAlarm(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"), t.Source.ToString(), t.Message)) return true;
                    else return false;
                }
                if (popup)
                {
                    System.Windows.Forms.MessageBox.Show($"{t.Source.ToString()}: {t.Message}");
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        static public bool WriteLog(Exception t,string level,string code,string note, bool alarm = true, bool popup = false)
        {
            try
            {
                if (alarm)
                {
                    if (LUserControl.AlarmPage.AddAlarm(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"), t.Source.ToString(), t.Message,level,code,note)) return true;
                    else return false;
                }
                if (popup)
                {
                    System.Windows.Forms.MessageBox.Show($"{t.Source.ToString()}: {t.Message}");
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        static public bool WriteLog(string sender, string message, string level = "Info", string code = "0x00", string note = "None", bool alarm = true, bool popup = false)
        {
            try
            {
                if (alarm)
                {
                    if (LUserControl.AlarmPage.AddAlarm(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"), sender,message,level,code,note)) return true;
                    else return false;
                }
                if (popup)
                {
                    System.Windows.Forms.MessageBox.Show($"{sender}: {message}");
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
