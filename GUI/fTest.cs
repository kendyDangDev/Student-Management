using BUS;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fTest : Form
    {
        public fTest()
        {
            InitializeComponent();
            loadData();
      
        }
        //public void loadData()
        //{
        //    try
        //    {
        //        string connectionString = @"Data Source=localhost;
        //                                     Initial Catalog=UTEHY;
        //                                     User ID=sa;Password=Kendydang19082004";
        //        using (SqlConnection conn = new SqlConnection(connectionString))
        //        {
        //            conn.Open();
        //            string query = "Select * from v_sinhvien";
        //            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);

        //            DataTable dataTable = new DataTable();
        //            dataAdapter.Fill(dataTable);

        //            dtg.DataSource = dataTable;
        //        }
        //        foreach (DataGridViewColumn column in dtg.Columns)
        //        {
        //            column.SortMode = DataGridViewColumnSortMode.NotSortable;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred: " + ex.Message);
        //    }
        //}
    void loadData()
        {
            BUSLecturer.Instance.GetAllGiangVien(guna2DataGridView1);
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
