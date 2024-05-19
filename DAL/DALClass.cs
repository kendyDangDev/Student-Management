using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALClass
    {
        private static DALClass _instance;
        public static DALClass Instance
        {
            get
            {
                if( _instance == null )
                    _instance = new DALClass();
                return _instance;
            }
           
        }

        public DataTable GetClassByID(string ID)
        {
            string query = "SELECT MALOP FROM LOPHOC WHERE MALOP = @ID";
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] {ID});
            return dataTable;
        }
        public DataTable GetClassByName(string malop)
        {
            string query = "SELECT MALOP FROM LOPHOC WHERE TENLOP = @malop";
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { malop });
            return dataTable;
        }
        public DataTable GetIDByName(string name)
        {
            string query = "SELECT MALOP FROM LOPHOC WHERE TenLop = @name";
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { name });
            return dataTable;
        }
        public DataTable GetAllLopHoc()
        {
            string query = "SELECT MALOP FROM LOPHOC";
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }

        public DataTable GetAllClass()
        {
            string query = "USP_GetAllClass";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int InsertClass(string malop, string tenlop, string hedaotao, string maGV, string machuyennganh)
        {
            string query = "USP_InsertClass @MALOP , @TENLOP , @HEDAOTAO , @MAGIANGVIEN , @MACHUYENNGANH";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] {malop, tenlop, hedaotao, maGV, machuyennganh});
        }
        public int UpdateClass(string malop, string tenlop, string hedaotao, string maGV, string machuyennganh)
        {
            string query = "USP_UpdateClass @MALOP , @TENLOP , @HEDAOTAO , @MAGIANGVIEN , @MACHUYENNGANH";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { malop, tenlop, hedaotao, maGV, machuyennganh });
        }

        public int DeleteClass(string malop)
        {
            string query = "DELETE FROM LOPHOC WHERE MALOP = @Malop";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] {malop});
        }

        public DataTable FilterClass(string column, string value)
        {
            string query = "USP_SearchClass @SearchColumn , @SearchValue";
            return DataProvider.Instance.ExecuteQuery(query, new object[] {column, value});
        }

        public DataTable SelectCount()
        { 
            string query = "SELECT COUNT(*) FROM LOPHOC";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
