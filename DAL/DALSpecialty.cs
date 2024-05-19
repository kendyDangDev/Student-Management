using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALSpecialty
    {
        private static DALSpecialty _instance;
        public static DALSpecialty Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DALSpecialty();
                }
                return _instance;
            }
        }

        public DataTable GetAllSpecialtyName()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT TENCHUYENNGANH FROM CHUYENNGANH";
            dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;

        }

        public DataTable GetIDByName(string name)
        {
            string query = "select MACHUYENNGANHNGANH from CHUYENNGANH where TENCHUYENNGANH = @name";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { name });
        }

        public DataTable GetAllBranh()
        {
            string query = "USP_GetAllChuyenNganh";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int InsertSpecialty(string macn, string tencn, int thoigiandaotao, string maNganh)
        {
            string query = "USP_INSERT_CHUYENNGANH @MACHUYENNGANH , @TENCHUYENNGANH , @THOIGIANDAOTAO , @MANGANH";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] {macn, tencn, thoigiandaotao, maNganh});    
        }

        public DataTable GetSpecialtyByID(string macn)
        {
            string query = "select * from CHUYENNGANH where MACHUYENNGANHNGANH = @macn";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { macn });
        }
        public DataTable GetSpecialtyByName(string name)
        {
            string query = "select * from CHUYENNGANH where TenChuyenNganh = @name";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { name });
        }

        public int UpdateSpecialty(string macn, string tencn, int thoigiandaotao, string maNganh)
        {
            string query = "USP_UPDATE_CHUYENNGANH @MACHUYENNGANH , @TENCHUYENNGANH , @THOIGIANDAOTAO , @MANGANH";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] {macn, tencn, thoigiandaotao, maNganh});
        }

        public int DeleteSpecialty(string macn)
        {
            string query = "delete CHUYENNGANH where MACHUYENNGANHNGANH = @mcn";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { macn });
        }

        public DataTable FilterSpecialty(string column, string name)
        {
            string query = "USP_SearchChuyenNganh @SearchColumn , @SearchValue";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { column, name});
        }
        public DataTable selectCount()
        {
            string query = "SELECT COUNT(*) FROM CHUYENNGANH";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
