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

namespace GUI
{
    public partial class fNganhHoc : Form
    {
        private static fNganhHoc _instance;
        public static fNganhHoc Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new fNganhHoc();
                }
                return _instance;
            }
        }
        public fNganhHoc()
        {
            InitializeComponent();
            LoadAllMajor();
            LoadAllFaculty();
        }
        public string type = fSignIn.accountType;
        void LoadAllMajor()
        {
            BUSMajor.Instance.GetAllMajor(dataGridViewContent);
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
        void LoadAllFaculty()
        {
            BUSFaculty.Instance.GetFacultyName(comboBoxKhoa);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (type.ToLower() == "user")
            {
                MessageBox.Show("Tài Khoản Cùa Bạn Không Thể Sử Dụng Chức Năng Này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string maNganh = textBoxMaNganh.Text;
                string tenNganh = textBoxTenNganh.Text;
                string tenKhoa = comboBoxKhoa.Text;
                if (comboBoxKhoa.SelectedIndex != -1)
                {
                    tenKhoa = comboBoxKhoa.SelectedItem.ToString();

                }

                if (string.IsNullOrEmpty(maNganh) || string.IsNullOrEmpty(tenNganh) || string.IsNullOrEmpty(tenKhoa))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string maKhoa = BUSFaculty.Instance.GetIDByName(tenKhoa);
                    string message = BUSMajor.Instance.InsertMajor(maNganh, tenNganh, maKhoa);
                    if (message == "")
                    {
                        MessageBox.Show("Thêm Ngành Mới Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllMajor();
                        dataGridViewContent.Columns.RemoveAt(1);

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
                string maNganh = textBoxMaNganh.Text;
                string tenNganh = textBoxTenNganh.Text;
                string tenKhoa = comboBoxKhoa.Text;
                if (comboBoxKhoa.SelectedIndex != -1)
                {
                    tenKhoa = comboBoxKhoa.SelectedItem.ToString();

                }

                if (string.IsNullOrEmpty(maNganh) || string.IsNullOrEmpty(tenNganh) || string.IsNullOrEmpty(tenKhoa))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string maKhoa = BUSFaculty.Instance.GetIDByName(tenKhoa);
                    string message = BUSMajor.Instance.UpdateMajor(maNganh, tenNganh, maKhoa);
                    if (message == "")
                    {
                        MessageBox.Show("Cập Nhật Thông Tin Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadAllMajor();
                        dataGridViewContent.Columns.RemoveAt(1);

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
                DialogResult result = MessageBox.Show($"Bạn Có Chắc Chắn Muốn Xóa Ngành Có Mã: {textBoxMaNganh.Text}", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (BUSMajor.Instance.DeleteMajor(textBoxMaNganh.Text) > 0)
                    {
                        MessageBox.Show($"Xóa Thành Công Ngành Có Mã: {textBoxMaNganh.Text}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllMajor();
                        dataGridViewContent.Columns.RemoveAt(1);

                    }
                    else
                    {
                        MessageBox.Show($"Thất Bại. Không Tồn Tại Ngành Có Mã: {textBoxMaNganh.Text}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
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

                BUSMajor.Instance.FilterMajor(dataGridViewContent, columnsearch, valueSearch);
            }
        }

        private void dataGridViewContent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMaNganh.Text = dataGridViewContent.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxTenNganh.Text = dataGridViewContent.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxKhoa.Text = dataGridViewContent.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void comboBoxColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ColumnSearch = comboBoxColumn.SelectedItem.ToString();
            switch (ColumnSearch)
            {
                case "Khoa":
                    BUSFaculty.Instance.GetFacultyName(comboBoxValue);
                    break;
                default:
                    comboBoxValue.Text = "";
                    comboBoxValue.DataSource = null;
                    break;
            }
        }

        private void fNganhHoc_Load(object sender, EventArgs e)
        {
            fHome.Instance.PictureBoxLogo.Enabled = false;

        }

        private void dataGridViewContent_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                textBoxMaNganh.Text = dataGridViewContent.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxTenNganh.Text = dataGridViewContent.Rows[e.RowIndex].Cells[2].Value.ToString();
                comboBoxKhoa.Text = dataGridViewContent.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void dataGridViewContent_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


        }

        private void dataGridViewContent_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

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
