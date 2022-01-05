
namespace Hansol_VisionBondingV2.LUserControl
{
    partial class AlarmPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmPage));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AlarmGridView = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.FlowAlarmBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmGridView)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.AlarmGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(960, 980);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // AlarmGridView
            // 
            this.AlarmGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AlarmGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AlarmGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlarmGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlarmGridView.Location = new System.Drawing.Point(3, 43);
            this.AlarmGridView.Name = "AlarmGridView";
            this.AlarmGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.AlarmGridView.Size = new System.Drawing.Size(954, 934);
            this.AlarmGridView.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.FlowAlarmBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(954, 34);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // FlowAlarmBtn
            // 
            this.FlowAlarmBtn.BackColor = System.Drawing.Color.Transparent;
            this.FlowAlarmBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FlowAlarmBtn.BackgroundImage")));
            this.FlowAlarmBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FlowAlarmBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.FlowAlarmBtn.FlatAppearance.BorderSize = 0;
            this.FlowAlarmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlowAlarmBtn.Location = new System.Drawing.Point(3, 0);
            this.FlowAlarmBtn.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.FlowAlarmBtn.Name = "FlowAlarmBtn";
            this.FlowAlarmBtn.Size = new System.Drawing.Size(35, 34);
            this.FlowAlarmBtn.TabIndex = 0;
            this.FlowAlarmBtn.UseVisualStyleBackColor = false;
            this.FlowAlarmBtn.Click += new System.EventHandler(this.FlowAlarmBtn_Click);
            // 
            // AlarmPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AlarmPage";
            this.Size = new System.Drawing.Size(960, 980);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AlarmGridView)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView AlarmGridView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button FlowAlarmBtn;
    }
}
