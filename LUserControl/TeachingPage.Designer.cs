
namespace Hansol_VisionBondingV2.LUserControl
{
    partial class TeachingPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeachingPage));
            this.ModelTableGoup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ModelDataGridView = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddModelBtn = new System.Windows.Forms.Button();
            this.EditModelBtn = new System.Windows.Forms.Button();
            this.DelModelBtn = new System.Windows.Forms.Button();
            this.ParametersGroup = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ModelTableGoup.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModelDataGridView)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.ParametersGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModelTableGoup
            // 
            this.ModelTableGoup.Controls.Add(this.tableLayoutPanel1);
            this.ModelTableGoup.Location = new System.Drawing.Point(3, 3);
            this.ModelTableGoup.Name = "ModelTableGoup";
            this.ModelTableGoup.Size = new System.Drawing.Size(450, 394);
            this.ModelTableGoup.TabIndex = 0;
            this.ModelTableGoup.TabStop = false;
            this.ModelTableGoup.Text = "Model Table";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.Controls.Add(this.ModelDataGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(444, 375);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ModelDataGridView
            // 
            this.ModelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ModelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModelDataGridView.Location = new System.Drawing.Point(3, 3);
            this.ModelDataGridView.Name = "ModelDataGridView";
            this.ModelDataGridView.Size = new System.Drawing.Size(373, 369);
            this.ModelDataGridView.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.AddModelBtn);
            this.flowLayoutPanel1.Controls.Add(this.EditModelBtn);
            this.flowLayoutPanel1.Controls.Add(this.DelModelBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(382, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(59, 369);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // AddModelBtn
            // 
            this.AddModelBtn.BackColor = System.Drawing.Color.White;
            this.AddModelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddModelBtn.BackgroundImage")));
            this.AddModelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddModelBtn.Location = new System.Drawing.Point(3, 3);
            this.AddModelBtn.Name = "AddModelBtn";
            this.AddModelBtn.Size = new System.Drawing.Size(53, 38);
            this.AddModelBtn.TabIndex = 0;
            this.AddModelBtn.UseVisualStyleBackColor = false;
            // 
            // EditModelBtn
            // 
            this.EditModelBtn.BackColor = System.Drawing.Color.White;
            this.EditModelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditModelBtn.BackgroundImage")));
            this.EditModelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EditModelBtn.Location = new System.Drawing.Point(3, 47);
            this.EditModelBtn.Name = "EditModelBtn";
            this.EditModelBtn.Size = new System.Drawing.Size(53, 38);
            this.EditModelBtn.TabIndex = 1;
            this.EditModelBtn.UseVisualStyleBackColor = false;
            // 
            // DelModelBtn
            // 
            this.DelModelBtn.BackColor = System.Drawing.Color.White;
            this.DelModelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DelModelBtn.BackgroundImage")));
            this.DelModelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DelModelBtn.Location = new System.Drawing.Point(3, 91);
            this.DelModelBtn.Name = "DelModelBtn";
            this.DelModelBtn.Size = new System.Drawing.Size(53, 38);
            this.DelModelBtn.TabIndex = 2;
            this.DelModelBtn.UseVisualStyleBackColor = false;
            // 
            // ParametersGroup
            // 
            this.ParametersGroup.Controls.Add(this.tableLayoutPanel2);
            this.ParametersGroup.Location = new System.Drawing.Point(459, 3);
            this.ParametersGroup.Name = "ParametersGroup";
            this.ParametersGroup.Size = new System.Drawing.Size(498, 391);
            this.ParametersGroup.TabIndex = 1;
            this.ParametersGroup.TabStop = false;
            this.ParametersGroup.Text = "Parameters";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.68882F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.31118F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(492, 372);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // TeachingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ParametersGroup);
            this.Controls.Add(this.ModelTableGoup);
            this.Name = "TeachingPage";
            this.Size = new System.Drawing.Size(960, 980);
            this.ModelTableGoup.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ModelDataGridView)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ParametersGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ModelTableGoup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView ModelDataGridView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        internal System.Windows.Forms.Button AddModelBtn;
        internal System.Windows.Forms.Button EditModelBtn;
        internal System.Windows.Forms.Button DelModelBtn;
        private System.Windows.Forms.GroupBox ParametersGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
