namespace GUI
{
    partial class fLopHoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewContent = new Guna.UI2.WinForms.Guna2DataGridView();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.ButtonSearch = new FontAwesome.Sharp.IconButton();
            this.comboBoxColumn = new System.Windows.Forms.ComboBox();
            this.comboBoxValue = new System.Windows.Forms.ComboBox();
            this.groupBoxChuyenNganh = new System.Windows.Forms.GroupBox();
            this.labelMaNganh = new System.Windows.Forms.Label();
            this.textBoxMaLop = new System.Windows.Forms.TextBox();
            this.textBoxTenLop = new System.Windows.Forms.TextBox();
            this.ButtonUpdate = new FontAwesome.Sharp.IconButton();
            this.ButtonAdd = new FontAwesome.Sharp.IconButton();
            this.labelTenLop = new System.Windows.Forms.Label();
            this.comboBoxSpecialty = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonDel = new FontAwesome.Sharp.IconButton();
            this.comboBoxHDT = new System.Windows.Forms.ComboBox();
            this.labelHDT = new System.Windows.Forms.Label();
            this.labelGVCN = new System.Windows.Forms.Label();
            this.comboBoxGVCN = new System.Windows.Forms.ComboBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.labelTotalPages = new System.Windows.Forms.Label();
            this.labelCurrentPage = new System.Windows.Forms.Label();
            this.buttonNext2 = new System.Windows.Forms.Button();
            this.buttonNext1 = new System.Windows.Forms.Button();
            this.buttonUndo1 = new System.Windows.Forms.Button();
            this.buttonUndo2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContent)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            this.groupBoxChuyenNganh.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewContent
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dataGridViewContent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewContent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewContent.ColumnHeadersHeight = 45;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewContent.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewContent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dataGridViewContent.Location = new System.Drawing.Point(428, 0);
            this.dataGridViewContent.MultiSelect = false;
            this.dataGridViewContent.Name = "dataGridViewContent";
            this.dataGridViewContent.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewContent.RowHeadersVisible = false;
            this.dataGridViewContent.RowHeadersWidth = 33;
            this.dataGridViewContent.RowTemplate.Height = 40;
            this.dataGridViewContent.RowTemplate.ReadOnly = true;
            this.dataGridViewContent.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewContent.ShowCellToolTips = false;
            this.dataGridViewContent.ShowEditingIcon = false;
            this.dataGridViewContent.ShowRowErrors = false;
            this.dataGridViewContent.Size = new System.Drawing.Size(958, 781);
            this.dataGridViewContent.TabIndex = 9;
            this.dataGridViewContent.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.dataGridViewContent.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dataGridViewContent.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewContent.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewContent.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewContent.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewContent.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewContent.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dataGridViewContent.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dataGridViewContent.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewContent.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewContent.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewContent.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewContent.ThemeStyle.HeaderStyle.Height = 45;
            this.dataGridViewContent.ThemeStyle.ReadOnly = false;
            this.dataGridViewContent.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dataGridViewContent.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewContent.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewContent.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewContent.ThemeStyle.RowsStyle.Height = 40;
            this.dataGridViewContent.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dataGridViewContent.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewContent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContent_CellClick_1);
            this.dataGridViewContent.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContent_CellMouseEnter);
            this.dataGridViewContent.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContent_CellMouseLeave);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.comboBoxValue);
            this.groupBoxSearch.Controls.Add(this.comboBoxColumn);
            this.groupBoxSearch.Controls.Add(this.ButtonSearch);
            this.groupBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSearch.Location = new System.Drawing.Point(45, 501);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(325, 200);
            this.groupBoxSearch.TabIndex = 2;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Tìm Kiếm";
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.ButtonSearch.IconColor = System.Drawing.Color.Black;
            this.ButtonSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonSearch.IconSize = 45;
            this.ButtonSearch.Location = new System.Drawing.Point(68, 123);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(180, 45);
            this.ButtonSearch.TabIndex = 3;
            this.ButtonSearch.Text = "Tìm Kiếm";
            this.ButtonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // comboBoxColumn
            // 
            this.comboBoxColumn.DropDownHeight = 80;
            this.comboBoxColumn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxColumn.FormattingEnabled = true;
            this.comboBoxColumn.IntegralHeight = false;
            this.comboBoxColumn.Items.AddRange(new object[] {
            "Mã Lớp",
            "Tên Lớp",
            "Chuyên Ngành",
            "GV Chủ Nhiệm",
            "Hệ Đào Tạo"});
            this.comboBoxColumn.Location = new System.Drawing.Point(68, 44);
            this.comboBoxColumn.Name = "comboBoxColumn";
            this.comboBoxColumn.Size = new System.Drawing.Size(180, 29);
            this.comboBoxColumn.TabIndex = 6;
            this.comboBoxColumn.Text = "Chuyên Ngành";
            this.comboBoxColumn.SelectedIndexChanged += new System.EventHandler(this.comboBoxColumn_SelectedIndexChanged);
            // 
            // comboBoxValue
            // 
            this.comboBoxValue.DropDownHeight = 80;
            this.comboBoxValue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxValue.FormattingEnabled = true;
            this.comboBoxValue.IntegralHeight = false;
            this.comboBoxValue.Location = new System.Drawing.Point(68, 82);
            this.comboBoxValue.Name = "comboBoxValue";
            this.comboBoxValue.Size = new System.Drawing.Size(180, 29);
            this.comboBoxValue.TabIndex = 6;
            this.comboBoxValue.Text = "Công Nghệ Web";
            // 
            // groupBoxChuyenNganh
            // 
            this.groupBoxChuyenNganh.Controls.Add(this.comboBoxGVCN);
            this.groupBoxChuyenNganh.Controls.Add(this.labelGVCN);
            this.groupBoxChuyenNganh.Controls.Add(this.labelHDT);
            this.groupBoxChuyenNganh.Controls.Add(this.comboBoxHDT);
            this.groupBoxChuyenNganh.Controls.Add(this.ButtonDel);
            this.groupBoxChuyenNganh.Controls.Add(this.label2);
            this.groupBoxChuyenNganh.Controls.Add(this.comboBoxSpecialty);
            this.groupBoxChuyenNganh.Controls.Add(this.labelTenLop);
            this.groupBoxChuyenNganh.Controls.Add(this.ButtonAdd);
            this.groupBoxChuyenNganh.Controls.Add(this.ButtonUpdate);
            this.groupBoxChuyenNganh.Controls.Add(this.textBoxTenLop);
            this.groupBoxChuyenNganh.Controls.Add(this.textBoxMaLop);
            this.groupBoxChuyenNganh.Controls.Add(this.labelMaNganh);
            this.groupBoxChuyenNganh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxChuyenNganh.Location = new System.Drawing.Point(45, 12);
            this.groupBoxChuyenNganh.Name = "groupBoxChuyenNganh";
            this.groupBoxChuyenNganh.Size = new System.Drawing.Size(325, 465);
            this.groupBoxChuyenNganh.TabIndex = 3;
            this.groupBoxChuyenNganh.TabStop = false;
            this.groupBoxChuyenNganh.Text = "Lớp Hoc";
            // 
            // labelMaNganh
            // 
            this.labelMaNganh.AutoSize = true;
            this.labelMaNganh.Location = new System.Drawing.Point(23, 43);
            this.labelMaNganh.Name = "labelMaNganh";
            this.labelMaNganh.Size = new System.Drawing.Size(62, 19);
            this.labelMaNganh.TabIndex = 2;
            this.labelMaNganh.Text = "Mã Lớp:";
            this.labelMaNganh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxMaLop
            // 
            this.textBoxMaLop.Location = new System.Drawing.Point(129, 36);
            this.textBoxMaLop.Name = "textBoxMaLop";
            this.textBoxMaLop.Size = new System.Drawing.Size(169, 26);
            this.textBoxMaLop.TabIndex = 3;
            // 
            // textBoxTenLop
            // 
            this.textBoxTenLop.Location = new System.Drawing.Point(129, 77);
            this.textBoxTenLop.Name = "textBoxTenLop";
            this.textBoxTenLop.Size = new System.Drawing.Size(169, 26);
            this.textBoxTenLop.TabIndex = 3;
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.BackColor = System.Drawing.Color.White;
            this.ButtonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUpdate.IconChar = FontAwesome.Sharp.IconChar.Squarespace;
            this.ButtonUpdate.IconColor = System.Drawing.Color.Black;
            this.ButtonUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonUpdate.IconSize = 45;
            this.ButtonUpdate.Location = new System.Drawing.Point(86, 326);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(160, 50);
            this.ButtonUpdate.TabIndex = 5;
            this.ButtonUpdate.Text = "Cập Nhật";
            this.ButtonUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonUpdate.UseVisualStyleBackColor = false;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.White;
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.ButtonAdd.IconColor = System.Drawing.Color.Black;
            this.ButtonAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonAdd.IconSize = 45;
            this.ButtonAdd.Location = new System.Drawing.Point(88, 259);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(160, 50);
            this.ButtonAdd.TabIndex = 4;
            this.ButtonAdd.Text = "Mở Lớp";
            this.ButtonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // labelTenLop
            // 
            this.labelTenLop.AutoSize = true;
            this.labelTenLop.Location = new System.Drawing.Point(23, 82);
            this.labelTenLop.Name = "labelTenLop";
            this.labelTenLop.Size = new System.Drawing.Size(64, 19);
            this.labelTenLop.TabIndex = 2;
            this.labelTenLop.Text = "Tên Lớp:";
            this.labelTenLop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxSpecialty
            // 
            this.comboBoxSpecialty.DropDownHeight = 80;
            this.comboBoxSpecialty.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSpecialty.FormattingEnabled = true;
            this.comboBoxSpecialty.IntegralHeight = false;
            this.comboBoxSpecialty.Location = new System.Drawing.Point(129, 159);
            this.comboBoxSpecialty.Name = "comboBoxSpecialty";
            this.comboBoxSpecialty.Size = new System.Drawing.Size(169, 29);
            this.comboBoxSpecialty.TabIndex = 6;
            this.comboBoxSpecialty.Text = "Công Nghệ Web";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chuyên Ngành:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtonDel
            // 
            this.ButtonDel.BackColor = System.Drawing.Color.White;
            this.ButtonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDel.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ButtonDel.IconColor = System.Drawing.Color.Black;
            this.ButtonDel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonDel.IconSize = 45;
            this.ButtonDel.Location = new System.Drawing.Point(86, 393);
            this.ButtonDel.Name = "ButtonDel";
            this.ButtonDel.Size = new System.Drawing.Size(160, 50);
            this.ButtonDel.TabIndex = 6;
            this.ButtonDel.Text = "Đóng Lớp";
            this.ButtonDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonDel.UseVisualStyleBackColor = false;
            this.ButtonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // comboBoxHDT
            // 
            this.comboBoxHDT.DropDownHeight = 80;
            this.comboBoxHDT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxHDT.FormattingEnabled = true;
            this.comboBoxHDT.IntegralHeight = false;
            this.comboBoxHDT.Items.AddRange(new object[] {
            "Chính Quy",
            "Từ Xa"});
            this.comboBoxHDT.Location = new System.Drawing.Point(129, 204);
            this.comboBoxHDT.Name = "comboBoxHDT";
            this.comboBoxHDT.Size = new System.Drawing.Size(169, 29);
            this.comboBoxHDT.TabIndex = 8;
            this.comboBoxHDT.Text = "Chính Quy";
            // 
            // labelHDT
            // 
            this.labelHDT.AutoSize = true;
            this.labelHDT.Location = new System.Drawing.Point(23, 208);
            this.labelHDT.Name = "labelHDT";
            this.labelHDT.Size = new System.Drawing.Size(88, 19);
            this.labelHDT.TabIndex = 7;
            this.labelHDT.Text = "Hệ Đào Tạo:";
            this.labelHDT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGVCN
            // 
            this.labelGVCN.AutoSize = true;
            this.labelGVCN.Location = new System.Drawing.Point(23, 121);
            this.labelGVCN.Name = "labelGVCN";
            this.labelGVCN.Size = new System.Drawing.Size(107, 19);
            this.labelGVCN.TabIndex = 9;
            this.labelGVCN.Text = "GV Chủ Nhiệm:";
            this.labelGVCN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxGVCN
            // 
            this.comboBoxGVCN.DropDownHeight = 80;
            this.comboBoxGVCN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGVCN.FormattingEnabled = true;
            this.comboBoxGVCN.IntegralHeight = false;
            this.comboBoxGVCN.Location = new System.Drawing.Point(129, 117);
            this.comboBoxGVCN.Name = "comboBoxGVCN";
            this.comboBoxGVCN.Size = new System.Drawing.Size(169, 29);
            this.comboBoxGVCN.TabIndex = 10;
            this.comboBoxGVCN.Text = "Đỗ Đặng Thắng";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelHeader.Controls.Add(this.groupBoxChuyenNganh);
            this.panelHeader.Controls.Add(this.groupBoxSearch);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(428, 781);
            this.panelHeader.TabIndex = 7;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelFooter.Controls.Add(this.labelTotalPages);
            this.panelFooter.Controls.Add(this.labelCurrentPage);
            this.panelFooter.Controls.Add(this.buttonNext2);
            this.panelFooter.Controls.Add(this.buttonNext1);
            this.panelFooter.Controls.Add(this.buttonUndo1);
            this.panelFooter.Controls.Add(this.buttonUndo2);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(428, 731);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(958, 50);
            this.panelFooter.TabIndex = 10;
            // 
            // labelTotalPages
            // 
            this.labelTotalPages.AutoSize = true;
            this.labelTotalPages.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPages.Location = new System.Drawing.Point(528, 16);
            this.labelTotalPages.Name = "labelTotalPages";
            this.labelTotalPages.Size = new System.Drawing.Size(19, 21);
            this.labelTotalPages.TabIndex = 2;
            this.labelTotalPages.Text = "1";
            // 
            // labelCurrentPage
            // 
            this.labelCurrentPage.AutoSize = true;
            this.labelCurrentPage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentPage.Location = new System.Drawing.Point(457, 16);
            this.labelCurrentPage.Name = "labelCurrentPage";
            this.labelCurrentPage.Size = new System.Drawing.Size(76, 21);
            this.labelCurrentPage.TabIndex = 1;
            this.labelCurrentPage.Text = "Trang: 1/";
            // 
            // buttonNext2
            // 
            this.buttonNext2.BackColor = System.Drawing.Color.Transparent;
            this.buttonNext2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext2.ForeColor = System.Drawing.Color.White;
            this.buttonNext2.Location = new System.Drawing.Point(655, 7);
            this.buttonNext2.Name = "buttonNext2";
            this.buttonNext2.Size = new System.Drawing.Size(80, 40);
            this.buttonNext2.TabIndex = 0;
            this.buttonNext2.Text = ">>";
            this.buttonNext2.UseVisualStyleBackColor = false;
            // 
            // buttonNext1
            // 
            this.buttonNext1.BackColor = System.Drawing.Color.Transparent;
            this.buttonNext1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext1.ForeColor = System.Drawing.Color.White;
            this.buttonNext1.Location = new System.Drawing.Point(569, 7);
            this.buttonNext1.Name = "buttonNext1";
            this.buttonNext1.Size = new System.Drawing.Size(80, 40);
            this.buttonNext1.TabIndex = 0;
            this.buttonNext1.Text = ">";
            this.buttonNext1.UseVisualStyleBackColor = false;
            // 
            // buttonUndo1
            // 
            this.buttonUndo1.BackColor = System.Drawing.Color.Transparent;
            this.buttonUndo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUndo1.ForeColor = System.Drawing.Color.White;
            this.buttonUndo1.Location = new System.Drawing.Point(355, 7);
            this.buttonUndo1.Name = "buttonUndo1";
            this.buttonUndo1.Size = new System.Drawing.Size(80, 40);
            this.buttonUndo1.TabIndex = 0;
            this.buttonUndo1.Text = "<";
            this.buttonUndo1.UseVisualStyleBackColor = false;
            // 
            // buttonUndo2
            // 
            this.buttonUndo2.BackColor = System.Drawing.Color.Transparent;
            this.buttonUndo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUndo2.ForeColor = System.Drawing.Color.White;
            this.buttonUndo2.Location = new System.Drawing.Point(269, 7);
            this.buttonUndo2.Name = "buttonUndo2";
            this.buttonUndo2.Size = new System.Drawing.Size(80, 40);
            this.buttonUndo2.TabIndex = 0;
            this.buttonUndo2.Text = "<<";
            this.buttonUndo2.UseVisualStyleBackColor = false;
            // 
            // fLopHoc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1386, 781);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.dataGridViewContent);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fLopHoc";
            this.Text = "fLopHoc";
            this.Load += new System.EventHandler(this.fLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContent)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxChuyenNganh.ResumeLayout(false);
            this.groupBoxChuyenNganh.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.UI2.WinForms.Guna2DataGridView dataGridViewContent;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxValue;
        private System.Windows.Forms.ComboBox comboBoxColumn;
        private FontAwesome.Sharp.IconButton ButtonSearch;
        private System.Windows.Forms.GroupBox groupBoxChuyenNganh;
        private System.Windows.Forms.ComboBox comboBoxGVCN;
        private System.Windows.Forms.Label labelGVCN;
        private System.Windows.Forms.Label labelHDT;
        private System.Windows.Forms.ComboBox comboBoxHDT;
        private FontAwesome.Sharp.IconButton ButtonDel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSpecialty;
        private System.Windows.Forms.Label labelTenLop;
        private FontAwesome.Sharp.IconButton ButtonAdd;
        private FontAwesome.Sharp.IconButton ButtonUpdate;
        private System.Windows.Forms.TextBox textBoxTenLop;
        private System.Windows.Forms.TextBox textBoxMaLop;
        private System.Windows.Forms.Label labelMaNganh;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label labelTotalPages;
        private System.Windows.Forms.Label labelCurrentPage;
        private System.Windows.Forms.Button buttonNext2;
        private System.Windows.Forms.Button buttonNext1;
        private System.Windows.Forms.Button buttonUndo1;
        private System.Windows.Forms.Button buttonUndo2;
    }
}