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
        static private FrmMain _instance;
        public Helper.VisionOperator VisionOperator;

        //event
        public delegate void StartupCompleteDelegate();
        public event StartupCompleteDelegate StartupCompleteEvent;

        public delegate void LogoutDelegate();
        public event LogoutDelegate LogoutEvent;

        //su kien startuptimeout
        public delegate void StartuptimeoutDelegate();
        public event StartuptimeoutDelegate Startuptimeout;
        /// <summary>
        /// flag trang thai khoi dong chuong trinh
        /// </summary>
        private bool _startupcomplete = false;

        private Timer cycletimer;
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
            //timer kich hoat timeout khoi dong chuong trinh
            this.Startuptimeout += StartupTimeoutEvent;
            Task _ = this._StartupWatchDog();
            FrmStartup startuppage = new FrmStartup();
            startuppage.Show();
            InitializeComponent();
        }
        /// <summary>
        /// Su kien window hoan thanh load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //Timer kich hoat dinh ki
            this.cycletimer = new Timer();
            this.cycletimer.Interval = 100;
            this.cycletimer.Tick += new EventHandler(CycleTimerTickEvent);
            this.cycletimer.Start();

            //Khoi tao form dang nhap
            Login.Instance.SuccessfulEvent += this.LoginSuccessfulEvent;
            this.TeachingBtn.Enabled = false;
            this.AlarmBtn.Enabled = false;
            this.SettingBtn.Enabled = false;

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
            this._startupcomplete = true;
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
            this.Loginbtn.Enabled = true;
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
            this.Loginbtn.Enabled = false;
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
            try
            {
                if (this.MasterPanel.Controls.Contains(TeachingPage.Instance)) return;
                this.Loginbtn.Enabled = false;
                this.MasterPanel.Controls.Clear();
                this.MasterPanel.Controls.Add(TeachingPage.Instance);
                TeachingPage.Instance.Dock = DockStyle.Fill;
                TeachingPage.Instance.BringToFront();

                FrmMain.ResetColorButton();
                this.TeachingBtn.BackColor = Color.Green;
            }
            catch
            {
                AlarmPage.Instance = null;
                this.MasterPanel.Controls.Add(AlarmPage.Instance);
                AlarmPage.Instance.Dock = DockStyle.Fill;
                AlarmPage.Instance.BringToFront();
            }
        }

        private void SettingBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.MasterPanel.Controls.Contains(SettingPage.Instance)) return;
                this.Loginbtn.Enabled = false;
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
        /// <summary>
        /// Refresh dong ho va goi GC.Collection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CycleTimerTickEvent(object sender, EventArgs e)
        {
            this.cycletimer.Stop();
            GC.Collect();
            this.WatcherLabel.Text = DateTime.Now.ToString("HH:mm:ss   dd/MM/yyyy");
            this.cycletimer.Start();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (!Login.Instance.Logined)
            {
                this.LevelAccessLabel.Text = "Operator";
                Login.Instance.Show();
            }
            else
            {
                this.LogoutEvent();
                this.LevelAccessLabel.Text = "Operator";
                this.TeachingBtn.Enabled = false;
                this.AlarmBtn.Enabled = false;
                this.SettingBtn.Enabled = false;
            }
        }

        private void LoginSuccessfulEvent()
        {
            this.LevelAccessLabel.Text = "Master";
            this.TeachingBtn.Enabled = true;
            this.AlarmBtn.Enabled = true;
            this.SettingBtn.Enabled = true;
        }
        /// <summary>
        /// Method khi co su kien timeout startup
        /// </summary>
        public void StartupTimeoutEvent()
        {
            //StartupCompleteEvent();
            this.Close();
        }

        public async Task _StartupWatchDog()
        {
            await Task.Delay(10000);
            if (!this._startupcomplete)
            {
                this.Startuptimeout();
            }
        }
    }
}
