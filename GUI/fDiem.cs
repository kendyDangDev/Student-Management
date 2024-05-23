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
    public partial class fDiem : Form
    {
        private static fDiem _instance;
        public static fDiem Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new fDiem();
                }
                return _instance;
            }
        }
        public fDiem()
        {
            InitializeComponent();
            LoadAllSubject();
            LoadAllScore();
            LoadAllClass();
        }
        public string type = fSignIn.accountType;
        public string username = fSignIn.userNameLogin;

        public void LoadAllClass()
        {
            BUSClass.Instance.GetAllLopHoc(comboBoxLop);
        }
        public int LoadStudentsByClass()
        {
            string malop = comboBoxLop.Text;
            if (comboBoxLop.SelectedIndex != -1)
            {
                malop = comboBoxLop.SelectedItem.ToString();
            }
            return BUSStudent.Instance.GetNameStudentbyClass(comboBoxSinhVien, malop);
        }

        void LoadAllSubject()
        {
            BUSSubject.Instance.GetAllSubject(comboBoxMonHoc);
            BUSSubject.Instance.GetAllSubject(comboBoxValueSearch);
        }
        void LoadAllScore()
        {
            if (type.ToLower() == "user")
            {
                BUSScore.Instance.GetScoreBymaSV(dataGridViewContent, username);
            }
            else
            {
                BUSScore.Instance.GetAllScore(dataGridViewContent);

            }
            //BUSScore.Instance.GetScoreBymaSV(dataGridViewContent, username);


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

        string GetSubjectIDByName(ComboBox cbx)
        {
            string result = cbx.Text;
            if (cbx.SelectedIndex != -1)
            {
                result = cbx.SelectedItem.ToString();
            }
            string ID = BUSSubject.Instance.GetIDByName(result);
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
                string tenSinhVien = comboBoxSinhVien.Text;
                if (comboBoxSinhVien.SelectedIndex != -1)
                {
                    tenSinhVien = comboBoxSinhVien.SelectedItem.ToString();
                }
                string diemGHP = textBoxGHP.Text;
                string diemKTHP = textBoxKTHP.Text;
                string tenHocPhan = comboBoxMonHoc.Text;
                if (comboBoxMonHoc.SelectedIndex != -1)
                {
                    tenHocPhan = comboBoxMonHoc.SelectedItem.ToString();
                }
                string maHocPhan = BUSSubject.Instance.GetIDByName(tenHocPhan);

                if (!string.IsNullOrEmpty(tenSinhVien) && !string.IsNullOrEmpty(diemGHP) && !string.IsNullOrEmpty(diemKTHP) && !string.IsNullOrEmpty(tenHocPhan))
                {

                    string maSV = BUSStudent.Instance.GetIDByName(tenSinhVien);
                    string message = BUSScore.Instance.InsertScore(diemGHP, diemKTHP, maSV, maHocPhan);
                    if (message == "")
                    {
                        MessageBox.Show($"Nhập Điểm Cho Sinh Viên {tenSinhVien} Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BUSScore.Instance.GetAllScore(dataGridViewContent);
                    }
                    else
                    {
                        MessageBox.Show($"Thất Bại. {message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                string tenSinhVien = comboBoxSinhVien.Text;
                if (comboBoxSinhVien.SelectedIndex != -1)
                {
                    tenSinhVien = comboBoxSinhVien.SelectedItem.ToString();
                }
                string diemGHP = textBoxGHP.Text;
                string diemKTHP = textBoxKTHP.Text;
                string tenHocPhan = comboBoxMonHoc.Text;
                if (comboBoxMonHoc.SelectedIndex != -1)
                {
                    tenHocPhan = comboBoxMonHoc.SelectedItem.ToString();
                }

                if (!string.IsNullOrEmpty(tenSinhVien) && !string.IsNullOrEmpty(diemGHP) && !string.IsNullOrEmpty(diemKTHP) && !string.IsNullOrEmpty(tenHocPhan))
                {
                    string maHocPhan = BUSSubject.Instance.GetIDByName(tenHocPhan);
                    string maSV = BUSStudent.Instance.GetIDByName(tenSinhVien);
                    string message = BUSScore.Instance.UpdateScore(diemGHP, diemKTHP, maSV, maHocPhan);
                    if (message == "")
                    {
                        MessageBox.Show($"Cập Nhật Điểm Cho Sinh Viên {tenSinhVien} Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BUSScore.Instance.GetAllScore(dataGridViewContent);
                    }
                    else
                    {
                        MessageBox.Show($"Thất Bại. {message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }


                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                string tenSinhVien = comboBoxSinhVien.Text;
                if (comboBoxSinhVien.SelectedIndex != -1)
                {
                    tenSinhVien = comboBoxSinhVien.SelectedItem.ToString();
                }
                string maSV = BUSStudent.Instance.GetIDByName(tenSinhVien);
                DialogResult result = MessageBox.Show($"Bạn Có Chắc Chắn Muốn Xóa Điểm Môn Học: {comboBoxMonHoc.SelectedItem} Của Sinh Viên: {tenSinhVien} Có Mã: {maSV}", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (BUSScore.Instance.DeleteScore(GetSubjectIDByName(comboBoxMonHoc)) != 0)
                    {
                        MessageBox.Show($"Xóa Thành Công Điểm Môn Học: {comboBoxMonHoc.SelectedItem} Của Sinh Viên:  {tenSinhVien}  Có Mã:  {maSV}", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllScore();
                    }
                    else
                    {
                        MessageBox.Show($"Thất Bại. Sinh Viên Chưa Có Điểm Môn Học Này.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
        }

        private void dataGridViewContent_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string columnsearch = comboBoxSearch.Text;
            if (comboBoxSearch.SelectedIndex != -1)
            {
                columnsearch = comboBoxSearch.SelectedItem.ToString();

            }
            string valueSearch = comboBoxValueSearch.Text;
            if (comboBoxValueSearch.SelectedIndex != -1)
            {
                valueSearch = comboBoxValueSearch.SelectedItem.ToString();

            }
            if (string.IsNullOrEmpty(valueSearch))
            {
                MessageBox.Show("Nhập Giá Trị Cần Tìm Kiếm");
            }
            else
            {
                //Ok
                BUSScore.Instance.FilterScore(dataGridViewContent, columnsearch, valueSearch);
            }
            dataGridViewContent.Columns.RemoveAt(1);

        }

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

            string ColumnSearch = comboBoxSearch.SelectedItem.ToString();
            switch (ColumnSearch)
            {
                case "Lớp":
                    BUSClass.Instance.GetAllLopHoc(comboBoxValueSearch);

                    break;
                case "Mã SV":
                    comboBoxValueSearch.Text = "";
                    comboBoxValueSearch.DataSource = null;
                    break;
                case "Học Phần":
                    BUSSubject.Instance.GetAllSubject(comboBoxValueSearch);
                    break;
            }

        }

        private void ButtonSort_Click(object sender, EventArgs e)
        {
            string SortType = comboBoxSort.Text;
            if (comboBoxSort.SelectedIndex != -1)
            {
                SortType = comboBoxSort.SelectedItem.ToString();
                switch (SortType)
                {
                    case "Giảm Dần":
                        BUSScore.Instance.SortDESC(dataGridViewContent);
                        break;
                    case "Tăng Dần":
                        BUSScore.Instance.SortASC(dataGridViewContent);
                        break;
                }
            }
            dataGridViewContent.Columns.RemoveAt(1);

        }

        private void fDiem_Load(object sender, EventArgs e)
        {
            fHome.Instance.PictureBoxLogo.Enabled = false;

        }

        private void dataGridViewContent_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                comboBoxSinhVien.Text = dataGridViewContent.Rows[e.RowIndex].Cells[1].Value.ToString();
                comboBoxMonHoc.Text = dataGridViewContent.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBoxGHP.Text = dataGridViewContent.Rows[e.RowIndex].Cells[6].Value.ToString();
                textBoxKTHP.Text = dataGridViewContent.Rows[e.RowIndex].Cells[7].Value.ToString();

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

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LoadStudentsByClass() > 0)
            {
                LoadStudentsByClass();

            }
            else
            {
                comboBoxSinhVien.Text = "";
            }
        }
    }
}
