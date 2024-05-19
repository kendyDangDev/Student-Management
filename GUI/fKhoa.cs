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
    public partial class fKhoa : Form
    {
        public fKhoa()
        {
            InitializeComponent();
            LoadAllFaculty();
        }
        public string type = fSignIn.accountType;
        public void LoadAllFaculty()
        {
            BUSFaculty.Instance.GetAllFaculty(dataGridViewContent);
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
                string maKhoa = textBoxMaKhoa.Text;
                string tenKhoa = textBoxTenKhoa.Text;
                string sDT = textBoxSDT.Text;
                string email = textBoxEmail.Text;

                if (string.IsNullOrEmpty(maKhoa) || string.IsNullOrEmpty(tenKhoa) || string.IsNullOrEmpty(sDT) || string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string message = BUSFaculty.Instance.InsertFaculty(maKhoa, tenKhoa, sDT, email);
                    if (message == "")
                    {
                        MessageBox.Show("Thêm Khoa Mới Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllFaculty();
                    }
                    else
                    {
                        MessageBox.Show($"Thất Bại. {message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                string maKhoa = textBoxMaKhoa.Text;
                string tenKhoa = textBoxTenKhoa.Text;
                string sDT = textBoxSDT.Text;
                string email = textBoxEmail.Text;

                if (string.IsNullOrEmpty(maKhoa) || string.IsNullOrEmpty(tenKhoa) || string.IsNullOrEmpty(sDT) || string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string message = BUSFaculty.Instance.UpdateFaculty(maKhoa, tenKhoa, sDT, email);
                    if (message == "")
                    {
                        MessageBox.Show("Cập Nhật Thông Tin Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllFaculty();
                    }
                    else
                    {
                        MessageBox.Show($"Thất Bại. {message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                DialogResult result = MessageBox.Show($"Bạn Có Chắc Chắn Muốn Xóa Khoa Có Mã: {textBoxMaKhoa.Text}", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string message = BUSFaculty.Instance.DeleteFaculty(textBoxMaKhoa.Text);
                    if (message == "")
                    {
                        MessageBox.Show($"Xóa Thành Công Khoa Có Mã: {textBoxMaKhoa.Text}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllFaculty();
                    }
                    else
                    {
                        MessageBox.Show($"Thất Bại. {message}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
        }

        private void comboBoxColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxValue.Text = "";
        }

        private void dataGridViewContent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string columnsearch = comboBoxColumn.Text;
            string valueSearch = "";
            if (comboBoxColumn.SelectedIndex != -1)
            {
                columnsearch = comboBoxColumn.Text;
                valueSearch = comboBoxValue.Text;
            }
            if (string.IsNullOrEmpty(valueSearch))
            {
                MessageBox.Show("Nhập Giá Trị Cần Tìm Kiếm");
            }
            else
            {
                //Ok
                BUSFaculty.Instance.FilterFaculty(dataGridViewContent, columnsearch, valueSearch);
            }
            dataGridViewContent.Columns.RemoveAt(1);

        }

        private void fKhoa_Load(object sender, EventArgs e)
        {
            fHome.Instance.PictureBoxLogo.Enabled = false;

        }

        private void dataGridViewContent_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                textBoxMaKhoa.Text = dataGridViewContent.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxTenKhoa.Text = dataGridViewContent.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxSDT.Text = dataGridViewContent.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBoxEmail.Text = dataGridViewContent.Rows[e.RowIndex].Cells[4].Value.ToString();
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
                // Đổi màu chữ của hàng khi di chuột ra
                dataGridViewContent.Rows[e.RowIndex].DefaultCellStyle.BackColor = color;
            }
        }
    }
}
