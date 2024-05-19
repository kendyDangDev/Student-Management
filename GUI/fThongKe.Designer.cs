namespace GUI
{
    partial class fThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chartThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GradientPanel4 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2HtmlLabelHocPhan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel34 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.guna2GradientPanel3 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2HtmlLabelTyLe = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.guna2GradientPanel5 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2HtmlLabelKhoaHoc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2HtmlLabelGiangVien = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2GradientPanel6 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2HtmlLabelLopHoc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2HtmlLabelSinhVien = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).BeginInit();
            this.guna2GradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.guna2GradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.guna2GradientPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.guna2GradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.guna2GradientPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartThongKe
            // 
            chartArea2.Name = "ChartArea1";
            this.chartThongKe.ChartAreas.Add(chartArea2);
            this.chartThongKe.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend2.Name = "Legend1";
            this.chartThongKe.Legends.Add(legend2);
            this.chartThongKe.Location = new System.Drawing.Point(0, 285);
            this.chartThongKe.Name = "chartThongKe";
            this.chartThongKe.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.chartThongKe.Size = new System.Drawing.Size(1386, 496);
            this.chartThongKe.TabIndex = 0;
            this.chartThongKe.Text = "chart1";
            // 
            // comboBoxSelect
            // 
            this.comboBoxSelect.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelect.FormattingEnabled = true;
            this.comboBoxSelect.Items.AddRange(new object[] {
            "Điểm Sinh Viên",
            "Số Lượng Sinh Viên"});
            this.comboBoxSelect.Location = new System.Drawing.Point(1160, 253);
            this.comboBoxSelect.Name = "comboBoxSelect";
            this.comboBoxSelect.Size = new System.Drawing.Size(214, 35);
            this.comboBoxSelect.TabIndex = 8;
            this.comboBoxSelect.Text = "Điểm Sinh Viên";
            this.comboBoxSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxDiem_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1056, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Thống Kê:";
            // 
            // guna2GradientPanel4
            // 
            this.guna2GradientPanel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel4.BorderRadius = 30;
            this.guna2GradientPanel4.Controls.Add(this.guna2HtmlLabelHocPhan);
            this.guna2GradientPanel4.Controls.Add(this.guna2HtmlLabel34);
            this.guna2GradientPanel4.Controls.Add(this.pictureBox4);
            this.guna2GradientPanel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(234)))), ((int)(((byte)(77)))));
            this.guna2GradientPanel4.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(149)))), ((int)(((byte)(34)))));
            this.guna2GradientPanel4.Location = new System.Drawing.Point(921, 128);
            this.guna2GradientPanel4.Name = "guna2GradientPanel4";
            this.guna2GradientPanel4.Size = new System.Drawing.Size(250, 100);
            this.guna2GradientPanel4.TabIndex = 24;
            // 
            // guna2HtmlLabelHocPhan
            // 
            this.guna2HtmlLabelHocPhan.AutoSize = false;
            this.guna2HtmlLabelHocPhan.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabelHocPhan.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabelHocPhan.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabelHocPhan.Location = new System.Drawing.Point(94, 12);
            this.guna2HtmlLabelHocPhan.Name = "guna2HtmlLabelHocPhan";
            this.guna2HtmlLabelHocPhan.Size = new System.Drawing.Size(156, 40);
            this.guna2HtmlLabelHocPhan.TabIndex = 13;
            this.guna2HtmlLabelHocPhan.Text = "86";
            this.guna2HtmlLabelHocPhan.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel34
            // 
            this.guna2HtmlLabel34.AutoSize = false;
            this.guna2HtmlLabel34.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel34.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel34.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel34.Location = new System.Drawing.Point(94, 58);
            this.guna2HtmlLabel34.Name = "guna2HtmlLabel34";
            this.guna2HtmlLabel34.Size = new System.Drawing.Size(153, 28);
            this.guna2HtmlLabel34.TabIndex = 7;
            this.guna2HtmlLabel34.Text = "Học Phần";
            this.guna2HtmlLabel34.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GUI.Properties.Resources._3426653;
            this.pictureBox4.Location = new System.Drawing.Point(22, 16);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(66, 66);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // guna2GradientPanel3
            // 
            this.guna2GradientPanel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel3.BorderRadius = 30;
            this.guna2GradientPanel3.Controls.Add(this.guna2HtmlLabelTyLe);
            this.guna2GradientPanel3.Controls.Add(this.guna2HtmlLabel5);
            this.guna2GradientPanel3.Controls.Add(this.pictureBox3);
            this.guna2GradientPanel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(223)))), ((int)(((byte)(138)))));
            this.guna2GradientPanel3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(131)))), ((int)(((byte)(129)))));
            this.guna2GradientPanel3.Location = new System.Drawing.Point(921, 12);
            this.guna2GradientPanel3.Name = "guna2GradientPanel3";
            this.guna2GradientPanel3.Size = new System.Drawing.Size(250, 100);
            this.guna2GradientPanel3.TabIndex = 21;
            // 
            // guna2HtmlLabelTyLe
            // 
            this.guna2HtmlLabelTyLe.AutoSize = false;
            this.guna2HtmlLabelTyLe.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabelTyLe.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabelTyLe.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabelTyLe.Location = new System.Drawing.Point(94, 12);
            this.guna2HtmlLabelTyLe.Name = "guna2HtmlLabelTyLe";
            this.guna2HtmlLabelTyLe.Size = new System.Drawing.Size(156, 40);
            this.guna2HtmlLabelTyLe.TabIndex = 13;
            this.guna2HtmlLabelTyLe.Text = "26";
            this.guna2HtmlLabelTyLe.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(94, 50);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(153, 47);
            this.guna2HtmlLabel5.TabIndex = 7;
            this.guna2HtmlLabel5.Text = "Sinh Viên/Giảng Viên";
            this.guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GUI.Properties.Resources.ratio;
            this.pictureBox3.Location = new System.Drawing.Point(22, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(66, 66);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // guna2GradientPanel5
            // 
            this.guna2GradientPanel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel5.BorderRadius = 30;
            this.guna2GradientPanel5.Controls.Add(this.guna2HtmlLabelKhoaHoc);
            this.guna2GradientPanel5.Controls.Add(this.guna2HtmlLabel10);
            this.guna2GradientPanel5.Controls.Add(this.pictureBox5);
            this.guna2GradientPanel5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(78)))), ((int)(((byte)(162)))));
            this.guna2GradientPanel5.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.guna2GradientPanel5.Location = new System.Drawing.Point(591, 128);
            this.guna2GradientPanel5.Name = "guna2GradientPanel5";
            this.guna2GradientPanel5.Size = new System.Drawing.Size(250, 100);
            this.guna2GradientPanel5.TabIndex = 23;
            // 
            // guna2HtmlLabelKhoaHoc
            // 
            this.guna2HtmlLabelKhoaHoc.AutoSize = false;
            this.guna2HtmlLabelKhoaHoc.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabelKhoaHoc.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabelKhoaHoc.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabelKhoaHoc.Location = new System.Drawing.Point(94, 12);
            this.guna2HtmlLabelKhoaHoc.Name = "guna2HtmlLabelKhoaHoc";
            this.guna2HtmlLabelKhoaHoc.Size = new System.Drawing.Size(156, 40);
            this.guna2HtmlLabelKhoaHoc.TabIndex = 13;
            this.guna2HtmlLabelKhoaHoc.Text = "62";
            this.guna2HtmlLabelKhoaHoc.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.AutoSize = false;
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(94, 58);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(153, 28);
            this.guna2HtmlLabel10.TabIndex = 7;
            this.guna2HtmlLabel10.Text = "Khóa Học";
            this.guna2HtmlLabel10.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::GUI.Properties.Resources.online_course;
            this.pictureBox5.Location = new System.Drawing.Point(22, 16);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(66, 66);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel2.BorderRadius = 30;
            this.guna2GradientPanel2.Controls.Add(this.guna2HtmlLabelGiangVien);
            this.guna2GradientPanel2.Controls.Add(this.guna2HtmlLabel3);
            this.guna2GradientPanel2.Controls.Add(this.pictureBox2);
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(241)))), ((int)(((byte)(252)))));
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(112)))), ((int)(((byte)(220)))));
            this.guna2GradientPanel2.Location = new System.Drawing.Point(591, 12);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(250, 100);
            this.guna2GradientPanel2.TabIndex = 20;
            // 
            // guna2HtmlLabelGiangVien
            // 
            this.guna2HtmlLabelGiangVien.AutoSize = false;
            this.guna2HtmlLabelGiangVien.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabelGiangVien.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabelGiangVien.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabelGiangVien.Location = new System.Drawing.Point(94, 12);
            this.guna2HtmlLabelGiangVien.Name = "guna2HtmlLabelGiangVien";
            this.guna2HtmlLabelGiangVien.Size = new System.Drawing.Size(156, 40);
            this.guna2HtmlLabelGiangVien.TabIndex = 13;
            this.guna2HtmlLabelGiangVien.Text = "22";
            this.guna2HtmlLabelGiangVien.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(94, 58);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(153, 28);
            this.guna2HtmlLabel3.TabIndex = 7;
            this.guna2HtmlLabel3.Text = "Giảng Viên";
            this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI.Properties.Resources.lecture1;
            this.pictureBox2.Location = new System.Drawing.Point(22, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // guna2GradientPanel6
            // 
            this.guna2GradientPanel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel6.BorderRadius = 30;
            this.guna2GradientPanel6.Controls.Add(this.guna2HtmlLabelLopHoc);
            this.guna2GradientPanel6.Controls.Add(this.guna2HtmlLabel12);
            this.guna2GradientPanel6.Controls.Add(this.pictureBox6);
            this.guna2GradientPanel6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(142)))), ((int)(((byte)(251)))));
            this.guna2GradientPanel6.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(119)))), ((int)(((byte)(227)))));
            this.guna2GradientPanel6.Location = new System.Drawing.Point(261, 128);
            this.guna2GradientPanel6.Name = "guna2GradientPanel6";
            this.guna2GradientPanel6.Size = new System.Drawing.Size(250, 100);
            this.guna2GradientPanel6.TabIndex = 22;
            // 
            // guna2HtmlLabelLopHoc
            // 
            this.guna2HtmlLabelLopHoc.AutoSize = false;
            this.guna2HtmlLabelLopHoc.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabelLopHoc.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabelLopHoc.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabelLopHoc.Location = new System.Drawing.Point(94, 12);
            this.guna2HtmlLabelLopHoc.Name = "guna2HtmlLabelLopHoc";
            this.guna2HtmlLabelLopHoc.Size = new System.Drawing.Size(153, 40);
            this.guna2HtmlLabelLopHoc.TabIndex = 13;
            this.guna2HtmlLabelLopHoc.Text = "66";
            this.guna2HtmlLabelLopHoc.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.AutoSize = false;
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel12.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel12.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel12.Location = new System.Drawing.Point(94, 58);
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            this.guna2HtmlLabel12.Size = new System.Drawing.Size(153, 28);
            this.guna2HtmlLabel12.TabIndex = 7;
            this.guna2HtmlLabel12.Text = "Lớp Học";
            this.guna2HtmlLabel12.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::GUI.Properties.Resources.classroom;
            this.pictureBox6.Location = new System.Drawing.Point(22, 16);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(66, 66);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.BorderRadius = 30;
            this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabelSinhVien);
            this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2GradientPanel1.Controls.Add(this.pictureBox1);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(230)))), ((int)(((byte)(149)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(178)))), ((int)(((byte)(184)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(261, 12);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(250, 100);
            this.guna2GradientPanel1.TabIndex = 19;
            // 
            // guna2HtmlLabelSinhVien
            // 
            this.guna2HtmlLabelSinhVien.AutoSize = false;
            this.guna2HtmlLabelSinhVien.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabelSinhVien.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabelSinhVien.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabelSinhVien.Location = new System.Drawing.Point(94, 12);
            this.guna2HtmlLabelSinhVien.Name = "guna2HtmlLabelSinhVien";
            this.guna2HtmlLabelSinhVien.Size = new System.Drawing.Size(153, 40);
            this.guna2HtmlLabelSinhVien.TabIndex = 13;
            this.guna2HtmlLabelSinhVien.Text = "88";
            this.guna2HtmlLabelSinhVien.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(94, 58);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(153, 28);
            this.guna2HtmlLabel2.TabIndex = 7;
            this.guna2HtmlLabel2.Text = "Sinh Viên";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.student;
            this.pictureBox1.Location = new System.Drawing.Point(22, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // fThongKe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1386, 781);
            this.Controls.Add(this.guna2GradientPanel4);
            this.Controls.Add(this.guna2GradientPanel3);
            this.Controls.Add(this.guna2GradientPanel5);
            this.Controls.Add(this.guna2GradientPanel2);
            this.Controls.Add(this.guna2GradientPanel6);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSelect);
            this.Controls.Add(this.chartThongKe);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fThongKe";
            this.Text = "fThongKe";
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).EndInit();
            this.guna2GradientPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.guna2GradientPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.guna2GradientPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.guna2GradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.guna2GradientPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKe;
        private System.Windows.Forms.ComboBox comboBoxSelect;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabelHocPhan;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel34;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabelTyLe;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabelKhoaHoc;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabelGiangVien;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabelLopHoc;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        private System.Windows.Forms.PictureBox pictureBox6;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabelSinhVien;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}