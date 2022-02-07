using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hansol_VisionBondingV2.Helper;

namespace Hansol_VisionBondingV2.LUserControl
{
    public partial class TeachingPage : UserControl
    {
        static private TeachingPage _instance;

        public TeachingPage()
        {
            InitializeComponent();
            FrmMain.Instance.ModelListChanged += this.ModelListChanged_Event;
            this.ModelDataGridView.DataSource = FrmMain.Instance.ModelList;
            this.ModelDataGridView.Refresh();
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

        private void AddModelBtn_Click(object sender, EventArgs e)
        {
            if (!this.CheckInputModel()) return;
            Helper.Database.CamParams camparams = new Helper.Database.CamParams
            {
                CameraName = "Unknow",
                CameraSerial = "Unknow",
                Camtype = Helper.Database.CamParams.CameraType.LineScan,
                Exposure = Convert.ToInt32(this.ExposureNN.Value),
                OriginX = 0,
                OriginY = 0,
                ImageWidth = Convert.ToInt32(this.WidthNN.Value),
                ImageHeight = Convert.ToInt32(this.HeightNN.Value),
                LazerPower = Convert.ToInt32(this.LazerPowerNN.Value),
                Brightness = 0
            };
            Helper.Database.Model model = new Helper.Database.Model
            {
                ModelName = this.ModelNameTbx.Text,
                camparams = camparams
            };
            Database.AddModel(model);
        }
        /// <summary>
        /// kiem tra thong so dau vao model
        /// </summary>
        /// <returns></returns>
        private bool CheckInputModel()
        {
            if (string.IsNullOrEmpty(this.ModelNameTbx.Text))
            {
                MessageBox.Show("Model Name is invalid!");
                return false;
            }
            if (this.WidthNN.Value > this.HeightNN.Value)
            {
                MessageBox.Show("Image Width and Height are invalid!");
                return false;
            }
            return true;
        }

        public void ModelListChanged_Event()
        {
            this.ModelDataGridView.DataSource = null;
            this.ModelDataGridView.DataSource = FrmMain.Instance.ModelList;
            TeachingPage.Instance.ModelDataGridView.Refresh();
        }

        private void ModelDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0) return;
            try
            {
                FrmMain.Instance.CurrentModel = FrmMain.Instance.ModelList[index];
                if (!ProgramHelper.FillParam()) ProgramHelper.ThrowEx("Load Model Fail!");
                MessageBox.Show("Load Model is Successfully!");
            }
            catch (Exception t)
            {
                FrmMain.Instance.CurrentModel = null;
                ProgramHelper.WriteLog(t, true, true);
            }
            
        }

        private void EditModelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(!CheckInputModel()) ProgramHelper.ThrowEx("Can not Edit Model!");
                if (FrmMain.Instance.CurrentModel == null) ProgramHelper.ThrowEx("Selected Model is Null");
                Helper.Database.CamParams camparams = new Helper.Database.CamParams
                {
                    CameraName = "Unknow",
                    CameraSerial = "Unknow",
                    Camtype = Helper.Database.CamParams.CameraType.LineScan,
                    Exposure = Convert.ToInt32(this.ExposureNN.Value),
                    OriginX = 0,
                    OriginY = 0,
                    ImageWidth = Convert.ToInt32(this.WidthNN.Value),
                    ImageHeight = Convert.ToInt32(this.HeightNN.Value),
                    LazerPower = Convert.ToInt32(this.LazerPowerNN.Value),
                    Brightness = 0
                };
                Helper.Database.Model model = new Helper.Database.Model
                {
                    ModelName = this.ModelNameTbx.Text,
                    camparams = camparams
                };
                if (!Database.EditModel(model)) ProgramHelper.ThrowEx("Can not Edit Model!");
                MessageBox.Show("Edit Model Successfully!");
            }
            catch(Exception t)
            {
                ProgramHelper.WriteLog(t,true,true);
            }
        }

        private void DelModelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (FrmMain.Instance.CurrentModel == null) ProgramHelper.ThrowEx("Selected Model is Null");
                if (!Database.DelModel(FrmMain.Instance.CurrentModel)) ProgramHelper.ThrowEx("Can not Delete Model!");
                MessageBox.Show("Delete Model Successfully!");
            }
            catch (Exception t)
            {
                ProgramHelper.WriteLog(t, true, true);
            }
        }
    }
}
