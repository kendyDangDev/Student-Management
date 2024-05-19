using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALMajor
    {
        private static DALMajor _instance;
        public static DALMajor Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DALMajor();
                }
                return _instance;
            }
        }

        public DataTable GetAllMajorName()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT TENNGANH FROM NGANH";
            dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;

        }

        public DataTable GetIDByName(string name)
        {
            string query = "select MANGANH from NGANH where TENNGANH = @name";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { name });
        }

        public DataTable GetAllMajor()
        {
            string query = "USP_GetAllNganh";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int InsertMajor(string maNganh, string tenNganh, string maKhoa)
        {
            string query = "USP_InsertNganh @MANGANH , @TENNGANH , @MAKHOA";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maNganh, tenNganh, maKhoa });
        }

        public DataTable GetMajorByID(string maNganh)
        {
            string query = "select * from v_Nganh where [Mã Ngành] = @maNganh";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { maNganh });
        }
        public DataTable GetMajorByName(string name)
        {
            string query = "select * from NGANH where TenNganh = @name";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { name });
        }

        public int UpdateMajor(string maNganh, string tenNganh, string maKhoa)
        {
            string query = "USP_UpdateNganh @MANGANH , @TENNGANH , @MAKHOA";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maNganh, tenNganh, maKhoa });
        }

        public int DeleteMajor(string maNganh)
        {
            string query = "USP_DeleteNganh @MANGANH";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maNganh });
        }

        public DataTable FilterMajor(string column, string name)
        {
            string query = "USP_SearchNganh @SearchColumn , @SearchValue";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { column, name });
        }
     
    }
}
