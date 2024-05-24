using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALFaculty
    {
        private static DALFaculty _instance;
        public static DALFaculty Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DALFaculty();
                }
                return _instance;
            }
        }

        public DataTable GetAllFaculty()
        {
            string query = "USP_GetAllFaculty";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetFacultyName()
        {
            string query = "select tenKhoa from khoa";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetIDByName(string name)
        {
            string query = "select makhoa from khoa where tenkhoa = @name";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { name });
        }
        public DataTable GetNameByID(string makhoa)
        {
            string query = "select tenkhoa from khoa where makhoa = @makhoa";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { makhoa });
        }
        public int InsertFaculty(string maKhoa, string tenKhoa, string sDT, string email)
        {
            string query = "USP_InsertFaculty @MAKhoa , @TENKhoa , @SDT , @Email";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maKhoa, tenKhoa, sDT, email });
        }

        public DataTable GetFacultyByID(string maKhoa)
        {
            string query = "select * from v_Khoa where [Mã Khoa] = @maKhoa";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { maKhoa });
        }
        public DataTable GetFacultyByName(string name)
        {
            string query = "select * from v_Khoa where [Tên Khoa] = @name";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { name });
        }

        public int UpdateFaculty(string maKhoa, string tenKhoa, string sDT, string email)
        {
            string query = "USP_UpdateFaculty @MAKhoa , @TENKhoa , @SDT , @email";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maKhoa, tenKhoa, sDT, email });
        }

        public int DeleteFaculty(string maKhoa)
        {
            string query = "USP_DeleteFaculty @MAKhoa";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { maKhoa });
        }

        public DataTable FilterFaculty(string column, string name)
        {
            string query = "USP_SearchFaculty @SearchColumn , @SearchValue";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { column, name });
        }
    }
}
