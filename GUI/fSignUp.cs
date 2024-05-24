using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class fSignUp : Form
    {
        public fSignUp()
        {
            InitializeComponent();
        }

        public event EventHandler SignUpRequested;
        private void linkLabelLoginHere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpRequested?.Invoke(this, EventArgs.Empty);
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string username = TextBoxUsername.Text;
            string password = TextBoxPassword.Text;
            string confirmpass = TextBoxConfirmPass.Text;
            string phoneNumber = TextBoxPhoneNumber.Text;
            string email = TextBoxEmail.Text;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) 
                || string.IsNullOrWhiteSpace(confirmpass) || string.IsNullOrWhiteSpace(phoneNumber) || string.IsNullOrWhiteSpace(email))
            {

                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (confirmpass != password)
                {
                    MessageBox.Show("Mật Khẩu Xác Nhận Không Chính Xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string message = BUSAccount.Instance.Createaccount(username, password, phoneNumber, email); ;
                    if (message == "")
                    {
                        MessageBox.Show("Tạo Tài Khoản Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TextBoxConfirmPass.Text = "";
                        TextBoxUsername.Text = "";
                        TextBoxPassword.Text = "";
                        TextBoxPhoneNumber.Text = "";
                        TextBoxEmail.Text = "";
                    }
                    else
                    {
                        MessageBox.Show($"Thất Bại. {message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }

        }
    }
}
