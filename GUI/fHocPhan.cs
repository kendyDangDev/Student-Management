using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace GUI
{
    public partial class fHocPhan : Form
    {
        public fHocPhan()
        {
            InitializeComponent();
            LoadAllHocPhan();
            LoadAllFaculty();
        }
        public string type = fSignIn.accountType;
        void LoadAllFaculty()
        {
            BUSFaculty.Instance.GetFacultyName(comboBoxKhoa);
        }
        void LoadAllHocPhan()
        {
            BUSSubject.Instance.GetAllHocPhan(dataGridViewContent);
            BUSSubject.Instance.GetAllSubject(comboBoxValue);
            dataGridViewContent.DataBindingComplete += (sender, e) =>
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.HeaderText = "STT";
                dataGridViewContent.Columns.Insert(0, column);

                for (int i = 0; i < dataGridViewContent.Rows.Count; i++)
                {
                    dataGridViewContent.Rows[i].Cells[0].Value = (i + 1).ToString();
                }
                dataGridViewContent.Columns.RemoveAt(1);

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
                MessageBox.Show("Tài Khoản Cùa Bạn Không Thể Sử Dụng Chức Năng Này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string mahp = textBoxMaHp.Text;
                string tenhp = textBoxTenHp.Text;
                string loaiHP = comboBoxLoaiHP.Text;
                if (comboBoxLoaiHP.SelectedIndex != -1)
                {
                    loaiHP = comboBoxLoaiHP.SelectedItem.ToString();

                }
                string tenKhoa = comboBoxKhoa.Text;
                if (comboBoxKhoa.SelectedIndex != -1)
                {
                    tenKhoa = comboBoxKhoa.SelectedItem.ToString();

                }
                if (string.IsNullOrEmpty(mahp) || string.IsNullOrEmpty(tenhp) || string.IsNullOrEmpty(loaiHP) || string.IsNullOrEmpty(tenKhoa))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    string maKhoa = BUSFaculty.Instance.GetIDByName(tenKhoa);
                    if (string.IsNullOrEmpty(numericUpDownSoTC.Text) || numericUpDownSoTC.Value == 0)
                    {
                        MessageBox.Show("Số Tín Chỉ Không Hợp Lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        int sotc = (int)numericUpDownSoTC.Value;
                        string message = BUSSubject.Instance.InsertSubject(mahp, tenhp, sotc, loaiHP, maKhoa);
                        if (message == "")
                        {
                            MessageBox.Show($"Thêm Học Phần Có Mã {mahp} Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAllHocPhan();
                        }
                        else
                        {
                            MessageBox.Show($"Thất Bại. {message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                }
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (type.ToLower() == "user")
            {
                MessageBox.Show("Tài Khoản Cùa Bạn Không Thể Sử Dụng Chức Năng Này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string mahp = textBoxMaHp.Text;
                string tenhp = textBoxTenHp.Text;
                string loaiHP = comboBoxLoaiHP.Text;
                if (comboBoxLoaiHP.SelectedIndex != -1)
                {
                    loaiHP = comboBoxLoaiHP.SelectedItem.ToString();

                }
                string tenKhoa = comboBoxKhoa.Text;
                if (comboBoxKhoa.SelectedIndex != -1)
                {
                    tenKhoa = comboBoxKhoa.SelectedItem.ToString();

                }

                if (string.IsNullOrEmpty(mahp) || string.IsNullOrEmpty(tenhp) || string.IsNullOrEmpty(loaiHP) || string.IsNullOrEmpty(tenKhoa))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //lấy mã khoa
                    string maKhoa = BUSFaculty.Instance.GetIDByName(tenKhoa);
                    if (string.IsNullOrEmpty(numericUpDownSoTC.Text) || numericUpDownSoTC.Value == 0)
                    {
                        MessageBox.Show("Số Tín Chỉ Không Hợp Lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        int sotc = (int)numericUpDownSoTC.Value;
                        string message = BUSSubject.Instance.UpdateSubject(mahp, tenhp, sotc, loaiHP, maKhoa);
                        if (message == "")
                        {
                            MessageBox.Show($"Cập Nhật Thông Tin Học Phần Có Mã {mahp} Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAllHocPhan();
                        }
                        else
                        {
                            MessageBox.Show($"Thất Bại. {message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                }
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            if (type.ToLower() == "user")
            {
                MessageBox.Show("Tài Khoản Cùa Bạn Không Thể Sử Dụng Chức Năng Này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                DialogResult result = MessageBox.Show($"Bạn Có Chắc Chắn Muốn Xóa Học Phần Có Mã: {textBoxMaHp.Text}", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (BUSSubject.Instance.DeleteSubject(textBoxMaHp.Text) > 0)
                    {
                        MessageBox.Show($"Xóa Thành Công Học Phần Có Mã: {textBoxMaHp.Text}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllHocPhan();
                    }
                    else
                    {
                        MessageBox.Show($"Thất Bại. Không Tồn Tại Học Phần Có Mã: {textBoxMaHp.Text}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
        }

        private void dataGridViewContent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string columnsearch = comboBoxColumn.Text;
            if (comboBoxColumn.SelectedIndex != -1)
            {
                columnsearch = comboBoxColumn.SelectedItem.ToString();
              
            }

            string valueSearch = comboBoxValue.Text;
            if (comboBoxValue.SelectedIndex != -1)
            {
                valueSearch = comboBoxValue.SelectedItem.ToString();

            }

            if (string.IsNullOrEmpty(valueSearch))
            {
                MessageBox.Show("Nhập Giá Trị Cần Tìm Kiếm");
            }
            else
            {
                //Ok
                BUSSubject.Instance.FilterSubject(dataGridViewContent, columnsearch, valueSearch);
            }
        
                dataGridViewContent.Columns.RemoveAt(1);
        }

        private void comboBoxColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ColumnSearch = comboBoxColumn.Text;
            if(comboBoxColumn.SelectedIndex != -1)
            {
                 ColumnSearch = comboBoxColumn.SelectedItem.ToString();

            }
            switch (ColumnSearch)
            {
                case "Khoa":
                    BUSFaculty.Instance.GetFacultyName(comboBoxValue);
                    break;
                case "Học Phần":
                    BUSSubject.Instance.GetAllSubject(comboBoxValue);
                    break;
                case "Loại Học Phần":
                    List<string> value = new List<string> { "Tự Chọn", "Bắt Buộc" };
                    comboBoxValue.DataSource = value;
                    break;
                default:
                    comboBoxValue.Text = "";
                    comboBoxValue.DataSource = null;
                    break;
            }
        }

        private void fHocPhan_Load(object sender, EventArgs e)
        {
            fHome.Instance.PictureBoxLogo.Enabled = false;

        }

        private void dataGridViewContent_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                textBoxMaHp.Text = dataGridViewContent.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxTenHp.Text = dataGridViewContent.Rows[e.RowIndex].Cells[2].Value.ToString();
                numericUpDownSoTC.Text = dataGridViewContent.Rows[e.RowIndex].Cells[3].Value.ToString();
                comboBoxLoaiHP.Text = dataGridViewContent.Rows[e.RowIndex].Cells[5].Value.ToString();
                comboBoxKhoa.Text = dataGridViewContent.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }
        Color color;
        private void dataGridViewContent_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Đổi màu chữ của hàng khi di chuột ra
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
