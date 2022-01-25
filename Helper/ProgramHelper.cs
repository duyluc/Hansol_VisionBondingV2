using System;

namespace Hansol_VisionBondingV2.Helper
{
    public class ProgramHelper
    {
        /// <summary>
        /// nem ra mot ngoai le moi
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        static public void ThrowEx(string t)
        {
            throw new Exception(t);
        }
        /// <summary>
        /// tao ra mot ngoai le
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        static public Exception CreateEx(string t)
        {
            return new Exception(t);
        }

        static public bool WriteLog(Exception t, bool alarm = true, bool popup = false)
        {
            try
            {
                if (alarm)
                {
                    if (!LUserControl.AlarmPage.AddAlarm(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"), t.Source.ToString(), t.Message)) return false;
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
                    if (LUserControl.AlarmPage.AddAlarm(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"), t.Source.ToString(), t.Message,level,code,note)) return false;
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
                    if (!LUserControl.AlarmPage.AddAlarm(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"), sender,message,level,code,note)) return false;
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
