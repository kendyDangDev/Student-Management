namespace GUI
{
    partial class fSignUp
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
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.linkLabelLoginHere = new System.Windows.Forms.LinkLabel();
            this.labelHaveAccount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxConfirmPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSubmit.FlatAppearance.BorderSize = 0;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Location = new System.Drawing.Point(254, 398);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(125, 50);
            this.buttonSubmit.TabIndex = 70;
            this.buttonSubmit.Text = "SUBMIT";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // linkLabelLoginHere
            // 
            this.linkLabelLoginHere.AutoSize = true;
            this.linkLabelLoginHere.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLoginHere.Location = new System.Drawing.Point(371, 478);
            this.linkLabelLoginHere.Name = "linkLabelLoginHere";
            this.linkLabelLoginHere.Size = new System.Drawing.Size(87, 18);
            this.linkLabelLoginHere.TabIndex = 69;
            this.linkLabelLoginHere.TabStop = true;
            this.linkLabelLoginHere.Text = "Login Here";
            this.linkLabelLoginHere.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLoginHere_LinkClicked);
            // 
            // labelHaveAccount
            // 
            this.labelHaveAccount.AutoSize = true;
            this.labelHaveAccount.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHaveAccount.Location = new System.Drawing.Point(173, 478);
            this.labelHaveAccount.Name = "labelHaveAccount";
            this.labelHaveAccount.Size = new System.Drawing.Size(203, 18);
            this.labelHaveAccount.TabIndex = 68;
            this.labelHaveAccount.Text = "Already Have An Account?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(154, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 18);
            this.label4.TabIndex = 64;
            this.label4.Text = "Confirm Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(154, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 63;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(154, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 62;
            this.label2.Text = "Phone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(154, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 61;
            this.label1.Text = "User Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(154, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 18);
            this.label5.TabIndex = 62;
            this.label5.Text = "Email Address";
            // 
            // TextBoxConfirmPass
            // 
            this.TextBoxConfirmPass.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxConfirmPass.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxConfirmPass.BorderRadius = 5;
            this.TextBoxConfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxConfirmPass.DefaultText = "";
            this.TextBoxConfirmPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxConfirmPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxConfirmPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxConfirmPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxConfirmPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxConfirmPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxConfirmPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxConfirmPass.Location = new System.Drawing.Point(156, 337);
            this.TextBoxConfirmPass.Name = "TextBoxConfirmPass";
            this.TextBoxConfirmPass.PasswordChar = '\0';
            this.TextBoxConfirmPass.PlaceholderText = "";
            this.TextBoxConfirmPass.SelectedText = "";
            this.TextBoxConfirmPass.Size = new System.Drawing.Size(320, 43);
            this.TextBoxConfirmPass.TabIndex = 71;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxPassword.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxPassword.BorderRadius = 5;
            this.TextBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPassword.DefaultText = "";
            this.TextBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxPassword.Location = new System.Drawing.Point(156, 264);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '\0';
            this.TextBoxPassword.PlaceholderText = "";
            this.TextBoxPassword.SelectedText = "";
            this.TextBoxPassword.Size = new System.Drawing.Size(320, 43);
            this.TextBoxPassword.TabIndex = 71;
            // 
            // TextBoxPhoneNumber
            // 
            this.TextBoxPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxPhoneNumber.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxPhoneNumber.BorderRadius = 5;
            this.TextBoxPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPhoneNumber.DefaultText = "";
            this.TextBoxPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxPhoneNumber.Location = new System.Drawing.Point(156, 112);
            this.TextBoxPhoneNumber.Name = "TextBoxPhoneNumber";
            this.TextBoxPhoneNumber.PasswordChar = '\0';
            this.TextBoxPhoneNumber.PlaceholderText = "0363969923";
            this.TextBoxPhoneNumber.SelectedText = "";
            this.TextBoxPhoneNumber.Size = new System.Drawing.Size(320, 43);
            this.TextBoxPhoneNumber.TabIndex = 71;
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxEmail.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxEmail.BorderRadius = 5;
            this.TextBoxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxEmail.DefaultText = "";
            this.TextBoxEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxEmail.Location = new System.Drawing.Point(156, 188);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.PasswordChar = '\0';
            this.TextBoxEmail.PlaceholderText = "dodangthang2004@gmail.com";
            this.TextBoxEmail.SelectedText = "";
            this.TextBoxEmail.Size = new System.Drawing.Size(320, 43);
            this.TextBoxEmail.TabIndex = 71;
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxUsername.BorderColor = System.Drawing.Color.Silver;
            this.TextBoxUsername.BorderRadius = 5;
            this.TextBoxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxUsername.DefaultText = "";
            this.TextBoxUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxUsername.Location = new System.Drawing.Point(156, 37);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.PasswordChar = '\0';
            this.TextBoxUsername.PlaceholderText = "Kendydang198";
            this.TextBoxUsername.SelectedText = "";
            this.TextBoxUsername.Size = new System.Drawing.Size(320, 43);
            this.TextBoxUsername.TabIndex = 71;
            // 
            // fSignUp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(612, 591);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.TextBoxPhoneNumber);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxConfirmPass);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.linkLabelLoginHere);
            this.Controls.Add(this.labelHaveAccount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fSignUp";
            this.Text = "fSignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.LinkLabel linkLabelLoginHere;
        private System.Windows.Forms.Label labelHaveAccount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxConfirmPass;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxPassword;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxPhoneNumber;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxEmail;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxUsername;
    }
}