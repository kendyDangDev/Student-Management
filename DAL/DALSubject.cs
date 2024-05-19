using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALSubject
    {
        private static DALSubject _instance;
        public static DALSubject Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DALSubject();
                }
                return _instance;
            }
        }

        public DataTable GetAllSubject()
        {
            string query = "SELECT TENHOCPHAN FROM HOCPHAN";
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }
        public DataTable GetIDByName(string name)
        {
            string query = "select MAHOCPHAN from HOCPHAN where TENHOCPHAN = @name";
            return DataProvider.Instance.ExecuteQuery(query, new object[] {name});
        }

        public DataTable GetAllHocPhan()
        {
            string query = "USP_GetAllHocPhan";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int InsertSubject(string mahp, string tenhp, int sotc, string loaiHP, string Khoa)
        {
            string query = "USP_INSERT_HOCPHAN @MAHOCPHAN , @TENHOCPHAN , @SOTINCHI , @loaiHOCPHAN , @MAKHOA";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { mahp, tenhp, sotc, loaiHP, Khoa });
        }
        public int UpdateSubject(string mahp, string tenhp, int sotc, string loaiHP, string Khoa)
        {
            string query = "USP_UPDATE_HOCPHAN @MAHOCPHAN , @TENHOCPHAN , @SOTINCHI , @loaiHOCPHAN , @MAKHOA";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { mahp, tenhp, sotc, loaiHP, Khoa });
        }

        public int DeleteSubject(string mahp)
        {
            string query = "USP_DeleteHocPhan @Mahp ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { mahp });
        }


        public DataTable GetSubjectByID(string ID)
        {
            string query = "SELECT * FROM HOCPHAN WHERE Mahocphan = @ID";
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { ID });
            return dataTable;
        }
        public DataTable GetSubjectByName(string name)
        {
            string query = "SELECT * FROM HOCPHAN WHERE tenhocphan = @name";
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { name });
            return dataTable;
        }
        public DataTable FilterSubject(string column, string name)
        {
            string query = "USP_SearchSubject @SearchColumn , @SearchValue";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { column, name });
        }
        public DataTable selectCount()
        {
            string query = "SELECT COUNT(*) FROM HOCPHAN";
            return DataProvider.Instance.ExecuteQuery(query);

        }
    }
}
