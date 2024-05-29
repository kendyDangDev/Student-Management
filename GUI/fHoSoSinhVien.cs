using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fHoSoSinhVien : Form
    {
        private static fHoSoSinhVien _instance;
        public static fHoSoSinhVien Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new fHoSoSinhVien();
                }
                return _instance;
            }
        }
        public fHoSoSinhVien()
        {
            InitializeComponent();
            LoadSinhVien();
       
            TimePickerBirthday.CustomFormat = "dd/MM/yyyy";
            TimePickerBirthdayNT.CustomFormat = "dd/MM/yyyy";
            LoadClassList();


        }
        public string type = fSignIn.accountType;

        public string username = fSignIn.userNameLogin;


        void LoadClassList()
        {
            BUSClass.Instance.GetAllLopHoc(comboBoxLop);
        }
        void LoadSinhVien()
        {
            BUSStudent.Instance.GetAllStudent(dataGridViewContent);
            dataGridViewContent.DataBindingComplete += (sender, e) =>
            {
                if (!dataGridViewContent.Columns.Contains("STT"))
                {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                    column.HeaderText = "STT";
                    column.Name = "STT"; // Đặt tên cho cột để dễ kiểm tra
                    dataGridViewContent.Columns.Insert(0, column);
                }

                // Cập nhật giá trị cho cột STT
                for (int i = 0; i < dataGridViewContent.Rows.Count; i++)
                {
                    dataGridViewContent.Rows[i].Cells["STT"].Value = (i + 1).ToString();
                }
            };
            foreach (DataGridViewColumn column in dataGridViewContent.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        #region Event

        private void fHoSoSinhVien_Load(object sender, EventArgs e)
        {
            if (type.ToLower() == "user")
            {
                BUSStudent.Instance.GetStudent(dataGridViewContent, username);

            }

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (type.ToLower() == "user")
            {
                MessageBox.Show("Tài Khoản Cùa Bạn Không Thể Sử Dụng Chức Năng Này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string masv = textBoxMaSV.Text;
                string hoten = textBoxHoTen.Text;
                string gioitinh = comboBoxGioiTinh.Text;
                if (comboBoxGioiTinh.SelectedIndex != -1)
                {
                    gioitinh = comboBoxGioiTinh.SelectedItem.ToString();

                }
                string dantoc = textBoxDanToc.Text;
                DateTime ngaysinh = DateTime.Parse(TimePickerBirthday.Value.ToString());
                string diachi = textBoxAddress.Text;
                string sdt = textBoxPhone.Text;
                string email = textBoxEmail.Text;
                string socccd = textBoxSoCCCD.Text;

                string hotennt = textBoxHoTenNT.Text;
                string quanhe = textBoxRelative.Text;
                DateTime ngaysinhnt = DateTime.Parse(TimePickerBirthdayNT.Value.ToString());
                string sdtnnt = textBoxPhoneNT.Text;

                string malop = comboBoxLop.Text;
                if (comboBoxLop.SelectedIndex != -1)
                {
                    malop = comboBoxLop.SelectedValue.ToString();

                }
                string nienkhoa = textBoxNienKhoa.Text;
                string hdt = comboBoxHDT.Text;
                if (comboBoxHDT.SelectedIndex != -1)
                {
                    hdt = comboBoxHDT.SelectedItem.ToString();

                }
                string namnhaphoc = textBoxNamNhapHoc.Text;


                if (string.IsNullOrWhiteSpace(masv) ||
                    string.IsNullOrWhiteSpace(hoten) ||
                    string.IsNullOrWhiteSpace(gioitinh) ||
                    string.IsNullOrWhiteSpace(dantoc) ||
                    ngaysinh == DateTime.MinValue ||
                    string.IsNullOrWhiteSpace(diachi) ||
                    string.IsNullOrWhiteSpace(sdt) ||
                    string.IsNullOrWhiteSpace(email) ||
                    string.IsNullOrWhiteSpace(socccd) ||
                    string.IsNullOrWhiteSpace(hotennt) ||
                    string.IsNullOrWhiteSpace(quanhe) ||
                    ngaysinhnt == DateTime.MinValue ||
                    string.IsNullOrWhiteSpace(sdtnnt) ||
                    string.IsNullOrWhiteSpace(malop) ||
                    string.IsNullOrWhiteSpace(nienkhoa) ||
                    string.IsNullOrWhiteSpace(hdt) ||
                    string.IsNullOrWhiteSpace(namnhaphoc))
                {
                    // Hiển thị thông báo hoặc thực hiện các hành động xử lý khi thông tin chưa được nhập đủ
                    MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string message = BUSStudent.Instance.AddHoSoSinhVien(masv, hoten, gioitinh, dantoc, ngaysinh, diachi, sdt, email, socccd, nienkhoa, namnhaphoc, malop, hotennt, quanhe, ngaysinhnt, sdtnnt);
                    if (message == "")
                    {
                        MessageBox.Show("Thêm Sinh Viên Mới Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BUSStudent.Instance.GetAllStudent(dataGridViewContent);
                        //dataGridViewContent.Columns.RemoveAt(0);

                    }
                    else
                    {
                        MessageBox.Show($"Thất Bại. {message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
        }

        private void comboBoxColumn_SelectedIndexChanged(object sender, EventArgs e)
        {

            textBoxValue.Text = comboBoxColumn.Text;
            textBoxValue.ForeColor = SystemColors.ActiveBorder;

        }

        private void TextBoxSearch_Click(object sender, EventArgs e)
        {
            textBoxValue.Text = "";
            textBoxValue.ForeColor = Color.Black; // Đặt màu chữ xám
        }

        private void TextBoxSearch_Load(object sender, EventArgs e)
        {
            textBoxValue.Text = comboBoxColumn.Text;
            textBoxValue.ForeColor = SystemColors.ActiveBorder;
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxValue.Text))
            {
                textBoxValue.Text = comboBoxColumn.Text;
                textBoxValue.ForeColor = SystemColors.ActiveBorder;
            }
        }

        #endregion

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            string masv = textBoxMaSV.Text;
            string hoten = textBoxHoTen.Text;
            string gioitinh = comboBoxGioiTinh.Text;
            if (comboBoxGioiTinh.SelectedIndex != -1)
            {
                gioitinh = comboBoxGioiTinh.SelectedItem.ToString();

            }
            string dantoc = textBoxDanToc.Text;
            DateTime ngaysinh = TimePickerBirthday.Value;
            string diachi = textBoxAddress.Text;
            string sdt = textBoxPhone.Text;
            string email = textBoxEmail.Text;
            string socccd = textBoxSoCCCD.Text;
            string hotennt = textBoxHoTenNT.Text;
            string quanhe = textBoxRelative.Text;
            DateTime ngaysinhnt = DateTime.Parse(TimePickerBirthdayNT.Value.ToString());
            string sdtnnt = textBoxPhoneNT.Text;

            string malop = comboBoxLop.Text;
            if (comboBoxLop.SelectedIndex != -1)
            {
                malop = comboBoxLop.SelectedValue.ToString();

            }
            string nienkhoa = textBoxNienKhoa.Text;
            string hdt = comboBoxHDT.Text;
            if (comboBoxHDT.SelectedIndex != -1)
            {
                hdt = comboBoxHDT.SelectedItem.ToString();

            }
            string namnhaphoc = textBoxNamNhapHoc.Text;


            if (string.IsNullOrWhiteSpace(masv) ||
                string.IsNullOrWhiteSpace(hoten) ||
                string.IsNullOrWhiteSpace(gioitinh) ||
                string.IsNullOrWhiteSpace(dantoc) ||
                ngaysinh == DateTime.MinValue ||
                string.IsNullOrWhiteSpace(diachi) ||
                string.IsNullOrWhiteSpace(sdt) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(socccd) ||
                string.IsNullOrWhiteSpace(hotennt) ||
                string.IsNullOrWhiteSpace(quanhe) ||
                ngaysinhnt == DateTime.MinValue ||
                string.IsNullOrWhiteSpace(sdtnnt) ||
                string.IsNullOrWhiteSpace(malop) ||
                string.IsNullOrWhiteSpace(nienkhoa) ||
                string.IsNullOrWhiteSpace(hdt) ||
                string.IsNullOrWhiteSpace(namnhaphoc))
            {
   
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string message = BUSStudent.Instance.UpdateHoSoSinhVien(masv, hoten, gioitinh, dantoc, ngaysinh, diachi, sdt, email, socccd, nienkhoa, namnhaphoc, malop, hotennt, quanhe, ngaysinhnt, sdtnnt);
                if (message == "")
                {
                    MessageBox.Show("Cập Nhật Thông Tin Sinh Viên Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BUSStudent.Instance.GetAllStudent(dataGridViewContent);
                    //dataGridViewContent.Columns.RemoveAt(0);

                }
                else
                {
                    MessageBox.Show($"Thất Bại. {message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        int index = -1;
        private void dataGridViewContent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            if (type.ToLower() == "user")
            {
                MessageBox.Show("Tài Khoản Cùa Bạn Không Thể Sử Dụng Chức Năng Này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                DialogResult result = MessageBox.Show($"Bạn Có Chắc Chắn Muốn Xóa Sinh Viên Có Mã: {textBoxMaSV.Text}", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (isDelete(textBoxMaSV.Text))
                    {
                        MessageBox.Show($"Xóa Thành Công Sinh Viên Có Mã: {textBoxMaSV.Text}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSinhVien();
                        //dataGridViewContent.Columns.RemoveAt(0);

                    }
                    else
                    {
                        MessageBox.Show($"Thất Bại. Không Tồn Tại Sinh Viên Có Mã: {textBoxMaSV.Text}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }

        }

        bool isDelete(string ID)
        {
            return BUSStudent.Instance.DeleteStudent(ID);
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (type.ToLower() == "user")
            {
                MessageBox.Show("Tài Khoản Cùa Bạn Không Thể Sử Dụng Chức Năng Này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string columnsearch = comboBoxColumn.Text;
                if (comboBoxColumn.SelectedIndex != -1)
                {
                    columnsearch = comboBoxColumn.SelectedItem.ToString();

                }
                string valueSearch = textBoxValue.Text;

                if (string.IsNullOrEmpty(valueSearch))
                {
                    MessageBox.Show("Nhập Giá Trị Cần Tìm Kiếm");
                }
                else
                {
           
                    BUSStudent.Instance.FilterStudent(dataGridViewContent, columnsearch, valueSearch);
                }
            }
            

        }



        private void kdDateTimePickerNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxValue_Click(object sender, EventArgs e)
        {
            textBoxValue.Text = "";
            textBoxValue.ForeColor = Color.Black;
        }

        private void dataGridViewContent_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                index = e.RowIndex;
                textBoxMaSV.Text = dataGridViewContent.Rows[index].Cells[1].Value.ToString();
                textBoxHoTen.Text = dataGridViewContent.Rows[index].Cells[2].Value.ToString();
                comboBoxGioiTinh.Text = dataGridViewContent.Rows[index].Cells[3].Value.ToString();
                textBoxDanToc.Text = dataGridViewContent.Rows[index].Cells[4].Value.ToString();
                string dateStringsv = dataGridViewContent.Rows[index].Cells[5].Value.ToString();
                if (DateTime.TryParseExact(dateStringsv, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime svparsedDate))
                {
  
                    string newDateString = svparsedDate.ToString("MM/dd/yyyy");
                    TimePickerBirthday.Value = DateTime.ParseExact(newDateString, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                }
                textBoxAddress.Text = dataGridViewContent.Rows[index].Cells[6].Value.ToString();
                textBoxPhone.Text = dataGridViewContent.Rows[index].Cells[7].Value.ToString();
                textBoxEmail.Text = dataGridViewContent.Rows[index].Cells[8].Value.ToString();
                textBoxSoCCCD.Text = dataGridViewContent.Rows[index].Cells[9].Value.ToString();
                textBoxNienKhoa.Text = dataGridViewContent.Rows[index].Cells[10].Value.ToString();
                textBoxNamNhapHoc.Text = dataGridViewContent.Rows[index].Cells[11].Value.ToString();
                comboBoxHDT.Text = dataGridViewContent.Rows[index].Cells[12].Value.ToString();

                comboBoxLop.Text = dataGridViewContent.Rows[index].Cells[13].Value.ToString();
                textBoxHoTenNT.Text = dataGridViewContent.Rows[index].Cells[15].Value.ToString();
                textBoxRelative.Text = dataGridViewContent.Rows[index].Cells[16].Value.ToString();
                string dateStringnt = dataGridViewContent.Rows[index].Cells[17].Value.ToString();
                if (DateTime.TryParseExact(dateStringnt, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ntparsedDate))
                {
                    // Chuyển đổi DateTime sang chuỗi theo định dạng mới
                    string newDateString = ntparsedDate.ToString("MM/dd/yyyy");
                    TimePickerBirthdayNT.Value = DateTime.ParseExact(newDateString, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                }
                textBoxPhoneNT.Text = dataGridViewContent.Rows[index].Cells[18].Value.ToString();
            }
        }

        Color color;
        private void dataGridViewContent_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                color = dataGridViewContent.Rows[e.RowIndex].DefaultCellStyle.BackColor;
                dataGridViewContent.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightSkyBlue;

            }
        }
        private void dataGridViewContent_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
    
                dataGridViewContent.Rows[e.RowIndex].DefaultCellStyle.BackColor = color;
            }
        }

        private void dataGridViewContent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         
            if (e.RowIndex != -1)
            {
                index = e.RowIndex;
                string masv = textBoxMaSV.Text;
                string hoten = dataGridViewContent.Rows[index].Cells[2].Value.ToString();
                string gioitinh = dataGridViewContent.Rows[index].Cells[3].Value.ToString();
                string dantoc = dataGridViewContent.Rows[index].Cells[4].Value.ToString();
            
                DateTime ngaysinh = DateTime.Parse(TimePickerBirthday.Value.ToString());

                string diachi = dataGridViewContent.Rows[index].Cells[6].Value.ToString();
                string sdt= dataGridViewContent.Rows[index].Cells[7].Value.ToString();
                string email = dataGridViewContent.Rows[index].Cells[8].Value.ToString();
                string cccd = dataGridViewContent.Rows[index].Cells[9].Value.ToString();
               string nienkhoa = dataGridViewContent.Rows[index].Cells[10].Value.ToString();
                string namnhaphoc = dataGridViewContent.Rows[index].Cells[11].Value.ToString();
                string hedaotao= dataGridViewContent.Rows[index].Cells[12].Value.ToString();

                string malop = dataGridViewContent.Rows[index].Cells[13].Value.ToString();
                string hotenNT = dataGridViewContent.Rows[index].Cells[15].Value.ToString();
                string mqh = dataGridViewContent.Rows[index].Cells[16].Value.ToString();
                       
                DateTime ngaysinhNT = TimePickerBirthdayNT.Value;

                string sdtNT = dataGridViewContent.Rows[index].Cells[18].Value.ToString();

                StudentDetail.Instance.loadData(masv, hoten, gioitinh, dantoc, ngaysinh, diachi, sdt, email, cccd, nienkhoa, namnhaphoc, malop, hotenNT, mqh, ngaysinhNT, sdtNT, hedaotao );
                StudentDetail.Instance.Show();

            }
        }
    }
}
