namespace GUI
{
    partial class fForgotPassword
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
            this.TextBoxPhoneNumber = new GUI.UserControls.KDTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxUsername = new GUI.UserControls.KDTextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.TextBoxEmail = new GUI.UserControls.KDTextBox();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSubmit.FlatAppearance.BorderSize = 0;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Location = new System.Drawing.Point(248, 386);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(125, 50);
            this.buttonSubmit.TabIndex = 79;
            this.buttonSubmit.Text = "SUBMIT";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // TextBoxPhoneNumber
            // 
            this.TextBoxPhoneNumber.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.TextBoxPhoneNumber.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TextBoxPhoneNumber.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TextBoxPhoneNumber.BorderFocusColor = System.Drawing.Color.MediumBlue;
            this.TextBoxPhoneNumber.BorderRadius = 20;
            this.TextBoxPhoneNumber.BorderSize = 2;
            this.TextBoxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPhoneNumber.Location = new System.Drawing.Point(129, 208);
            this.TextBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TextBoxPhoneNumber.Multiline = false;
            this.TextBoxPhoneNumber.Name = "TextBoxPhoneNumber";
            this.TextBoxPhoneNumber.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.TextBoxPhoneNumber.PasswordChar = false;
            this.TextBoxPhoneNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TextBoxPhoneNumber.PlaceholderText = "";
            this.TextBoxPhoneNumber.Size = new System.Drawing.Size(354, 43);
            this.TextBoxPhoneNumber.TabIndex = 1;
            this.TextBoxPhoneNumber.Texts = "";
            this.TextBoxPhoneNumber.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 74;
            this.label2.Text = "Phone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 73;
            this.label1.Text = "User Name";
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.TextBoxUsername.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TextBoxUsername.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TextBoxUsername.BorderFocusColor = System.Drawing.Color.MediumBlue;
            this.TextBoxUsername.BorderRadius = 20;
            this.TextBoxUsername.BorderSize = 2;
            this.TextBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUsername.Location = new System.Drawing.Point(129, 118);
            this.TextBoxUsername.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TextBoxUsername.Multiline = false;
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.TextBoxUsername.PasswordChar = false;
            this.TextBoxUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TextBoxUsername.PlaceholderText = "";
            this.TextBoxUsername.Size = new System.Drawing.Size(354, 43);
            this.TextBoxUsername.TabIndex = 0;
            this.TextBoxUsername.Texts = "";
            this.TextBoxUsername.UnderlinedStyle = false;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(133, 277);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(93, 17);
            this.labelEmail.TabIndex = 74;
            this.labelEmail.Text = "Email Address";
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.TextBoxEmail.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TextBoxEmail.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TextBoxEmail.BorderFocusColor = System.Drawing.Color.MediumBlue;
            this.TextBoxEmail.BorderRadius = 20;
            this.TextBoxEmail.BorderSize = 2;
            this.TextBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxEmail.Location = new System.Drawing.Point(129, 296);
            this.TextBoxEmail.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TextBoxEmail.Multiline = false;
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.TextBoxEmail.PasswordChar = false;
            this.TextBoxEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TextBoxEmail.PlaceholderText = "";
            this.TextBoxEmail.Size = new System.Drawing.Size(354, 43);
            this.TextBoxEmail.TabIndex = 2;
            this.TextBoxEmail.Texts = "";
            this.TextBoxEmail.UnderlinedStyle = false;
            // 
            // fForgotPassword
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(612, 591);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.TextBoxPhoneNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxUsername);
            this.Name = "fForgotPassword";
            this.Text = "Forgot Password";
            this.Load += new System.EventHandler(this.fForgotPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSubmit;
        private UserControls.KDTextBox TextBoxPhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private UserControls.KDTextBox TextBoxUsername;
        private System.Windows.Forms.Label labelEmail;
        private UserControls.KDTextBox TextBoxEmail;
    }
}