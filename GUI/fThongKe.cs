using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace GUI
{
    public partial class fThongKe : Form
    {
        private static fThongKe _instance;
        public static fThongKe Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new fThongKe();
                }
                return _instance;
            }
        }
        static string connectionString = @"Data Source=localhost;
                                                Initial Catalog=UTEHY
                                                ;User ID=sa;Password=Kendydang19082004";
        public fThongKe()
        {
            InitializeComponent();

            CreateChartScore(connectionString);
            LoadThongKe();
        }

        public async void LoadThongKe()
        {
            int StudentQuantity = int.Parse(BUSStudent.Instance.SelectCount().ToString());
            float LectureQuantity = int.Parse(BUSLecturer.Instance.SelectCount().ToString());
            float TyLe = (StudentQuantity / LectureQuantity);

            int currentCount = 0;
            int increment = 1;
            int delay = 20;

            while (currentCount < StudentQuantity)
            {
                currentCount += increment+increment;
                if (currentCount > StudentQuantity)
                {
                    currentCount = StudentQuantity;
                }

                guna2HtmlLabelSinhVien.Text = currentCount.ToString();
                await Task.Delay(delay);

                if (delay > 3)
                {
                    delay -= 3;
                }
            }
            guna2HtmlLabelGiangVien.Text = LectureQuantity.ToString();
            guna2HtmlLabelTyLe.Text = TyLe.ToString();

            guna2HtmlLabelLopHoc.Text = BUSClass.Instance.SelectCount().ToString();
            guna2HtmlLabelKhoaHoc.Text = BUSSpecialty.Instance.SelectCount().ToString();
            guna2HtmlLabelHocPhan.Text = BUSSubject.Instance.SelectCount().ToString();
        }

        void CreateChartScore(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT ROUND(diemtbc, 0) AS DiemLamTron, COUNT(*) AS SoLuong " +
                               "FROM DiemThi " +
                               "GROUP BY ROUND(diemtbc, 0)";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                Series series = new Series("Số Lượng Sinh Viên");
                series.ChartType = SeriesChartType.Column;
                series.Name = "Số Lượng Sinh Viên";


              
                while (reader.Read())
                {
                    double diemLamTron = reader.GetDouble(0);
                    int soLuong = reader.GetInt32(1);


                    series.Points.AddXY(diemLamTron, soLuong);
                }

                chartThongKe.Series.Add(series);

                chartThongKe.ChartAreas[0].AxisX.Title = "Điểm ";
                chartThongKe.ChartAreas[0].AxisY.Title = "Số Lượng";

                chartThongKe.ChartAreas[0].AxisX.Minimum = 0;  // Giá trị tối thiểu trục x
                chartThongKe.ChartAreas[0].AxisX.Maximum = 11; // Giá trị tối đa trục x

                chartThongKe.ChartAreas[0].AxisY.Minimum = 0;  // Giá trị tối thiểu trục y
                chartThongKe.ChartAreas[0].AxisY.Maximum = 30;

                chartThongKe.Update();

                reader.Close();
                connection.Close();
            }
        }

        void CreateChartStudent(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT malop, COUNT(*) AS SoLuongSinhVien " +
                               "FROM sinhvien " +
                               "GROUP BY malop";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                Series series = new Series("Số Lượng Sinh Viên");
                series.ChartType = SeriesChartType.Column;

                // Đọc dữ liệu từ SqlDataReader và thêm vào biểu đồ
                while (reader.Read())
                {
                    string lop = reader.GetString(0);
                    int soLuongSinhVien = reader.GetInt32(1);

                    series.Points.AddXY(lop, soLuongSinhVien);
                }

                chartThongKe.Series.Add(series);
                
                chartThongKe.ChartAreas[0].AxisX.Title = "Lớp";
                chartThongKe.ChartAreas[0].AxisY.Title = "Số Lượng Sinh Viên";

                chartThongKe.ChartAreas[0].AxisX.Minimum = 0;  
                chartThongKe.ChartAreas[0].AxisX.Maximum = 10;  

                chartThongKe.ChartAreas[0].AxisY.Minimum = 0;
                chartThongKe.ChartAreas[0].AxisY.Maximum = 10;

                chartThongKe.Update();
                reader.Close();
                connection.Close();
            }
        }

        private void comboBoxDiem_SelectedIndexChanged(object sender, EventArgs e)
        {
  

            if (chartThongKe.Series.Any())
            {

                chartThongKe.Series.Clear();
            }


            if (comboBoxSelect.SelectedIndex == 0)
            {

                CreateChartScore(connectionString);
            }
            else if (comboBoxSelect.SelectedIndex == 1)
            {
                CreateChartStudent(connectionString);

            }

        }
    }
}
