using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALScore
    {

        private static DALScore _instance;
        public static DALScore Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DALScore();
                }
                return _instance;
            }
        }

        public DataTable GetAllScore()
        {
            string query = "USP_GetAllScore";
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }

        public int InsertScore(float diemGHP, float diemKTHP, string masv, string mahocphan)
        {
            int result = 0;
            string query = "USP_InsertScore @DIEMGHP , @DIEMKTHP , @MASINHVIEN , @MAHOCPHAN";
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { diemGHP, diemKTHP, masv , mahocphan });
            return result;
        }

        public DataTable GetScoreSubject(string masv, string mahp)
        {
            string query = "select * from DIEMTHI where masv = @masv and MAHOCPHAN = @mahp ";
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { masv, mahp });
            return dataTable;
        }

        public int UpdateScore(float diemGHP, float diemKTHP, string masv, string mahp)
        {
            int result = 0;
            string query = "USP_UpdateScore @diemGHP , @diemKTHP , @MASINHVIEN , @MAHOCPHAN";
            result = DataProvider.Instance.ExecuteNonQuery(query,new object[] { diemGHP, diemKTHP, masv, mahp });
            return result;
        }
        public DataTable GetStudentByIDInScore(string ID)
        {
            DataTable dataTable = new DataTable();
            string query = $"SELECT * FROM diemthi WHERE MASV = @ID";
            dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { ID });
            return dataTable;
        }

        public int DeleteScore(string mahp)
        {
            int result = 0;
            string query = "DELETE FROM DIEMTHI WHERE MAHOCPHAN = @MAHP";
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {mahp});
            return result;
        }

        public DataTable FilterScore(string column, string value)
        {
            DataTable dataTable = new DataTable();
            string query = "USP_SearchScore @SearchColumn , @SearchValue";
            dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { column, value });
            return dataTable;
        }
        public DataTable GetScoreByMaSV(string maSV)
        {
            DataTable dataTable = new DataTable();
            string query = "select * from v_DiemByLop where [mã SV] = @maSV";
            dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { maSV });
            return dataTable;
        }

        public DataTable SortASC()
        {
            string query = "select * from v_SearchByMonHoc order by [Điểm TBC]";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable SortDESC()
        {
            string query = "select * from v_SearchByMonHoc order by [Điểm TBC] DESC";
            return DataProvider.Instance.ExecuteQuery(query);
        }



        //public void 
    }
}
