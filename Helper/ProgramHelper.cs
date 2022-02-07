using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

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
                    FrmMain.Instance.BlindAlarm = true;
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
                    FrmMain.Instance.BlindAlarm = true;
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
        static public bool WriteLog(string sender, string message, bool alarm = true, bool popup = false, string level = "Info", string code = "0x00", string note = "None")
        {
            try
            {
                if (alarm)
                {
                    if (!LUserControl.AlarmPage.AddAlarm(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"), sender,message,level,code,note)) return false;
                    FrmMain.Instance.BlindAlarm = true;
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
        static public bool CheckSysFolder(bool create = false)
        {
            bool returnvalue = true;
            if (!Directory.Exists(Database.DatabaseFolderPath))
            {
                returnvalue = false;
                if (create)
                {
                    Directory.CreateDirectory(Database.DatabaseFolderPath);
                }
            }

            return returnvalue;
        }
        static public bool UpdateDataGridView(System.Windows.Forms.DataGridView table)
        {
            try
            {
                table.Refresh();
                return true;
            }
            catch (Exception t)
            {
                WriteLog(t);
                return false;
            }
        }
        //--> OverWrite List<> Function
        static public void List_AddRange<T>(List<T> Master, List<T> Object)
        {
            Master.AddRange(Object);
        }
        static public void List_AddRange<T>(List<T> Master, T[] Object)
        {
            Master.AddRange(Object);
        }

        static public void List_Clear<T>(List<T> Master)
        {
            Master.Clear();
        }
        static public bool FillParam()
        {
            try
            {
                if (FrmMain.Instance.CurrentModel == null) ThrowEx("Selected Model is Null");
                LUserControl.TeachingPage.Instance.ModelNameTbx.Text = FrmMain.Instance.CurrentModel.ModelName;
                LUserControl.TeachingPage.Instance.WidthNN.Value = FrmMain.Instance.CurrentModel.camparams.ImageWidth;
                LUserControl.TeachingPage.Instance.HeightNN.Value = FrmMain.Instance.CurrentModel.camparams.ImageHeight;
                LUserControl.TeachingPage.Instance.ExposureNN.Value = FrmMain.Instance.CurrentModel.camparams.Exposure;
                LUserControl.TeachingPage.Instance.LazerPowerNN.Value = FrmMain.Instance.CurrentModel.camparams.LazerPower;
                return true;
            }
            catch(Exception t)
            {
                WriteLog(t);
                return false;
            }

        }
    }
}
