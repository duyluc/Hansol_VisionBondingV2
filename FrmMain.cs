﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hansol_VisionBondingV2.LUserControl;
using Hansol_VisionBondingV2;

namespace Hansol_VisionBondingV2
{
    public partial class FrmMain : Form
    {
        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 0x1;
        const int HTCAPTION = 0x2;
        static private FrmMain _instance;
        public Helper.VisionOperator VisionOperator;

        //event
        public delegate void StartupCompleteDelegate();
        public event StartupCompleteDelegate StartupCompleteEvent;

        public static FrmMain Instance
        {
            get
            {
                return _instance;
            }

            set
            {
                _instance = value;
            }
        }

        public FrmMain()
        {
            Instance = this;
            FrmStartup startuppage = new FrmStartup();
            startuppage.Show();
            InitializeComponent();
        }
        /// <summary>
        /// An thanh tieu de và giu lai tinh nang di chuyen window
        /// </summary>
        /// <param name="message"></param>
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }
        /// <summary>
        /// Su kien window hoan thanh load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);//set vi tri ban dau cua phan mem
            this.MasterPanel.Controls.Add(MainPage.Instance);//hien thi Homepage lam page mac dinh
            FrmMain.ResetColorButton();
            FrmMain.Instance.HomeBtn.BackColor = Color.Green;
            //test alarm
            Helper.ProgramHelper.WriteLog("Master", "Startup Program");
            //Initial Vision Object
            this.VisionOperator = new Helper.VisionOperator();

            //goi event completestartupmainpage
            StartupCompleteEvent();
        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quit?","Warning",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            if (this.MasterPanel.Controls.Contains(MainPage.Instance)) return;
            this.MasterPanel.Controls.Clear();
            this.MasterPanel.Controls.Add(MainPage.Instance);
            MainPage.Instance.Dock = DockStyle.Fill;
            MainPage.Instance.BringToFront();

            FrmMain.ResetColorButton();
            FrmMain.Instance.HomeBtn.BackColor = Color.Green;
        }

        private void AlarmBtn_Click(object sender, EventArgs e)
        {
            if (this.MasterPanel.Controls.Contains(AlarmPage.Instance)) return;
            this.MasterPanel.Controls.Clear();
            try
            {
                this.MasterPanel.Controls.Add(AlarmPage.Instance);
                AlarmPage.Instance.Dock = DockStyle.Fill;
                AlarmPage.Instance.BringToFront();

                FrmMain.ResetColorButton();
                FrmMain.Instance.AlarmBtn.BackColor = Color.Green;
            }
            catch
            {
                AlarmPage.Instance = null;
                this.MasterPanel.Controls.Add(AlarmPage.Instance);
                AlarmPage.Instance.Dock = DockStyle.Fill;
                AlarmPage.Instance.BringToFront();
            }
        }
        #region Utilities Method
        static public void ResetColorButton()
        {
            FrmMain.Instance.HomeBtn.BackColor = Color.White;
            FrmMain.Instance.TeachingBtn.BackColor = Color.White;
            FrmMain.Instance.SettingBtn.BackColor = Color.White;
            FrmMain.Instance.AlarmBtn.BackColor = Color.White;
        }
        #endregion

        private void TeachingBtn_Click(object sender, EventArgs e)
        {

        }

        private void SettingBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.MasterPanel.Controls.Contains(SettingPage.Instance)) return;
                this.MasterPanel.Controls.Clear();
                SettingPage _settingpage = new SettingPage();
                this.MasterPanel.Controls.Add(_settingpage);
                _settingpage.Dock = DockStyle.Fill;
                _settingpage.BringToFront();

                FrmMain.ResetColorButton();
                FrmMain.Instance.SettingBtn.BackColor = Color.Green;
            }
            catch
            {
                SettingPage.Instance = null;
                this.MasterPanel.Controls.Clear();
                this.MasterPanel.Controls.Add(AlarmPage.Instance);
                AlarmPage.Instance.Dock = DockStyle.Fill;
                AlarmPage.Instance.BringToFront();
            }
            
        }
    }
}
