using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace GUI
{
    public partial class fLichHoc : Form
    {
        private static fLichHoc _instance;
        public static fLichHoc Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new fLichHoc();
                }
                return _instance;
            }
        }

        public fLichHoc()
        {
            InitializeComponent();
            LoadTuanHoc();
            LoadAllClass();
            LoadGiangVien();
            LoadAllHocPhan();
            LoadAllPhongHoc();
            LoadScheduleByWeekandClass();
        }

        public string type = fSignIn.accountType;
        public string username = fSignIn.userNameLogin;



        public void LoadTuanHoc()
        {
            List<string> Tuan = new List<string>();
            for (int i = 1; i < 50; i++)
            {
                Tuan.Add("Tuần " + i);
            }
            comboBoxTuan.DataSource = Tuan;
            comboBoxTuanSearch.DataSource = Tuan;
        }

        public void LoadAllClass()
        {
            BUSClass.Instance.GetAllLopHoc(comboBoxLop);
            BUSClass.Instance.GetAllLopHoc(comboBoxSearchClass);
        }
        public void LoadGiangVien()
        {
            //string tenHP = comboBoxHocPhan.SelectedItem.ToString();
            //string maHP = BUSSubject.Instance.GetIDByName(tenHP);
            //BUSSchedule.Instance.GetLectureBySubject(comboBoxGiangVien, maHP);
        }
        public void LoadAllHocPhan()
        {
            BUSSubject.Instance.GetAllSubject(comboBoxHocPhan);
        }
        public void LoadAllPhongHoc()
        {
            BUSSchedule.Instance.GetAllPhongHoc(comboBoxPhong);
        }

        public void LoadScheduleByWeekandClass()
        {
            int week;
            string Class;
            if (type.ToLower() == "user")
            {
                comboBoxSearchClass.Enabled = false;
                string input = comboBoxTuanSearch.Text;
                if (comboBoxTuanSearch.SelectedIndex != -1)
                {
                    input = comboBoxTuanSearch.SelectedItem.ToString();
                }
                Match match = Regex.Match(input, @"\d+");

                week = int.Parse(match.Value);

                Class = BUSStudent.Instance.GetMalopByMaSV(username);
                comboBoxSearchClass.Text = Class;

            }
            else
            {
                string input = comboBoxTuanSearch.Text;
                if (comboBoxTuanSearch.SelectedIndex != -1)
                {
                    input = comboBoxTuanSearch.SelectedItem.ToString();
                }
                Match match = Regex.Match(input, @"\d+");

                week = int.Parse(match.Value);

                Class = comboBoxSearchClass.Text;
                if (comboBoxSearchClass.SelectedIndex != -1)
                {
                    Class = comboBoxSearchClass.SelectedItem.ToString();
                }

            }

            BUSSchedule.Instance.GetScheduleByWeekandClass(week, Class, dataGridViewContent);
            //dataGridViewContent.DataBindingComplete += (sender, e) =>
            //{
            //    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            //    column.HeaderText = "STT";
            //    dataGridViewContent.Columns.Insert(0, column);

            //    for (int i = 0; i < dataGridViewContent.Rows.Count; i++)
            //    {
            //        dataGridViewContent.Rows[i].Cells[0].Value = (i + 1).ToString();
            //    }
            //};
            foreach (DataGridViewColumn column in dataGridViewContent.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dataGridViewContent.Columns["ID"].Visible = false;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (type.ToLower() == "user")
            {
                MessageBox.Show("Tài Khoản Cùa Bạn Không Thể Sử Dụng Chức Năng Này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string maLop = comboBoxLop.Text;
                if (comboBoxLop.SelectedIndex != -1)
                {
                    maLop = comboBoxLop.SelectedItem.ToString();

                }
                string tenHocPhan = comboBoxHocPhan.Text;
                if (comboBoxHocPhan.SelectedIndex != -1)
                {
                    tenHocPhan = comboBoxHocPhan.SelectedItem.ToString();

                }
                string tenGiangVien = comboBoxGiangVien.Text;
                if (comboBoxGiangVien.SelectedIndex != -1)
                {
                    tenGiangVien = comboBoxGiangVien.SelectedItem.ToString();

                }

                string phongHoc = comboBoxPhong.Text;
                if (comboBoxPhong.SelectedIndex != -1)
                {
                    phongHoc = comboBoxPhong.SelectedItem.ToString();

                }

                int thu = Convert(comboBoxThu.Text);
                if (comboBoxThu.SelectedIndex != -1)
                {
                    thu = Convert(comboBoxThu.SelectedItem.ToString());

                }

                int tuan = Convert(comboBoxTuan.Text);
                if (comboBoxTuan.SelectedIndex != -1)
                {
                    tuan = Convert(comboBoxTuan.SelectedItem.ToString());

                }
                string tietBatDau = comboBoxTietBD.Text;
                if (comboBoxTietBD.SelectedIndex != -1)
                {
                    tietBatDau = comboBoxTietBD.SelectedItem.ToString();

                }
                string soTiet = comboBoxTiet.Text;
                if (comboBoxTiet.SelectedIndex != -1)
                {
                    soTiet = comboBoxTiet.SelectedItem.ToString();

                }


                string maHP = BUSSubject.Instance.GetIDByName(tenHocPhan);
                string maGV = BUSLecturer.Instance.GetIDByName(tenGiangVien);
                int tietBD = Convert(tietBatDau);
                int sotiet = Convert(soTiet);

                string message = BUSSchedule.Instance.InsertLichHoc(thu, tuan, tietBD, sotiet, phongHoc, maLop, maHP, maGV);
                if (message == "")
                {
                    MessageBox.Show("Thêm Lịch Học Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadScheduleByWeekandClass();
                }
                else
                {
                    MessageBox.Show($"Thất Bại. {message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }

        }

        private void comboBoxSearchClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type.ToLower() == "user")
            {
                comboBoxTuanSearch.Enabled = true;

            }
            string Class = comboBoxSearchClass.Text;
            if (comboBoxSearchClass.SelectedIndex != -1)
            {
                Class = comboBoxSearchClass.SelectedItem.ToString();
            }
            comboBoxTuanSearch.Enabled = true;

            BUSSchedule.Instance.GetScheduleByClass(Class, dataGridViewContent);
            //dataGridViewContent.Columns.RemoveAt(1);
            foreach (DataGridViewColumn column in dataGridViewContent.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dataGridViewContent.Columns["ID"].Visible = false;




        }

        private void comboBoxTuanSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            int week;
            string Class;
            if (type.ToLower() == "user")
            {
                string input = comboBoxTuanSearch.Text;
                week = Convert(input);
                if(BUSStudent.Instance.GetMalopByMaSV(username) == "")
                {
                    MessageBox.Show("Bạn Hiện Không Thuộc Bất Kỳ Lớp Nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                Class = BUSStudent.Instance.GetMalopByMaSV(username);
            }
            else
            {
                string input = comboBoxTuanSearch.Text;
                week = Convert(input);
                Class = comboBoxSearchClass.Text;
            }
            BUSSchedule.Instance.GetScheduleByWeekandClass(week, Class, dataGridViewContent);
            //dataGridViewContent.Columns.RemoveAt(1);



        }

        public int Convert(string str)
        {
            Match match = Regex.Match(str, @"\d+");
            return int.Parse(match.Value);
        }

        private void dataGridViewContent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public int GetTietKT(string tietHoc)
        {
            Match match = Regex.Match(tietHoc, @"(?<=\-)\d+$");
            return int.Parse(match.Value);
        }

        public int GettietBD(string tietHoc)
        {
            Match match = Regex.Match(tietHoc, @"^\d+");

            return int.Parse(match.Value);
        }

        private void comboBoxHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenHP = comboBoxHocPhan.SelectedItem.ToString();
            string maHP = BUSSubject.Instance.GetIDByName(tenHP);
            BUSSchedule.Instance.GetLectureBySubject(comboBoxGiangVien, maHP);
        }

        private void comboBoxGiangVien_SelectedIndexChanged(object sender, EventArgs e)
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
                int id = int.Parse(labelID.Text);
                DialogResult result = MessageBox.Show($"Bạn Có Chắc Chắn Muốn Xóa Lịch Học Này Không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int change = BUSSchedule.Instance.DeleteSchedule(id);

                    if (change > 0)
                    {
                        MessageBox.Show($"Xóa Lịch Học Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadScheduleByWeekandClass();
                    }
                    else
                    {
                        MessageBox.Show($"Thất Bại. Xóa Lịch Học Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                string maLop = comboBoxLop.Text;
                if (comboBoxLop.SelectedIndex != -1)
                {
                    maLop = comboBoxLop.SelectedItem.ToString();

                }
                string tenHocPhan = comboBoxHocPhan.Text;
                if (comboBoxHocPhan.SelectedIndex != -1)
                {
                    tenHocPhan = comboBoxHocPhan.SelectedItem.ToString();

                }
                string tenGiangVien = comboBoxGiangVien.Text;
                if (comboBoxGiangVien.SelectedIndex != -1)
                {
                    tenGiangVien = comboBoxGiangVien.SelectedItem.ToString();

                }

                string phongHoc = comboBoxPhong.Text;
                if (comboBoxPhong.SelectedIndex != -1)
                {
                    phongHoc = comboBoxPhong.SelectedItem.ToString();

                }

                int thu = Convert(comboBoxThu.Text);
                if (comboBoxThu.SelectedIndex != -1)
                {
                    thu = Convert(comboBoxThu.SelectedItem.ToString());

                }

                int tuan = Convert(comboBoxTuan.Text);
                if (comboBoxTuan.SelectedIndex != -1)
                {
                    tuan = Convert(comboBoxTuan.SelectedItem.ToString());

                }
                string tietBatDau = comboBoxTietBD.Text;
                if (comboBoxTietBD.SelectedIndex != -1)
                {
                    tietBatDau = comboBoxTietBD.SelectedItem.ToString();

                }
                string soTiet = comboBoxTiet.Text;
                if (comboBoxTiet.SelectedIndex != -1)
                {
                    soTiet = comboBoxTiet.SelectedItem.ToString();

                }

                int id = int.Parse(labelID.Text);


                string maHP = BUSSubject.Instance.GetIDByName(tenHocPhan);
                string maGV = BUSLecturer.Instance.GetIDByName(tenGiangVien);
                int tietBD = Convert(tietBatDau);
                int sotiet = Convert(soTiet);

                string message = BUSSchedule.Instance.UpdateLichHoc(thu, tuan, tietBD, sotiet, phongHoc, maLop, maHP, maGV, id);
                if (message == "")
                {
                    MessageBox.Show("Cập Nhật Lịch Học Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadScheduleByWeekandClass();
                }
                else
                {
                    MessageBox.Show($"Thất Bại. {message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void labelID_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxTuan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewContent_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                comboBoxThu.Text = "Thứ " + dataGridViewContent.Rows[e.RowIndex].Cells[0].Value.ToString();
                comboBoxTuan.Text = "Tuần " + dataGridViewContent.Rows[e.RowIndex].Cells[1].Value.ToString();

                string tietHoc = dataGridViewContent.Rows[e.RowIndex].Cells[2].Value.ToString();
                comboBoxTietBD.Text = "Tiết " + GettietBD(tietHoc).ToString();
                comboBoxTiet.Text = (GetTietKT(tietHoc) - GettietBD(tietHoc) + 1).ToString() + " tiết";

                comboBoxPhong.Text = dataGridViewContent.Rows[e.RowIndex].Cells[3].Value.ToString();
                comboBoxLop.Text = dataGridViewContent.Rows[e.RowIndex].Cells[4].Value.ToString();
                comboBoxHocPhan.Text = dataGridViewContent.Rows[e.RowIndex].Cells[5].Value.ToString();
                comboBoxGiangVien.Text = dataGridViewContent.Rows[e.RowIndex].Cells[6].Value.ToString();
                labelID.Text = dataGridViewContent.Rows[e.RowIndex].Cells[8].Value.ToString();
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
