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
    public partial class fLopHoc : Form
    {
        private static fLopHoc _instance;
        public static fLopHoc Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new fLopHoc();
                }
                return _instance;
            }
        }

        public fLopHoc()
        {
            InitializeComponent();
            LoadAllSpecialty();
            LoadAllClass();
            LoadNameGiangVien();

        }
        public string type = fSignIn.accountType;

        void LoadAllSpecialty()
        {
            BUSSpecialty.Instance.GetAllSpecialtyName(comboBoxSpecialty);
            BUSSpecialty.Instance.GetAllSpecialtyName(comboBoxValue);
        }
        void LoadAllClass()
        {
            BUSClass.Instance.GetAllClass(dataGridViewContent);
            dataGridViewContent.DataBindingComplete += (sender, e) =>
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.HeaderText = "STT";
                dataGridViewContent.Columns.Insert(0, column);

                for (int i = 0; i < dataGridViewContent.Rows.Count; i++)
                {
                    dataGridViewContent.Rows[i].Cells[0].Value = (i + 1).ToString();
                }

            };
            foreach (DataGridViewColumn column in dataGridViewContent.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        void LoadNameGiangVien()
        {
            BUSLecturer.Instance.GetNameGiangVien(comboBoxGVCN);
        }
        private void comboBoxColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ColumnSearch = comboBoxColumn.SelectedItem.ToString();
            switch (ColumnSearch)
            {

                case "Chuyên Ngành":
                    BUSSpecialty.Instance.GetAllSpecialtyName(comboBoxValue);
                    break;
                case "Hệ Đào Tạo":
                    List<string> value = new List<string> { "Chính Quy", "Từ Xa" };
                    comboBoxValue.DataSource = value;
                    break;
                default:
                    comboBoxValue.Text = "";
                    comboBoxValue.DataSource = null;
                    break;
            }
        }

        string ConvertNameToID(ComboBox cbx)
        {
            string result = cbx.Text;
            if (cbx.SelectedIndex != -1)
            {
                result = cbx.SelectedItem.ToString();
            }
            string ID = BUSClass.Instance.GetIDByName(result);
            return ID;

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (type.ToLower() == "user")
            {
                MessageBox.Show("Tài Khoản Cùa Bạn Không Thể Sử Dụng Chức Năng Này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string maLop = textBoxMaLop.Text;
                string tenLop = textBoxTenLop.Text;
                string tenchuyennganh = comboBoxSpecialty.Text;
                if (comboBoxSpecialty.SelectedIndex != -1)
                {
                    tenchuyennganh = comboBoxSpecialty.SelectedItem.ToString();
                }
                string hedaotao = comboBoxHDT.Text;
                if (comboBoxHDT.SelectedIndex != -1)
                {
                    hedaotao = comboBoxHDT.SelectedItem.ToString();
                }
                string tenGVCN = comboBoxGVCN.Text;
                if (comboBoxGVCN.SelectedIndex != -1)
                {
                    tenGVCN = comboBoxGVCN.SelectedItem.ToString();
                }

                string maChuyenNganh = BUSSpecialty.Instance.GetIDByName(tenchuyennganh);
                string maGV = BUSLecturer.Instance.GetIDByName(tenGVCN);

                if (string.IsNullOrEmpty(maLop) || string.IsNullOrEmpty(tenLop) || string.IsNullOrEmpty(tenchuyennganh)
                    || string.IsNullOrEmpty(hedaotao) || string.IsNullOrEmpty(tenGVCN))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    string message = BUSClass.Instance.InsertClass(maLop, tenLop, hedaotao, maGV, maChuyenNganh);
                    if (message == "")
                    {
                        MessageBox.Show("Thêm Lớp Mới Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllClass();
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
                string maLop = textBoxMaLop.Text;
                string tenLop = textBoxTenLop.Text;

                string hedaotao = comboBoxHDT.Text;
                if (comboBoxHDT.SelectedIndex != -1)
                {
                    hedaotao = comboBoxHDT.SelectedItem.ToString();
                }

                string tenchuyennganh = comboBoxSpecialty.Text;
                if (comboBoxSpecialty.SelectedIndex != -1)
                {
                    tenchuyennganh = comboBoxSpecialty.SelectedItem.ToString();
                }

                string tenGVCN = comboBoxGVCN.Text;
                if (comboBoxGVCN.SelectedIndex != -1)
                {
                    tenGVCN = comboBoxGVCN.SelectedItem.ToString();
                }

                if (string.IsNullOrEmpty(maLop) || string.IsNullOrEmpty(tenLop) || string.IsNullOrEmpty(tenchuyennganh)
                     || string.IsNullOrEmpty(hedaotao) || string.IsNullOrEmpty(tenGVCN))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    string maChuyenNganh = BUSSpecialty.Instance.GetIDByName(tenchuyennganh);
                    string maGV = BUSLecturer.Instance.GetIDByName(tenGVCN);

                    string message = BUSClass.Instance.UpdateClass(maLop, tenLop, hedaotao, maGV, maChuyenNganh);
                    if (message == "")
                    {
                        MessageBox.Show("Cập Nhật Thông Tin Lớp Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllClass();
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
                DialogResult result = MessageBox.Show($"Bạn Có Chắc Chắn Muốn Xóa Lớp Có Mã: {textBoxMaLop.Text}", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (BUSClass.Instance.DeleteClass(textBoxMaLop.Text) > 0)
                    {
                        MessageBox.Show($"Xóa Thành Công Lớp Có Mã: {textBoxMaLop.Text}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllClass();
                    }
                    else
                    {
                        MessageBox.Show($"Thất Bại. Không Tồn Tại Lớp Có Mã: {textBoxMaLop.Text}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                BUSClass.Instance.FilterClass(dataGridViewContent, columnsearch, valueSearch);
            }
            dataGridViewContent.Columns.RemoveAt(1);

        }

        private void fLopHoc_Load(object sender, EventArgs e)
        {
            fHome.Instance.PictureBoxLogo.Enabled = false;

        }

        private void dataGridViewContent_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                textBoxMaLop.Text = dataGridViewContent.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxTenLop.Text = dataGridViewContent.Rows[e.RowIndex].Cells[2].Value.ToString();
                comboBoxGVCN.Text = dataGridViewContent.Rows[e.RowIndex].Cells[3].Value.ToString();
                comboBoxSpecialty.Text = dataGridViewContent.Rows[e.RowIndex].Cells[7].Value.ToString();
                comboBoxHDT.Text = dataGridViewContent.Rows[e.RowIndex].Cells[5].Value.ToString();
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
