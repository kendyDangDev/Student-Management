namespace GUI
{
    partial class fSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSignIn));
            this.linkLabelRegister = new System.Windows.Forms.LinkLabel();
            this.labelDontAccount = new System.Windows.Forms.Label();
            this.buttonLOGIN = new System.Windows.Forms.Button();
            this.linkLabelForgotPassword = new System.Windows.Forms.LinkLabel();
            this.checkBoxRemember = new System.Windows.Forms.CheckBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.panelLinePassword = new System.Windows.Forms.Panel();
            this.panelLineUserName = new System.Windows.Forms.Panel();
            this.labelLoginTitle = new System.Windows.Forms.Label();
            this.pictureBoxLOGO = new System.Windows.Forms.PictureBox();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLOGO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelRegister
            // 
            this.linkLabelRegister.AutoSize = true;
            this.linkLabelRegister.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelRegister.Location = new System.Drawing.Point(373, 478);
            this.linkLabelRegister.Name = "linkLabelRegister";
            this.linkLabelRegister.Size = new System.Drawing.Size(68, 18);
            this.linkLabelRegister.TabIndex = 5;
            this.linkLabelRegister.TabStop = true;
            this.linkLabelRegister.Text = "Register";
            this.linkLabelRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegister_LinkClicked);
            // 
            // labelDontAccount
            // 
            this.labelDontAccount.AutoSize = true;
            this.labelDontAccount.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDontAccount.Location = new System.Drawing.Point(190, 478);
            this.labelDontAccount.Name = "labelDontAccount";
            this.labelDontAccount.Size = new System.Drawing.Size(188, 18);
            this.labelDontAccount.TabIndex = 53;
            this.labelDontAccount.Text = "Don\'t Have An Account?";
            // 
            // buttonLOGIN
            // 
            this.buttonLOGIN.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonLOGIN.FlatAppearance.BorderSize = 0;
            this.buttonLOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLOGIN.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLOGIN.ForeColor = System.Drawing.Color.White;
            this.buttonLOGIN.Location = new System.Drawing.Point(254, 398);
            this.buttonLOGIN.Name = "buttonLOGIN";
            this.buttonLOGIN.Size = new System.Drawing.Size(125, 50);
            this.buttonLOGIN.TabIndex = 4;
            this.buttonLOGIN.Text = "LOGIN";
            this.buttonLOGIN.UseVisualStyleBackColor = false;
            this.buttonLOGIN.Click += new System.EventHandler(this.buttonLOGIN_Click);
            // 
            // linkLabelForgotPassword
            // 
            this.linkLabelForgotPassword.AutoSize = true;
            this.linkLabelForgotPassword.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelForgotPassword.Location = new System.Drawing.Point(398, 343);
            this.linkLabelForgotPassword.Name = "linkLabelForgotPassword";
            this.linkLabelForgotPassword.Size = new System.Drawing.Size(124, 16);
            this.linkLabelForgotPassword.TabIndex = 3;
            this.linkLabelForgotPassword.TabStop = true;
            this.linkLabelForgotPassword.Text = "Forgot Password?";
            this.linkLabelForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelForgotPassword_LinkClicked);
            // 
            // checkBoxRemember
            // 
            this.checkBoxRemember.AutoSize = true;
            this.checkBoxRemember.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRemember.Location = new System.Drawing.Point(118, 342);
            this.checkBoxRemember.Name = "checkBoxRemember";
            this.checkBoxRemember.Size = new System.Drawing.Size(154, 21);
            this.checkBoxRemember.TabIndex = 2;
            this.checkBoxRemember.Text = "Show/Hide Password";
            this.checkBoxRemember.UseVisualStyleBackColor = true;
            this.checkBoxRemember.CheckedChanged += new System.EventHandler(this.checkBoxRemember_CheckedChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBoxPassword.Location = new System.Drawing.Point(192, 288);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(259, 23);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.Text = "Password";
            this.textBoxPassword.Click += new System.EventHandler(this.textBoxPassword_Click);
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUserName.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBoxUserName.Location = new System.Drawing.Point(192, 228);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(259, 23);
            this.textBoxUserName.TabIndex = 0;
            this.textBoxUserName.Text = "Username";
            this.textBoxUserName.Click += new System.EventHandler(this.textBoxUserName_Click);
            this.textBoxUserName.Leave += new System.EventHandler(this.textBoxUserName_Leave);
            // 
            // panelLinePassword
            // 
            this.panelLinePassword.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelLinePassword.Location = new System.Drawing.Point(152, 317);
            this.panelLinePassword.Name = "panelLinePassword";
            this.panelLinePassword.Size = new System.Drawing.Size(299, 4);
            this.panelLinePassword.TabIndex = 47;
            // 
            // panelLineUserName
            // 
            this.panelLineUserName.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelLineUserName.Location = new System.Drawing.Point(152, 257);
            this.panelLineUserName.Name = "panelLineUserName";
            this.panelLineUserName.Size = new System.Drawing.Size(299, 4);
            this.panelLineUserName.TabIndex = 45;
            // 
            // labelLoginTitle
            // 
            this.labelLoginTitle.AutoSize = true;
            this.labelLoginTitle.Font = new System.Drawing.Font("Bookman Old Style", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginTitle.Location = new System.Drawing.Point(251, 151);
            this.labelLoginTitle.Name = "labelLoginTitle";
            this.labelLoginTitle.Size = new System.Drawing.Size(135, 41);
            this.labelLoginTitle.TabIndex = 43;
            this.labelLoginTitle.Text = "LOGIN";
            // 
            // pictureBoxLOGO
            // 
            this.pictureBoxLOGO.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLOGO.Image")));
            this.pictureBoxLOGO.Location = new System.Drawing.Point(238, -1);
            this.pictureBoxLOGO.Name = "pictureBoxLOGO";
            this.pictureBoxLOGO.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxLOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLOGO.TabIndex = 55;
            this.pictureBoxLOGO.TabStop = false;
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPassword.Image")));
            this.pictureBoxPassword.Location = new System.Drawing.Point(152, 281);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPassword.TabIndex = 46;
            this.pictureBoxPassword.TabStop = false;
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUser.Image")));
            this.pictureBoxUser.Location = new System.Drawing.Point(152, 221);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUser.TabIndex = 44;
            this.pictureBoxUser.TabStop = false;
            // 
            // fSignIn
            // 
            this.AcceptButton = this.buttonLOGIN;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(612, 591);
            this.Controls.Add(this.pictureBoxLOGO);
            this.Controls.Add(this.linkLabelRegister);
            this.Controls.Add(this.labelDontAccount);
            this.Controls.Add(this.buttonLOGIN);
            this.Controls.Add(this.linkLabelForgotPassword);
            this.Controls.Add(this.checkBoxRemember);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.panelLinePassword);
            this.Controls.Add(this.pictureBoxPassword);
            this.Controls.Add(this.panelLineUserName);
            this.Controls.Add(this.pictureBoxUser);
            this.Controls.Add(this.labelLoginTitle);
            this.Name = "fSignIn";
            this.Text = "fSignIn";
            this.Load += new System.EventHandler(this.fSignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLOGO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLOGO;
        private System.Windows.Forms.LinkLabel linkLabelRegister;
        private System.Windows.Forms.Label labelDontAccount;
        private System.Windows.Forms.Button buttonLOGIN;
        private System.Windows.Forms.LinkLabel linkLabelForgotPassword;
        private System.Windows.Forms.CheckBox checkBoxRemember;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Panel panelLinePassword;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.Panel panelLineUserName;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Label labelLoginTitle;
    }
}