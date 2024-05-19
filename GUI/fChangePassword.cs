using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fChangePassword : Form
    {
        public fChangePassword()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string oldPass = TextBoxOldPass.Text;
            string newPass = TextBoxNewPass.Text;
            string confirmNewPass = TextBoxConfirm.Text;
            if (newPass == confirmNewPass)
            {

            }
            else
            {
                MessageBox.Show("Mật Khẩu Xác Nhận Không Khớp");
            }
        }
    }
}
