
using GUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Shell;
using GemBox.Spreadsheet;

namespace GUI
{
    public partial class fHome : Form
    {
        public static string AccountType;
        private static fHome _instance;
        public static fHome Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new fHome();
                }
                return _instance;
            }
        }
        public fHome()
        {
            InitializeComponent();
            hideSubMenu();
 
            loadPicture();

        }
        private void hideSubMenu()
        {
            flowLayoutPanelHoSo.Visible = false;
            flowLayoutPanelHocTap.Visible = false;
            flowLayoutPanelQuanLy.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
   
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        void ShowUserControls(UserControl uc)
        {
            panelContent.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
        }

        private void ButtonHoSo_Click(object sender, EventArgs e)
        {
            showSubMenu(flowLayoutPanelHoSo);
        }
        private void ButtonHocTap_Click(object sender, EventArgs e)
        {
            showSubMenu(flowLayoutPanelHocTap);
        }
        private void ButtonQuanLy_Click(object sender, EventArgs e)
        {
            showSubMenu(flowLayoutPanelQuanLy);
        }

        private Form activeForm = null;
        public void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void CenterLabel(Label lb)
        {
            int x = (panelTitle.Width - lb.Width) / 2;
            int y = (panelTitle.Height - lb.Height) / 2;
            lb.Location = new Point(x, y);
        }
        private void ButtonSinhVien_Click(object sender, EventArgs e)
        {
            labelTitle.Text = ButtonHoSo.Text + " " + ButtonSinhVien.Text;
            CenterLabel(labelTitle);
            openChildFormInPanel(new fHoSoSinhVien());
            PictureBoxLogo.Enabled = false;


        }

        private void ButtonGiangVien_Click(object sender, EventArgs e)
        {
            labelTitle.Text = ButtonHoSo.Text + " " + ButtonGiangVien.Text;
            CenterLabel(labelTitle);
            openChildFormInPanel(new fHoSoGiangVien());

        }

        private void ButtonQuanLy_MouseEnter(object sender, EventArgs e)
        {
            ButtonQuanLy.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonQuanLy_MouseLeave(object sender, EventArgs e)
        {
            ButtonQuanLy.BackColor = Color.White;
        }

        private void ButtonHoSo_MouseEnter(object sender, EventArgs e)
        {
            ButtonHoSo.BackColor = Color.DeepSkyBlue;

        }

        private void ButtonHoSo_MouseLeave(object sender, EventArgs e)
        {
            ButtonHoSo.BackColor = Color.White;

        }

        private void ButtonThongKe_MouseEnter(object sender, EventArgs e)
        {
            ButtonThongKe.BackColor = Color.DeepSkyBlue;

        }

        private void ButtonThongKe_MouseLeave(object sender, EventArgs e)
        {
            ButtonThongKe.BackColor = Color.White;

        }

        private void ButtonBaoCao_MouseEnter(object sender, EventArgs e)
        {
            ButtonBaoCao.BackColor = Color.DeepSkyBlue;

        }

        private void ButtonBaoCao_MouseLeave(object sender, EventArgs e)
        {
            ButtonBaoCao.BackColor = Color.White;

        }

        private void ButtonSinhVien_MouseEnter(object sender, EventArgs e)
        {
            ButtonSinhVien.BackColor = Color.DeepSkyBlue;

        }

        private void ButtonSinhVien_MouseLeave(object sender, EventArgs e)
        {
            ButtonSinhVien.BackColor = Color.Silver;

        }

        private void ButtonGiangVien_MouseEnter(object sender, EventArgs e)
        {
            ButtonGiangVien.BackColor = Color.DeepSkyBlue;

        }

        private void ButtonGiangVien_MouseLeave(object sender, EventArgs e)
        {
            ButtonGiangVien.BackColor = Color.Silver;

        }

        private void ButtonDiemThi_MouseEnter(object sender, EventArgs e)
        {
            ButtonDiemThi.BackColor = Color.DeepSkyBlue;

        }

        private void ButtonDiemThi_MouseLeave(object sender, EventArgs e)
        {
            ButtonDiemThi.BackColor = Color.Silver;

        }

        private void ButtonHocPhan_MouseEnter(object sender, EventArgs e)
        {
            ButtonHocPhan.BackColor = Color.DeepSkyBlue;

        }

        private void ButtonHocPhan_MouseLeave(object sender, EventArgs e)
        {
            ButtonHocPhan.BackColor = Color.Silver;

        }

        private void ButtonChuyenNganh_MouseEnter(object sender, EventArgs e)
        {
            ButtonChuyenNganh.BackColor = Color.DeepSkyBlue;

        }

        private void ButtonChuyenNganh_MouseLeave(object sender, EventArgs e)
        {
            ButtonChuyenNganh.BackColor = Color.Silver;

        }

        private void kdCircularPictureBox1_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "ĐẠI HỌC SƯ PHẠM KỸ THẬT HƯNG YÊN";
            CenterLabel(labelTitle);
            ShowUserControls(new UCHome());

        }

        private void ButtonDiemThi_Click(object sender, EventArgs e)
        {
            labelTitle.Text = ButtonDiemThi.Text;
            CenterLabel(labelTitle);
            openChildFormInPanel(new fDiem());
        }

        private void ButtonHocPhan_Click(object sender, EventArgs e)
        {
            labelTitle.Text = ButtonQuanLy.Text + " " + ButtonHocPhan.Text;
            CenterLabel(labelTitle);
            openChildFormInPanel(new fHocPhan());
        }

        private void ButtonChuyenNganh_Click(object sender, EventArgs e)
        {
            labelTitle.Text = ButtonQuanLy.Text + " " + ButtonChuyenNganh.Text;
            CenterLabel(labelTitle);
            openChildFormInPanel(new fChuyenNganh());
        }

        private void ButtonThongKe_Click(object sender, EventArgs e)
        {
            labelTitle.Text = ButtonThongKe.Text;
            CenterLabel(labelTitle);
            openChildFormInPanel(new fThongKe());
        }

        private void ButtonBaoCao_Click(object sender, EventArgs e)
        {
            labelTitle.Text = ButtonBaoCao.Text;
            CenterLabel(labelTitle);
            openChildFormInPanel(new fTaiKhoan());
        }

        private void ButtonLopHoc_Click(object sender, EventArgs e)
        {
            labelTitle.Text = ButtonQuanLy.Text + " " + ButtonLopHoc.Text;
            CenterLabel(labelTitle);
            openChildFormInPanel(new fLopHoc());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Chắc Chắn Muốn Đăng Xuất Không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                this.Hide();

                fLogin formLogin = new fLogin();
                formLogin.Show();
            }
        }

        private void fHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đóng ứng dụng?", "Xác nhận đóng", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result != DialogResult.OK)
            {
                e.Cancel = true; 
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void ButtonLopHoc_MouseEnter(object sender, EventArgs e)
        {
            ButtonLopHoc.BackColor = Color.DeepSkyBlue;

        }

        private void ButtonLopHoc_MouseLeave(object sender, EventArgs e)
        {
            ButtonLopHoc.BackColor = Color.Silver;

        }

        private void ButtonNganhHoc_Click(object sender, EventArgs e)
        {
            labelTitle.Text = ButtonQuanLy.Text + " " + ButtonNganhHoc.Text;
            CenterLabel(labelTitle);
            openChildFormInPanel(new fNganhHoc());
        }

        private void ButtonKhoa_Click(object sender, EventArgs e)
        {
            labelTitle.Text = ButtonQuanLy.Text + " " + ButtonKhoa.Text;
            CenterLabel(labelTitle);
            openChildFormInPanel(new fKhoa());
        }

        private void ButtonLichHoc_Click(object sender, EventArgs e)
        {
            labelTitle.Text = ButtonLichHoc.Text;
            CenterLabel(labelTitle);
            openChildFormInPanel(new fLichHoc());
        }

        private void fHome_Load(object sender, EventArgs e)
        {
            fHome.Instance.PictureBoxLogo.Enabled = true;
        }

        private void pictureBoxContent_Click(object sender, EventArgs e)
        {

        }

        private void ButtonLichHoc_MouseEnter(object sender, EventArgs e)
        {
            ButtonLichHoc.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonLichHoc_MouseLeave(object sender, EventArgs e)
        {
            ButtonLichHoc.BackColor = Color.Silver;

        }

        private void ButtonNganhHoc_MouseEnter(object sender, EventArgs e)
        {
            ButtonNganhHoc.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonNganhHoc_MouseLeave(object sender, EventArgs e)
        {
            ButtonNganhHoc.BackColor = Color.Silver;
        }

        private void ButtonKhoa_MouseEnter(object sender, EventArgs e)
        {
            ButtonKhoa.BackColor = Color.DeepSkyBlue;
        }

        private void ButtonKhoa_MouseLeave(object sender, EventArgs e)
        {
            ButtonKhoa.BackColor = Color.Silver;

        }

        private void ButtonHocTap_MouseEnter(object sender, EventArgs e)
        {
            ButtonHocTap.BackColor = Color.DeepSkyBlue;

        }

        private void ButtonHocTap_MouseLeave(object sender, EventArgs e)
        {
            ButtonHocTap.BackColor = Color.White;
        }

        private void ButtonQuanLy_MouseEnter_1(object sender, EventArgs e)
        {
            ButtonQuanLy.BackColor = Color.DeepSkyBlue;

        }

        private void ButtonQuanLy_MouseLeave_1(object sender, EventArgs e)
        {
            ButtonQuanLy.BackColor = Color.White;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentImageIndex = (currentImageIndex + 1) % images.Count;
            pictureBoxContent.Image = images[currentImageIndex];
        }

        private List<Image> images;
        private int currentImageIndex;
        void loadPicture()
        {

           
            images = new List<Image>
        {
            Image.FromFile("1.jpg"),
            Image.FromFile("2.jpg"),
            Image.FromFile("3.jpg"),

        };

            currentImageIndex = 0;
            pictureBoxContent.Image = images[currentImageIndex];

            // Bắt đầu Timer
            timer1.Start();
            pictureBoxContent.Image = images[currentImageIndex];
        }

        private void iconButton1_MouseEnter(object sender, EventArgs e)
        {
            iconButton1.BackColor = Color.LightSkyBlue;
        }

        private void iconButton1_MouseLeave(object sender, EventArgs e)
        {
            iconButton1.BackColor = Color.White;
        }

        private void panelTitle_Paint(object sender, PaintEventArgs e)
        {

        }
        private void buttonExport_Click(object sender, EventArgs e)
        {
            Form latestForm = FormHelper.GetLatestOpenedForm();
            string currentForm = latestForm.Name;
            string title;
            switch (currentForm)
            {
                case "fHoSoSinhVien":
                    title = "DANH SÁCH SINH VIÊN TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN";
                    ExportExcel((DataTable)fHoSoSinhVien.Instance.dataGridViewContent.DataSource, title, 4);
                    break;
                case "fHoSoGiangVien":
                    title = "DANH SÁCH GIẢNG VIÊN TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN";
                    ExportExcel((DataTable)fHoSoGiangVien.Instance.dataGridViewContent.DataSource, title);

                    break;
                case "fDiem":
                    title = "KẾT QUẢ HỌC TẬP SINH VIÊN TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN";
                    ExportExcel((DataTable)fDiem.Instance.dataGridViewContent.DataSource, title);

                    break;
                case "fHocPhan":
                    title = "DANH SÁCH HỌC PHẦN TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN";
                    ExportExcel((DataTable)fHocPhan.Instance.dataGridViewContent.DataSource, title);

                    break;
                case "fKhoa":
                    title = "DANH SÁCH KHOA TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN";
                    ExportExcel((DataTable)fKhoa.Instance.dataGridViewContent.DataSource, title);

                    break;
                case "fLichHoc":
                    title = "LỊCH HỌC";
                    break;
                case "fLopHoc":
                    title = "DANH SÁCH LỚP HỌC TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN";
                    ExportExcel((DataTable)fLopHoc.Instance.dataGridViewContent.DataSource, title);

                    break;
                case "fNganhHoc":
                    title = "DANH SÁCH NGÀNH HỌC TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN";
                    ExportExcel((DataTable)fNganhHoc.Instance.dataGridViewContent.DataSource, title);
                    break;
                case "fChuyenNganh":
                    title = "DANH SÁCH NGÀNH HỌC TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN";
                    ExportExcel((DataTable)fChuyenNganh.Instance.dataGridViewContent.DataSource, title);
                    break;
                default:
                    title = "";
                    break;
            }

        }
        void ExportExcel (DataTable data, string title, int n = 0)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

            var workbook = new ExcelFile();
            var worksheet = workbook.Worksheets.Add("DataTable to Sheet");

            var dataTable = data;

            worksheet.Cells[0, n].Value = "TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN";
            worksheet.Cells[0, n].Style.Font.Weight = ExcelFont.BoldWeight;
            worksheet.Cells[1, n+1].Value = "PHÒNG ĐÀO TẠO";
            worksheet.Cells[0, n+7].Value = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM";
            worksheet.Cells[0, n+7].Style.Font.Weight = ExcelFont.BoldWeight;
            worksheet.Cells[1, n+8].Value = "Độc lập - Tự do - Hạnh phúc";

            var cells = worksheet.Cells[3, n+1];
            cells.Value = title;
            cells.Style.Font.Weight = ExcelFont.BoldWeight;
            cells.Style.Font.Size = 13 * 20;

            worksheet.InsertDataTable(dataTable,
                new InsertDataTableOptions()
                {
                    ColumnHeaders = true,
                    StartRow = 5
                    
                });

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Tệp Excel|*.xlsx";
                saveFileDialog.Title = "Lưu tệp Excel";
                saveFileDialog.FileName = "TenFile.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.Save(saveFileDialog.FileName);
                }
            }
        }
    }
    public static class FormHelper
    {
        public static Form GetLatestOpenedForm()
        {
            return Application.OpenForms.Cast<Form>().LastOrDefault();
        }
    }

}
