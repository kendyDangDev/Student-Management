namespace GUI
{
    partial class fChangePassword
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
            this.TextBoxNewPass = new GUI.UserControls.KDTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxOldPass = new GUI.UserControls.KDTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxConfirm = new GUI.UserControls.KDTextBox();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSubmit.FlatAppearance.BorderSize = 0;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Location = new System.Drawing.Point(243, 380);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(125, 50);
            this.buttonSubmit.TabIndex = 86;
            this.buttonSubmit.Text = "SUBMIT";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // TextBoxNewPass
            // 
            this.TextBoxNewPass.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.TextBoxNewPass.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TextBoxNewPass.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TextBoxNewPass.BorderFocusColor = System.Drawing.Color.MediumBlue;
            this.TextBoxNewPass.BorderRadius = 20;
            this.TextBoxNewPass.BorderSize = 2;
            this.TextBoxNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNewPass.Location = new System.Drawing.Point(129, 216);
            this.TextBoxNewPass.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TextBoxNewPass.Multiline = false;
            this.TextBoxNewPass.Name = "TextBoxNewPass";
            this.TextBoxNewPass.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.TextBoxNewPass.PasswordChar = false;
            this.TextBoxNewPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TextBoxNewPass.PlaceholderText = "";
            this.TextBoxNewPass.Size = new System.Drawing.Size(354, 43);
            this.TextBoxNewPass.TabIndex = 85;
            this.TextBoxNewPass.Texts = "";
            this.TextBoxNewPass.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 83;
            this.label2.Text = "Mật Khẩu Mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 82;
            this.label1.Text = "Mật Khẩu Cũ";
            // 
            // TextBoxOldPass
            // 
            this.TextBoxOldPass.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.TextBoxOldPass.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TextBoxOldPass.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TextBoxOldPass.BorderFocusColor = System.Drawing.Color.MediumBlue;
            this.TextBoxOldPass.BorderRadius = 20;
            this.TextBoxOldPass.BorderSize = 2;
            this.TextBoxOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxOldPass.Location = new System.Drawing.Point(129, 126);
            this.TextBoxOldPass.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TextBoxOldPass.Multiline = false;
            this.TextBoxOldPass.Name = "TextBoxOldPass";
            this.TextBoxOldPass.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.TextBoxOldPass.PasswordChar = false;
            this.TextBoxOldPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TextBoxOldPass.PlaceholderText = "";
            this.TextBoxOldPass.Size = new System.Drawing.Size(354, 43);
            this.TextBoxOldPass.TabIndex = 81;
            this.TextBoxOldPass.Texts = "";
            this.TextBoxOldPass.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 17);
            this.label3.TabIndex = 83;
            this.label3.Text = "Xác Nhận Mật Khẩu Mới";
            // 
            // TextBoxConfirm
            // 
            this.TextBoxConfirm.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.TextBoxConfirm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TextBoxConfirm.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TextBoxConfirm.BorderFocusColor = System.Drawing.Color.MediumBlue;
            this.TextBoxConfirm.BorderRadius = 20;
            this.TextBoxConfirm.BorderSize = 2;
            this.TextBoxConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxConfirm.Location = new System.Drawing.Point(129, 303);
            this.TextBoxConfirm.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TextBoxConfirm.Multiline = true;
            this.TextBoxConfirm.Name = "TextBoxConfirm";
            this.TextBoxConfirm.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.TextBoxConfirm.PasswordChar = false;
            this.TextBoxConfirm.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TextBoxConfirm.PlaceholderText = "";
            this.TextBoxConfirm.Size = new System.Drawing.Size(354, 43);
            this.TextBoxConfirm.TabIndex = 85;
            this.TextBoxConfirm.Texts = "";
            this.TextBoxConfirm.UnderlinedStyle = false;
            // 
            // fChangePassword
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(612, 591);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.TextBoxConfirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxNewPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxOldPass);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fChangePassword";
            this.Text = "fChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSubmit;
        private UserControls.KDTextBox TextBoxNewPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private UserControls.KDTextBox TextBoxOldPass;
        private System.Windows.Forms.Label label3;
        private UserControls.KDTextBox TextBoxConfirm;
    }
}