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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI
{
    public partial class fForgotPassword : Form
    {
        public fForgotPassword()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string username = TextBoxUsername.Text;
            string phonenumber = TextBoxPhoneNumber.Text;
            string email = TextBoxEmail.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(phonenumber) || string.IsNullOrEmpty(email))
            {
                MyMessageBox.Show("Vui Lòng Nhập Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string exist = BUSAccount.Instance.CheckExist(username);
                if (exist == "")
                {
                    string getPassword = BUSAccount.Instance.GetPassword(username, phonenumber, email);
                    if (getPassword == "")
                    {
                        MyMessageBox.Show("Số Điện Thoại Hoặc Địa Chỉ Email Không Khớp Với Tài Khoản. Vui Lòng Kiểm Tra Lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        MyMessageBox.Show($"Mật Khẩu của bạn là: {getPassword}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TextBoxUsername.Text  = null;
                        TextBoxPhoneNumber.Text = null;
                        TextBoxEmail.Text = null;
                    }
                }
                else
                {
                    MyMessageBox.Show("Tài Khoản Không Tồn Tại. Vui Lòng Kiểm Tra Lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }


        }

        private void fForgotPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
