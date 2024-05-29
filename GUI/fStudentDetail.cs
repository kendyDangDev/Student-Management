using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class StudentDetail : Form
    {
        private static StudentDetail _instance;
        public static StudentDetail Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new StudentDetail();
                }
                return _instance;
            }
        }
        public StudentDetail()
        {
            InitializeComponent();
        }

        private void StudentDetail_Load(object sender, EventArgs e)
        {

        }
        public void loadData(string masv,
                        string hoten,
                        string gioitinh,
                        string dantoc,
                        DateTime ngaysinh,
                        string diachi,
                        string sdt,
                        string email,
                        string socccd,
                        string nienkhoa,
                        string namnhaphoc,
                        string malop,

                        string hotennt,
                        string quanhe,
                        DateTime ngaysinhnt,
                        string sdtnt,
                        string hedaotao)
        {
            textBoxMaSV.Text = masv;
            textBoxHoTen.Text = hoten;
            textBoxGioiTinh.Text = gioitinh;
            textBoxDanToc.Text = dantoc;
            TimePickerBirthday.Value = ngaysinh;
            textBoxAddress.Text = diachi;
            textBoxPhone.Text = sdt;
            textBoxEmail.Text = email;
            textBoxSoCCCD.Text = socccd;
            textBoxNienKhoa.Text = nienkhoa;
            //textBoxNamNhapHoc.Text = namnhaphoc;
            textBoxHeDaoTao.Text = hedaotao;
            comboBoxLop.Text = malop;
            textBoxHoTenNT.Text = hotennt;
            textBoxRelative.Text = quanhe;
            TimePickerBirthdayNT.Value = ngaysinhnt;
            textBoxPhoneNT.Text = sdtnt;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kdDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNienKhoa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
