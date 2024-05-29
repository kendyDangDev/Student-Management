using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace GUI
{
    public partial class fHoSoGiangVien : Form
    {
        private static fHoSoGiangVien _instance;
        public static fHoSoGiangVien Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new fHoSoGiangVien();
                }
                return _instance;
            }
        }
        public fHoSoGiangVien()
        {
            InitializeComponent();
            LoadGiangVien();
            LoadFaculty();
            TimePickerNgaySinh.CustomFormat = "dd/MM/yyyy";

        }
        public string type = fSignIn.accountType;
        #region Method

        #endregion

        #region Event

        void LoadFaculty()
        {
            BUSFaculty.Instance.GetFacultyName(comboBoxKhoa);
        }
        void LoadGiangVien()
        {
            BUSLecturer.Instance.GetAllGiangVien(dataGridViewContent);
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
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (type.ToLower() == "user")
            {
                MyMessageBox.Show("Tài Khoản Cùa Bạn Không Thể Sử Dụng Chức Năng Này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string maGV = textBoxMaGV.Text;
                string hoten = textBoxHoten.Text;
                string gioitinh = comboBoxGioiTinh.Text;
                if (comboBoxGioiTinh.SelectedIndex != -1)
                {
                    gioitinh = comboBoxGioiTinh.SelectedItem.ToString();

                }
                string trinhdo = comboBoxTrinhDo.Text;
                if (comboBoxTrinhDo.SelectedIndex != -1)
                {
                    trinhdo = comboBoxTrinhDo.SelectedItem.ToString();

                }
                DateTime ngaysinh = DateTime.Parse(TimePickerNgaySinh.Value.ToString());
                string diachi = textBoxDiaChi.Text;
                string socccd = textBoxSoCCCD.Text;
                string sdt = textBoxSDT.Text;
                string tenkhoa = comboBoxKhoa.Text;


                if (string.IsNullOrWhiteSpace(maGV) ||
                    string.IsNullOrWhiteSpace(hoten) ||
                    string.IsNullOrWhiteSpace(gioitinh) ||
                    string.IsNullOrWhiteSpace(trinhdo) ||
                    ngaysinh == DateTime.MinValue ||
                    string.IsNullOrWhiteSpace(diachi) ||
                    string.IsNullOrWhiteSpace(sdt) ||
                    string.IsNullOrWhiteSpace(socccd) ||
                    string.IsNullOrWhiteSpace(sdt) ||
                    string.IsNullOrWhiteSpace(tenkhoa))

                {
                    // Hiển thị thông báo hoặc thực hiện các hành động xử lý khi thông tin chưa được nhập đủ
                    MyMessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string makhoa = BUSFaculty.Instance.GetIDByName(tenkhoa);

                    string message = BUSLecturer.Instance.InsertGiangVien(maGV, hoten, gioitinh, trinhdo, ngaysinh, diachi, socccd, sdt, makhoa);
                    if (message == "")
                    {
                        MyMessageBox.Show("Thêm Giảng Viên Mới Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BUSLecturer.Instance.GetAllGiangVien(dataGridViewContent);
                        

                    }
                    else
                    {
                        MyMessageBox.Show($"Thất Bại. {message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (type.ToLower() == "user")
            {
                MyMessageBox.Show("Tài Khoản Cùa Bạn Không Thể Sử Dụng Chức Năng Này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string maGV = textBoxMaGV.Text;
                string hoten = textBoxHoten.Text;
                string gioitinh = comboBoxGioiTinh.Text;
                if (comboBoxGioiTinh.SelectedIndex != -1)
                {
                    gioitinh = comboBoxGioiTinh.SelectedItem.ToString();

                }
                string trinhdo = comboBoxTrinhDo.Text;
                if (comboBoxTrinhDo.SelectedIndex != -1)
                {
                    trinhdo = comboBoxTrinhDo.SelectedItem.ToString();

                }
                DateTime ngaysinh = DateTime.Parse(TimePickerNgaySinh.Value.ToString());
                string diachi = textBoxDiaChi.Text;
                string socccd = textBoxSoCCCD.Text;
                string sdt = textBoxSDT.Text;
                string tenkhoa = comboBoxKhoa.Text;


                if (string.IsNullOrWhiteSpace(maGV) ||
                    string.IsNullOrWhiteSpace(hoten) ||
                    string.IsNullOrWhiteSpace(gioitinh) ||
                    string.IsNullOrWhiteSpace(trinhdo) ||
                    ngaysinh == DateTime.MinValue ||
                    string.IsNullOrWhiteSpace(diachi) ||
                    string.IsNullOrWhiteSpace(sdt) ||
                    string.IsNullOrWhiteSpace(socccd) ||
                    string.IsNullOrWhiteSpace(sdt) ||
                    string.IsNullOrWhiteSpace(tenkhoa))

                {
                    // Hiển thị thông báo hoặc thực hiện các hành động xử lý khi thông tin chưa được nhập đủ
                    MyMessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string makhoa = BUSFaculty.Instance.GetIDByName(tenkhoa);
                    string message = BUSLecturer.Instance.UpdateGiangVien(maGV, hoten, gioitinh, trinhdo, ngaysinh, diachi, socccd, sdt, makhoa);
                    if (message == "")
                    {
                        MyMessageBox.Show("Cập Nhật Thông Tin Giảng Viên Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BUSLecturer.Instance.GetAllGiangVien(dataGridViewContent);
                        

                    }
                    else
                    {
                        MyMessageBox.Show($"Thất Bại. {message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            if (type.ToLower() == "user")
            {
                MyMessageBox.Show("Tài Khoản Cùa Bạn Không Thể Sử Dụng Chức Năng Này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                DialogResult result = MyMessageBox.Show($"Bạn Có Chắc Chắn Muốn Giảng Viên Có Mã: {textBoxMaGV.Text}", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (isDelete(textBoxMaGV.Text))
                    {
                        MyMessageBox.Show($"Xóa Giảng Viên Có Mã: {textBoxMaGV.Text}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadGiangVien();
                        

                    }
                    else
                    {
                        MyMessageBox.Show($"Thất Bại. Không Tồn Tại Giảng Viên Có Mã: {textBoxMaGV.Text}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
        }
        bool isDelete(string magv)
        {
            return BUSLecturer.Instance.DeleteGiangVien(magv);
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string columnsearch = comboBoxColumn.Text;
            if (comboBoxColumn.SelectedIndex != -1)
            {
                columnsearch = comboBoxColumn.SelectedItem.ToString();
            }
            string valueSearch = textBoxValue.Text;

            if (string.IsNullOrEmpty(valueSearch))
            {
                MyMessageBox.Show("vui lòng nhập giá trị cần tìm kiếm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Ok
                BUSLecturer.Instance.FilterLectures(dataGridViewContent, columnsearch, valueSearch);
            }

        }


        #endregion

        int index;
        private void dataGridViewContent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }



   

        private void textBoxValueSearch_Click(object sender, EventArgs e)
        {
            textBoxValue.Text = "";
            textBoxValue.ForeColor = Color.Black;
        }

        private void textBoxValueSearch_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxValue.Text))
            {
                textBoxValue.Text = comboBoxColumn.Text;
                textBoxValue.ForeColor = SystemColors.ActiveBorder;
            }
      
        }

        private void comboBoxColumnSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxValue.Text = comboBoxColumn.Text;
            textBoxValue.ForeColor = SystemColors.ActiveBorder;
        }

        private void comboBoxKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fHoSoGiangVien_Load(object sender, EventArgs e)
        {
            fHome.Instance.PictureBoxLogo.Enabled = false;

        }

        private void dataGridViewContent_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                index = e.RowIndex;
                textBoxMaGV.Text = dataGridViewContent.Rows[index].Cells[1].Value.ToString();
                textBoxHoten.Text = dataGridViewContent.Rows[index].Cells[2].Value.ToString();
                comboBoxGioiTinh.Text = dataGridViewContent.Rows[index].Cells[3].Value.ToString();
                comboBoxTrinhDo.Text = dataGridViewContent.Rows[index].Cells[4].Value.ToString();
                string dateStringgv = dataGridViewContent.Rows[index].Cells[5].Value.ToString();
                if (DateTime.TryParseExact(dateStringgv, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime svparsedDate))
                {
                    // Chuyển đổi DateTime sang chuỗi theo định dạng mới
                    string newDateString = svparsedDate.ToString("MM/dd/yyyy");
                    TimePickerNgaySinh.Value = DateTime.ParseExact(newDateString, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                }
                textBoxDiaChi.Text = dataGridViewContent.Rows[index].Cells[6].Value.ToString();
                textBoxSoCCCD.Text = dataGridViewContent.Rows[index].Cells[7].Value.ToString();
                textBoxSDT.Text = dataGridViewContent.Rows[index].Cells[8].Value.ToString();
                string tenkhoa = BUSFaculty.Instance.GetNameByID(dataGridViewContent.Rows[index].Cells[9].Value.ToString());
                comboBoxKhoa.Text = tenkhoa;
            }
        }
        Color color;

        private void dataGridViewContent_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                dataGridViewContent.Rows[e.RowIndex].DefaultCellStyle.BackColor = color;
            }
        }

        private void dataGridViewContent_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                color = dataGridViewContent.Rows[e.RowIndex].DefaultCellStyle.BackColor;
                dataGridViewContent.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightSkyBlue;

            }
        }
    }
}
