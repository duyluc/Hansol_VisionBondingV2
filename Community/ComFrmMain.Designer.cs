
namespace Community
{
    partial class ComFrmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComFrmMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnTest = new System.Windows.Forms.Button();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbxIp = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.LabelConnectStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.LedTrigger28 = new System.Windows.Forms.Button();
            this.LedTrigger27 = new System.Windows.Forms.Button();
            this.LedTrigger26 = new System.Windows.Forms.Button();
            this.LedTrigger25 = new System.Windows.Forms.Button();
            this.LedTrigger24 = new System.Windows.Forms.Button();
            this.LedTrigger23 = new System.Windows.Forms.Button();
            this.LedTrigger22 = new System.Windows.Forms.Button();
            this.LedTrigger21 = new System.Windows.Forms.Button();
            this.LedTrigger18 = new System.Windows.Forms.Button();
            this.LedTrigger17 = new System.Windows.Forms.Button();
            this.LedTrigger16 = new System.Windows.Forms.Button();
            this.LedTrigger15 = new System.Windows.Forms.Button();
            this.LedTrigger14 = new System.Windows.Forms.Button();
            this.LedTrigger13 = new System.Windows.Forms.Button();
            this.LedTrigger12 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LabelCycletime = new System.Windows.Forms.ToolStripStatusLabel();
            this.LedTrigger11 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 249F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(726, 322);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Controls.Add(this.BtnTest);
            this.panel1.Controls.Add(this.BtnConnect);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TbxPort);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TbxIp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 67);
            this.panel1.TabIndex = 0;
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Red;
            this.BtnExit.Location = new System.Drawing.Point(668, 20);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(42, 27);
            this.BtnExit.TabIndex = 7;
            this.BtnExit.Text = "EXIT";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnTest
            // 
            this.BtnTest.Enabled = false;
            this.BtnTest.Location = new System.Drawing.Point(382, 22);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(58, 27);
            this.BtnTest.TabIndex = 6;
            this.BtnTest.Text = "TEST";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // BtnConnect
            // 
            this.BtnConnect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnConnect.BackgroundImage")));
            this.BtnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnConnect.Location = new System.Drawing.Point(325, 20);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(42, 32);
            this.BtnConnect.TabIndex = 5;
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = ":";
            // 
            // TbxPort
            // 
            this.TbxPort.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxPort.Location = new System.Drawing.Point(253, 20);
            this.TbxPort.Name = "TbxPort";
            this.TbxPort.ReadOnly = true;
            this.TbxPort.Size = new System.Drawing.Size(65, 32);
            this.TbxPort.TabIndex = 3;
            this.TbxPort.Text = "1111";
            this.TbxPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP: ";
            // 
            // TbxIp
            // 
            this.TbxIp.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxIp.Location = new System.Drawing.Point(49, 20);
            this.TbxIp.Name = "TbxIp";
            this.TbxIp.ReadOnly = true;
            this.TbxIp.Size = new System.Drawing.Size(180, 32);
            this.TbxIp.TabIndex = 1;
            this.TbxIp.Text = "127.0.0.1";
            this.TbxIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Controls.Add(this.statusStrip2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.LedTrigger28, 7, 1);
            this.tableLayoutPanel2.Controls.Add(this.LedTrigger27, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.LedTrigger26, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.LedTrigger25, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.LedTrigger24, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.LedTrigger23, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.LedTrigger22, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.LedTrigger21, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.LedTrigger18, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.LedTrigger17, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.LedTrigger16, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.LedTrigger15, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.LedTrigger14, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.LedTrigger13, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.LedTrigger12, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.statusStrip1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.LedTrigger11, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 76);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(720, 243);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // statusStrip2
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.statusStrip2, 2);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelConnectStatus});
            this.statusStrip2.Location = new System.Drawing.Point(0, 221);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(180, 22);
            this.statusStrip2.TabIndex = 29;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // LabelConnectStatus
            // 
            this.LabelConnectStatus.Name = "LabelConnectStatus";
            this.LabelConnectStatus.Size = new System.Drawing.Size(123, 17);
            this.LabelConnectStatus.Text = "STATUS: DISCONNECT";
            // 
            // LedTrigger28
            // 
            this.LedTrigger28.BackColor = System.Drawing.Color.Gray;
            this.LedTrigger28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LedTrigger28.Enabled = false;
            this.LedTrigger28.Location = new System.Drawing.Point(640, 70);
            this.LedTrigger28.Margin = new System.Windows.Forms.Padding(10);
            this.LedTrigger28.Name = "LedTrigger28";
            this.LedTrigger28.Size = new System.Drawing.Size(70, 40);
            this.LedTrigger28.TabIndex = 28;
            this.LedTrigger28.Text = "TRIGGER 2-8";
            this.LedTrigger28.UseVisualStyleBackColor = false;
            // 
            // LedTrigger27
            // 
            this.LedTrigger27.BackColor = System.Drawing.Color.Gray;
            this.LedTrigger27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LedTrigger27.Enabled = false;
            this.LedTrigger27.Location = new System.Drawing.Point(550, 70);
            this.LedTrigger27.Margin = new System.Windows.Forms.Padding(10);
            this.LedTrigger27.Name = "LedTrigger27";
            this.LedTrigger27.Size = new System.Drawing.Size(70, 40);
            this.LedTrigger27.TabIndex = 27;
            this.LedTrigger27.Text = "TRIGGER 2-7";
            this.LedTrigger27.UseVisualStyleBackColor = false;
            // 
            // LedTrigger26
            // 
            this.LedTrigger26.BackColor = System.Drawing.Color.Gray;
            this.LedTrigger26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LedTrigger26.Enabled = false;
            this.LedTrigger26.Location = new System.Drawing.Point(460, 70);
            this.LedTrigger26.Margin = new System.Windows.Forms.Padding(10);
            this.LedTrigger26.Name = "LedTrigger26";
            this.LedTrigger26.Size = new System.Drawing.Size(70, 40);
            this.LedTrigger26.TabIndex = 26;
            this.LedTrigger26.Text = "TRIGGER 2-6";
            this.LedTrigger26.UseVisualStyleBackColor = false;
            // 
            // LedTrigger25
            // 
            this.LedTrigger25.BackColor = System.Drawing.Color.Gray;
            this.LedTrigger25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LedTrigger25.Enabled = false;
            this.LedTrigger25.Location = new System.Drawing.Point(370, 70);
            this.LedTrigger25.Margin = new System.Windows.Forms.Padding(10);
            this.LedTrigger25.Name = "LedTrigger25";
            this.LedTrigger25.Size = new System.Drawing.Size(70, 40);
            this.LedTrigger25.TabIndex = 25;
            this.LedTrigger25.Text = "TRIGGER 2-5";
            this.LedTrigger25.UseVisualStyleBackColor = false;
            // 
            // LedTrigger24
            // 
            this.LedTrigger24.BackColor = System.Drawing.Color.Gray;
            this.LedTrigger24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LedTrigger24.Enabled = false;
            this.LedTrigger24.Location = new System.Drawing.Point(280, 70);
            this.LedTrigger24.Margin = new System.Windows.Forms.Padding(10);
            this.LedTrigger24.Name = "LedTrigger24";
            this.LedTrigger24.Size = new System.Drawing.Size(70, 40);
            this.LedTrigger24.TabIndex = 24;
            this.LedTrigger24.Text = "TRIGGER 2-4";
            this.LedTrigger24.UseVisualStyleBackColor = false;
            // 
            // LedTrigger23
            // 
            this.LedTrigger23.BackColor = System.Drawing.Color.Gray;
            this.LedTrigger23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LedTrigger23.Enabled = false;
            this.LedTrigger23.Location = new System.Drawing.Point(190, 70);
            this.LedTrigger23.Margin = new System.Windows.Forms.Padding(10);
            this.LedTrigger23.Name = "LedTrigger23";
            this.LedTrigger23.Size = new System.Drawing.Size(70, 40);
            this.LedTrigger23.TabIndex = 23;
            this.LedTrigger23.Text = "TRIGGER 2-3";
            this.LedTrigger23.UseVisualStyleBackColor = false;
            // 
            // LedTrigger22
            // 
            this.LedTrigger22.BackColor = System.Drawing.Color.Gray;
            this.LedTrigger22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LedTrigger22.Enabled = false;
            this.LedTrigger22.Location = new System.Drawing.Point(100, 70);
            this.LedTrigger22.Margin = new System.Windows.Forms.Padding(10);
            this.LedTrigger22.Name = "LedTrigger22";
            this.LedTrigger22.Size = new System.Drawing.Size(70, 40);
            this.LedTrigger22.TabIndex = 22;
            this.LedTrigger22.Text = "TRIGGER 2-2";
            this.LedTrigger22.UseVisualStyleBackColor = false;
            // 
            // LedTrigger21
            // 
            this.LedTrigger21.BackColor = System.Drawing.Color.Gray;
            this.LedTrigger21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LedTrigger21.Enabled = false;
            this.LedTrigger21.Location = new System.Drawing.Point(10, 70);
            this.LedTrigger21.Margin = new System.Windows.Forms.Padding(10);
            this.LedTrigger21.Name = "LedTrigger21";
            this.LedTrigger21.Size = new System.Drawing.Size(70, 40);
            this.LedTrigger21.TabIndex = 21;
            this.LedTrigger21.Text = "TRIGGER 2-1";
            this.LedTrigger21.UseVisualStyleBackColor = false;
            // 
            // LedTrigger18
            // 
            this.LedTrigger18.BackColor = System.Drawing.Color.Gray;
            this.LedTrigger18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LedTrigger18.Enabled = false;
            this.LedTrigger18.Location = new System.Drawing.Point(640, 10);
            this.LedTrigger18.Margin = new System.Windows.Forms.Padding(10);
            this.LedTrigger18.Name = "LedTrigger18";
            this.LedTrigger18.Size = new System.Drawing.Size(70, 40);
            this.LedTrigger18.TabIndex = 20;
            this.LedTrigger18.Text = "TRIGGER 1-8";
            this.LedTrigger18.UseVisualStyleBackColor = false;
            // 
            // LedTrigger17
            // 
            this.LedTrigger17.BackColor = System.Drawing.Color.Gray;
            this.LedTrigger17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LedTrigger17.Enabled = false;
            this.LedTrigger17.Location = new System.Drawing.Point(550, 10);
            this.LedTrigger17.Margin = new System.Windows.Forms.Padding(10);
            this.LedTrigger17.Name = "LedTrigger17";
            this.LedTrigger17.Size = new System.Drawing.Size(70, 40);
            this.LedTrigger17.TabIndex = 19;
            this.LedTrigger17.Text = "TRIGGER 1-7";
            this.LedTrigger17.UseVisualStyleBackColor = false;
            // 
            // LedTrigger16
            // 
            this.LedTrigger16.BackColor = System.Drawing.Color.Gray;
            this.LedTrigger16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LedTrigger16.Enabled = false;
            this.LedTrigger16.Location = new System.Drawing.Point(460, 10);
            this.LedTrigger16.Margin = new System.Windows.Forms.Padding(10);
            this.LedTrigger16.Name = "LedTrigger16";
            this.LedTrigger16.Size = new System.Drawing.Size(70, 40);
            this.LedTrigger16.TabIndex = 18;
            this.LedTrigger16.Text = "TRIGGER 1-6";
            this.LedTrigger16.UseVisualStyleBackColor = false;
            // 
            // LedTrigger15
            // 
            this.LedTrigger15.BackColor = System.Drawing.Color.Gray;
            this.LedTrigger15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LedTrigger15.Enabled = false;
            this.LedTrigger15.Location = new System.Drawing.Point(370, 10);
            this.LedTrigger15.Margin = new System.Windows.Forms.Padding(10);
            this.LedTrigger15.Name = "LedTrigger15";
            this.LedTrigger15.Size = new System.Drawing.Size(70, 40);
            this.LedTrigger15.TabIndex = 17;
            this.LedTrigger15.Text = "TRIGGER 1-5";
            this.LedTrigger15.UseVisualStyleBackColor = false;
            // 
            // LedTrigger14
            // 
            this.LedTrigger14.BackColor = System.Drawing.Color.Gray;
            this.LedTrigger14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LedTrigger14.Enabled = false;
            this.LedTrigger14.Location = new System.Drawing.Point(280, 10);
            this.LedTrigger14.Margin = new System.Windows.Forms.Padding(10);
            this.LedTrigger14.Name = "LedTrigger14";
            this.LedTrigger14.Size = new System.Drawing.Size(70, 40);
            this.LedTrigger14.TabIndex = 16;
            this.LedTrigger14.Text = "TRIGGER 1-4";
            this.LedTrigger14.UseVisualStyleBackColor = false;
            // 
            // LedTrigger13
            // 
            this.LedTrigger13.BackColor = System.Drawing.Color.Gray;
            this.LedTrigger13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LedTrigger13.Enabled = false;
            this.LedTrigger13.Location = new System.Drawing.Point(190, 10);
            this.LedTrigger13.Margin = new System.Windows.Forms.Padding(10);
            this.LedTrigger13.Name = "LedTrigger13";
            this.LedTrigger13.Size = new System.Drawing.Size(70, 40);
            this.LedTrigger13.TabIndex = 15;
            this.LedTrigger13.Text = "TRIGGER 1-3";
            this.LedTrigger13.UseVisualStyleBackColor = false;
            // 
            // LedTrigger12
            // 
            this.LedTrigger12.BackColor = System.Drawing.Color.Gray;
            this.LedTrigger12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LedTrigger12.Enabled = false;
            this.LedTrigger12.Location = new System.Drawing.Point(100, 10);
            this.LedTrigger12.Margin = new System.Windows.Forms.Padding(10);
            this.LedTrigger12.Name = "LedTrigger12";
            this.LedTrigger12.Size = new System.Drawing.Size(70, 40);
            this.LedTrigger12.TabIndex = 14;
            this.LedTrigger12.Text = "TRIGGER 1-2";
            this.LedTrigger12.UseVisualStyleBackColor = false;
            // 
            // statusStrip1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.statusStrip1, 2);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelCycletime});
            this.statusStrip1.Location = new System.Drawing.Point(180, 221);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(180, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LabelCycletime
            // 
            this.LabelCycletime.Name = "LabelCycletime";
            this.LabelCycletime.Size = new System.Drawing.Size(96, 17);
            this.LabelCycletime.Text = "Cycle Time: 0 ms";
            // 
            // LedTrigger11
            // 
            this.LedTrigger11.BackColor = System.Drawing.Color.Gray;
            this.LedTrigger11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LedTrigger11.Enabled = false;
            this.LedTrigger11.Location = new System.Drawing.Point(10, 10);
            this.LedTrigger11.Margin = new System.Windows.Forms.Padding(10);
            this.LedTrigger11.Name = "LedTrigger11";
            this.LedTrigger11.Size = new System.Drawing.Size(70, 40);
            this.LedTrigger11.TabIndex = 0;
            this.LedTrigger11.Text = "TRIGGER 1-1";
            this.LedTrigger11.UseVisualStyleBackColor = false;
            // 
            // ComFrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 322);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ComFrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ComFrmMain_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxIp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbxPort;
        public System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button LedTrigger11;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LabelCycletime;
        private System.Windows.Forms.Button LedTrigger28;
        private System.Windows.Forms.Button LedTrigger27;
        private System.Windows.Forms.Button LedTrigger26;
        private System.Windows.Forms.Button LedTrigger25;
        private System.Windows.Forms.Button LedTrigger24;
        private System.Windows.Forms.Button LedTrigger23;
        private System.Windows.Forms.Button LedTrigger22;
        private System.Windows.Forms.Button LedTrigger21;
        private System.Windows.Forms.Button LedTrigger18;
        private System.Windows.Forms.Button LedTrigger17;
        private System.Windows.Forms.Button LedTrigger16;
        private System.Windows.Forms.Button LedTrigger15;
        private System.Windows.Forms.Button LedTrigger14;
        private System.Windows.Forms.Button LedTrigger13;
        private System.Windows.Forms.Button LedTrigger12;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel LabelConnectStatus;
        private System.Windows.Forms.Button BtnTest;
        private System.Windows.Forms.Button BtnExit;
    }
}

