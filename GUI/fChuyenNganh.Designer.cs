namespace GUI
{
    partial class fChuyenNganh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.labelTotalPages = new System.Windows.Forms.Label();
            this.labelCurrentPage = new System.Windows.Forms.Label();
            this.buttonNext2 = new System.Windows.Forms.Button();
            this.buttonNext1 = new System.Windows.Forms.Button();
            this.buttonUndo1 = new System.Windows.Forms.Button();
            this.buttonUndo2 = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.groupBoxChuyenNganh = new System.Windows.Forms.GroupBox();
            this.labelTGDT = new System.Windows.Forms.Label();
            this.textBoxTGDT = new System.Windows.Forms.TextBox();
            this.ButtonDel = new FontAwesome.Sharp.IconButton();
            this.labelNganh = new System.Windows.Forms.Label();
            this.comboBoxNganh = new System.Windows.Forms.ComboBox();
            this.labelTenCN = new System.Windows.Forms.Label();
            this.ButtonAdd = new FontAwesome.Sharp.IconButton();
            this.ButtonUpdate = new FontAwesome.Sharp.IconButton();
            this.textBoxTenCN = new System.Windows.Forms.TextBox();
            this.textBoxMaCN = new System.Windows.Forms.TextBox();
            this.labelMaCN = new System.Windows.Forms.Label();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.comboBoxValue = new System.Windows.Forms.ComboBox();
            this.comboBoxColumn = new System.Windows.Forms.ComboBox();
            this.ButtonSearch = new FontAwesome.Sharp.IconButton();
            this.dataGridViewContent = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelFooter.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.groupBoxChuyenNganh.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContent)).BeginInit();
            this.SuspendLayout();
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
            this.panelFooter.Location = new System.Drawing.Point(0, 731);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1386, 50);
            this.panelFooter.TabIndex = 5;
            // 
            // labelTotalPages
            // 
            this.labelTotalPages.AutoSize = true;
            this.labelTotalPages.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPages.Location = new System.Drawing.Point(949, 16);
            this.labelTotalPages.Name = "labelTotalPages";
            this.labelTotalPages.Size = new System.Drawing.Size(19, 21);
            this.labelTotalPages.TabIndex = 2;
            this.labelTotalPages.Text = "1";
            // 
            // labelCurrentPage
            // 
            this.labelCurrentPage.AutoSize = true;
            this.labelCurrentPage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentPage.Location = new System.Drawing.Point(878, 16);
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
            this.buttonNext2.Location = new System.Drawing.Point(1076, 7);
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
            this.buttonNext1.Location = new System.Drawing.Point(990, 7);
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
            this.buttonUndo1.Location = new System.Drawing.Point(776, 7);
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
            this.buttonUndo2.Location = new System.Drawing.Point(690, 7);
            this.buttonUndo2.Name = "buttonUndo2";
            this.buttonUndo2.Size = new System.Drawing.Size(80, 40);
            this.buttonUndo2.TabIndex = 0;
            this.buttonUndo2.Text = "<<";
            this.buttonUndo2.UseVisualStyleBackColor = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelHeader.Controls.Add(this.groupBoxChuyenNganh);
            this.panelHeader.Controls.Add(this.groupBoxSearch);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(428, 731);
            this.panelHeader.TabIndex = 6;
            // 
            // groupBoxChuyenNganh
            // 
            this.groupBoxChuyenNganh.Controls.Add(this.labelTGDT);
            this.groupBoxChuyenNganh.Controls.Add(this.textBoxTGDT);
            this.groupBoxChuyenNganh.Controls.Add(this.ButtonDel);
            this.groupBoxChuyenNganh.Controls.Add(this.labelNganh);
            this.groupBoxChuyenNganh.Controls.Add(this.comboBoxNganh);
            this.groupBoxChuyenNganh.Controls.Add(this.labelTenCN);
            this.groupBoxChuyenNganh.Controls.Add(this.ButtonAdd);
            this.groupBoxChuyenNganh.Controls.Add(this.ButtonUpdate);
            this.groupBoxChuyenNganh.Controls.Add(this.textBoxTenCN);
            this.groupBoxChuyenNganh.Controls.Add(this.textBoxMaCN);
            this.groupBoxChuyenNganh.Controls.Add(this.labelMaCN);
            this.groupBoxChuyenNganh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxChuyenNganh.Location = new System.Drawing.Point(45, 12);
            this.groupBoxChuyenNganh.Name = "groupBoxChuyenNganh";
            this.groupBoxChuyenNganh.Size = new System.Drawing.Size(325, 436);
            this.groupBoxChuyenNganh.TabIndex = 3;
            this.groupBoxChuyenNganh.TabStop = false;
            this.groupBoxChuyenNganh.Text = "Chuyên Ngành";
            // 
            // labelTGDT
            // 
            this.labelTGDT.AutoSize = true;
            this.labelTGDT.Location = new System.Drawing.Point(17, 128);
            this.labelTGDT.Name = "labelTGDT";
            this.labelTGDT.Size = new System.Drawing.Size(129, 19);
            this.labelTGDT.TabIndex = 7;
            this.labelTGDT.Text = "Thời Gian Đào Tạo:";
            this.labelTGDT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxTGDT
            // 
            this.textBoxTGDT.Location = new System.Drawing.Point(158, 127);
            this.textBoxTGDT.Name = "textBoxTGDT";
            this.textBoxTGDT.Size = new System.Drawing.Size(144, 26);
            this.textBoxTGDT.TabIndex = 8;
            // 
            // ButtonDel
            // 
            this.ButtonDel.BackColor = System.Drawing.Color.White;
            this.ButtonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDel.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ButtonDel.IconColor = System.Drawing.Color.Black;
            this.ButtonDel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonDel.IconSize = 40;
            this.ButtonDel.Location = new System.Drawing.Point(86, 369);
            this.ButtonDel.Name = "ButtonDel";
            this.ButtonDel.Size = new System.Drawing.Size(160, 50);
            this.ButtonDel.TabIndex = 6;
            this.ButtonDel.Text = "Xóa C.Ngành";
            this.ButtonDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonDel.UseVisualStyleBackColor = false;
            this.ButtonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // labelNganh
            // 
            this.labelNganh.AutoSize = true;
            this.labelNganh.Location = new System.Drawing.Point(17, 171);
            this.labelNganh.Name = "labelNganh";
            this.labelNganh.Size = new System.Drawing.Size(52, 19);
            this.labelNganh.TabIndex = 2;
            this.labelNganh.Text = "Ngành:";
            this.labelNganh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxNganh
            // 
            this.comboBoxNganh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNganh.FormattingEnabled = true;
            this.comboBoxNganh.Location = new System.Drawing.Point(158, 171);
            this.comboBoxNganh.Name = "comboBoxNganh";
            this.comboBoxNganh.Size = new System.Drawing.Size(144, 29);
            this.comboBoxNganh.TabIndex = 6;
            this.comboBoxNganh.Text = "CNTT";
            // 
            // labelTenCN
            // 
            this.labelTenCN.AutoSize = true;
            this.labelTenCN.Location = new System.Drawing.Point(17, 86);
            this.labelTenCN.Name = "labelTenCN";
            this.labelTenCN.Size = new System.Drawing.Size(129, 19);
            this.labelTenCN.TabIndex = 2;
            this.labelTenCN.Text = "Tên Chuyên Ngành:";
            this.labelTenCN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.White;
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.ButtonAdd.IconColor = System.Drawing.Color.Black;
            this.ButtonAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonAdd.IconSize = 45;
            this.ButtonAdd.Location = new System.Drawing.Point(88, 221);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(160, 50);
            this.ButtonAdd.TabIndex = 4;
            this.ButtonAdd.Text = "Thêm Mới";
            this.ButtonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.BackColor = System.Drawing.Color.White;
            this.ButtonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUpdate.IconChar = FontAwesome.Sharp.IconChar.Squarespace;
            this.ButtonUpdate.IconColor = System.Drawing.Color.Black;
            this.ButtonUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonUpdate.IconSize = 45;
            this.ButtonUpdate.Location = new System.Drawing.Point(86, 296);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(160, 50);
            this.ButtonUpdate.TabIndex = 5;
            this.ButtonUpdate.Text = "Cập Nhật";
            this.ButtonUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonUpdate.UseVisualStyleBackColor = false;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // textBoxTenCN
            // 
            this.textBoxTenCN.Location = new System.Drawing.Point(158, 85);
            this.textBoxTenCN.Name = "textBoxTenCN";
            this.textBoxTenCN.Size = new System.Drawing.Size(144, 26);
            this.textBoxTenCN.TabIndex = 3;
            // 
            // textBoxMaCN
            // 
            this.textBoxMaCN.Location = new System.Drawing.Point(158, 44);
            this.textBoxMaCN.Name = "textBoxMaCN";
            this.textBoxMaCN.Size = new System.Drawing.Size(144, 26);
            this.textBoxMaCN.TabIndex = 3;
            // 
            // labelMaCN
            // 
            this.labelMaCN.AutoSize = true;
            this.labelMaCN.Location = new System.Drawing.Point(17, 47);
            this.labelMaCN.Name = "labelMaCN";
            this.labelMaCN.Size = new System.Drawing.Size(127, 19);
            this.labelMaCN.TabIndex = 2;
            this.labelMaCN.Text = "Mã Chuyên Ngành:";
            this.labelMaCN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.comboBoxValue);
            this.groupBoxSearch.Controls.Add(this.comboBoxColumn);
            this.groupBoxSearch.Controls.Add(this.ButtonSearch);
            this.groupBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSearch.Location = new System.Drawing.Point(45, 508);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(325, 186);
            this.groupBoxSearch.TabIndex = 2;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Tìm Kiếm";
            // 
            // comboBoxValue
            // 
            this.comboBoxValue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxValue.FormattingEnabled = true;
            this.comboBoxValue.Location = new System.Drawing.Point(68, 74);
            this.comboBoxValue.Name = "comboBoxValue";
            this.comboBoxValue.Size = new System.Drawing.Size(180, 29);
            this.comboBoxValue.TabIndex = 6;
            // 
            // comboBoxColumn
            // 
            this.comboBoxColumn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxColumn.FormattingEnabled = true;
            this.comboBoxColumn.Items.AddRange(new object[] {
            "Mã Chuyên Ngành",
            "Tên Chuyên Ngành",
            "Ngành",
            "Khoa"});
            this.comboBoxColumn.Location = new System.Drawing.Point(68, 36);
            this.comboBoxColumn.Name = "comboBoxColumn";
            this.comboBoxColumn.Size = new System.Drawing.Size(180, 29);
            this.comboBoxColumn.TabIndex = 6;
            this.comboBoxColumn.Text = "Tên Chuyên Ngành";
            this.comboBoxColumn.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.ButtonSearch.IconColor = System.Drawing.Color.Black;
            this.ButtonSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonSearch.IconSize = 45;
            this.ButtonSearch.Location = new System.Drawing.Point(68, 115);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(180, 45);
            this.ButtonSearch.TabIndex = 3;
            this.ButtonSearch.Text = "Tìm Kiếm";
            this.ButtonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // dataGridViewContent
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dataGridViewContent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewContent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewContent.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewContent.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.dataGridViewContent.Size = new System.Drawing.Size(958, 731);
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
            // fChuyenNganh
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1386, 781);
            this.Controls.Add(this.dataGridViewContent);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelFooter);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fChuyenNganh";
            this.Text = "fChuyenNganh";
            this.Load += new System.EventHandler(this.fChuyenNganh_Load);
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.groupBoxChuyenNganh.ResumeLayout(false);
            this.groupBoxChuyenNganh.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label labelTotalPages;
        private System.Windows.Forms.Label labelCurrentPage;
        private System.Windows.Forms.Button buttonNext2;
        private System.Windows.Forms.Button buttonNext1;
        private System.Windows.Forms.Button buttonUndo1;
        private System.Windows.Forms.Button buttonUndo2;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.GroupBox groupBoxChuyenNganh;
        private System.Windows.Forms.Label labelNganh;
        private System.Windows.Forms.Label labelTenCN;
        private System.Windows.Forms.TextBox textBoxTenCN;
        private System.Windows.Forms.TextBox textBoxMaCN;
        private System.Windows.Forms.Label labelMaCN;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxValue;
        private System.Windows.Forms.ComboBox comboBoxColumn;
        private FontAwesome.Sharp.IconButton ButtonSearch;
        private System.Windows.Forms.ComboBox comboBoxNganh;
        private FontAwesome.Sharp.IconButton ButtonDel;
        private FontAwesome.Sharp.IconButton ButtonAdd;
        private FontAwesome.Sharp.IconButton ButtonUpdate;
        private System.Windows.Forms.Label labelTGDT;
        private System.Windows.Forms.TextBox textBoxTGDT;
        public Guna.UI2.WinForms.Guna2DataGridView dataGridViewContent;
    }
}