using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace GUI
{
    public partial class fChuyenNganh : Form
    {
        private static fChuyenNganh _instance;
        public static fChuyenNganh Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new fChuyenNganh();
                }
                return _instance;
            }
        }
        public fChuyenNganh()
        {
            InitializeComponent();
            LoadAllSpecialty();
        }

        void LoadAllSpecialty()
        {
            BUSSpecialty.Instance.GetAllSpecialty(dataGridViewContent);
            BUSMajor.Instance.GetAllMajorName(comboBoxNganh);
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

        public string type = fSignIn.accountType;
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (type.ToLower() == "user")
            {
                MessageBox.Show("Tài Khoản Cùa Bạn Không Thể Sử Dụng Chức Năng Này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string macn = textBoxMaCN.Text;
                string tencn = textBoxTenCN.Text;
                string thoigiandaotao = textBoxTGDT.Text;
                string tenNganh = comboBoxNganh.Text;
                if (comboBoxNganh.SelectedIndex != -1)
                {
                    tenNganh = comboBoxNganh.SelectedItem.ToString();

                }

                if (string.IsNullOrEmpty(macn) || string.IsNullOrEmpty(tencn) || string.IsNullOrEmpty(thoigiandaotao) || string.IsNullOrEmpty(tenNganh))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    string maNganh = BUSMajor.Instance.GetIDByName(tenNganh);
                    string message = BUSSpecialty.Instance.InsertSpecialty(macn, tencn, thoigiandaotao, maNganh);
                    if (message == "")
                    {
                        MessageBox.Show("Thêm Chuyên Ngành Mới Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllSpecialty();
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
                string macn = textBoxMaCN.Text;
                string tencn = textBoxTenCN.Text;
                string thoigiandaotao = textBoxTGDT.Text;
                string tenNganh = comboBoxNganh.Text;
                if (comboBoxNganh.SelectedIndex != -1)
                {
                    tenNganh = comboBoxNganh.SelectedItem.ToString();

                }
                if (string.IsNullOrEmpty(macn) || string.IsNullOrEmpty(tencn) || string.IsNullOrEmpty(thoigiandaotao) || string.IsNullOrEmpty(tenNganh))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    string maNganh = BUSMajor.Instance.GetIDByName(tenNganh);
                    string message = BUSSpecialty.Instance.UpdateSpecialty(macn, tencn, thoigiandaotao, maNganh);
                    if (message == "")
                    {
                        MessageBox.Show("Cập Nhật Thông Tin Chuyên Ngành Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllSpecialty();
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
                DialogResult result = MessageBox.Show($"Bạn Có Chắc Chắn Muốn Xóa Chuyên Ngành Có Mã: {textBoxMaCN.Text}", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (BUSSpecialty.Instance.DeleteSpecialty(textBoxMaCN.Text) > 0)
                    {
                        MessageBox.Show($"Xóa Thành Công Chuyên Ngành Có Mã: {textBoxMaCN.Text}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllSpecialty();
                    }
                    else
                    {
                        MessageBox.Show($"Thất Bại. Không Tồn Tại Chuyên Ngành Có Mã: {textBoxMaCN.Text}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
        }

        private void dataGridViewContent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMaCN.Text = dataGridViewContent.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxTenCN.Text = dataGridViewContent.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxTGDT.Text = dataGridViewContent.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBoxNganh.Text = dataGridViewContent.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ColumnSearch = comboBoxColumn.SelectedItem.ToString();
            switch (ColumnSearch)
            {
                case "Mã Chuyên Ngành":
                    comboBoxValue.Text = "";
                    comboBoxValue.DataSource = null;
                    break;
                case "Tên Chuyên Ngành":
                    comboBoxValue.Text = "";
                    comboBoxValue.DataSource = null;
                    break;
                case "Ngành":
                    BUSMajor.Instance.GetAllMajorName(comboBoxValue);
                    break;
                case "Khoa":
                    BUSFaculty.Instance.GetFacultyName(comboBoxValue);
                    break;
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string columnsearch = comboBoxColumn.Text;
            string valueSearch = "";
            if (comboBoxColumn.SelectedIndex != -1)
            {
                columnsearch = comboBoxColumn.SelectedItem.ToString();
                switch (columnsearch)
                {
                    case "Mã Chuyên Ngành":
                        columnsearch = "Mã Chuyên Ngành";
                        valueSearch = comboBoxValue.Text;
                        break;
                    case "Tên Chuyên Ngành":
                        columnsearch = "Tên Chuyên Ngành";
                        valueSearch = comboBoxValue.Text;
                        if (comboBoxValue.SelectedIndex != -1)
                        {
                            valueSearch = comboBoxValue.SelectedItem.ToString();
                        }
                        break;
                    case "Ngành":
                        columnsearch = "Ngành";
                        valueSearch = comboBoxValue.Text;
                        if (comboBoxValue.SelectedIndex != -1)
                        {
                            valueSearch = comboBoxValue.SelectedItem.ToString();
                        }
                        break;
                    case "Khoa":
                        columnsearch = "Khoa";
                        valueSearch = comboBoxValue.Text;
                        if (comboBoxValue.SelectedIndex != -1)
                        {
                            valueSearch = comboBoxValue.SelectedItem.ToString();
                        }
                        break;
                    default:
                        break;
                }
            }
            if (string.IsNullOrEmpty(valueSearch))
            {
                MessageBox.Show("Nhập Giá Trị Cần Tìm Kiếm");
            }
            else
            {
                //Ok
                BUSSpecialty.Instance.FilterSpecialty(dataGridViewContent, columnsearch, valueSearch);
            }
            dataGridViewContent.Columns.RemoveAt(1);

        }

        private void fChuyenNganh_Load(object sender, EventArgs e)
        {
            fHome.Instance.PictureBoxLogo.Enabled = false;
        }

        private void dataGridViewContent_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
            textBoxMaCN.Text = dataGridViewContent.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxTenCN.Text = dataGridViewContent.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxTGDT.Text = dataGridViewContent.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBoxNganh.Text = dataGridViewContent.Rows[e.RowIndex].Cells[4].Value.ToString();
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
