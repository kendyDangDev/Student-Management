using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace DAL
{
    public class DALStudent
    {
        private static DALStudent _instance;
        public static DALStudent Instance
        {
            get
            {
                if( _instance == null)
                {
                   _instance = new DALStudent();
                }
                return _instance;
            }
        }

        public DataTable GetAllStudent()
        {
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery("USP_ThongTinSinhVien");

            return data;
        }

        public DataTable GetStudentByID(string ID)
        {
            DataTable dataTable = new DataTable();
            string query = $"SELECT * FROM sinhvien WHERE MASV = @ID";
            dataTable = DataProvider.Instance.ExecuteQuery(query,new object[] {ID});
            return dataTable;
        }

        public DataTable GetStudentByCCCD(string CCCD)
        {
            DataTable dataTable = new DataTable();
            string query = $"SELECT * FROM sinhvien WHERE CCCD = @CCCD";
            dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { CCCD });
            return dataTable;
        }

        public int AddHoSoSinhVien(string masv,
                                    string hoten,
                                    string gioitinh,
                                    string dantoc,
                                    DateTime ngaysinh,
                                    string diachi,
                                    string sdt,
                                    string email,
                                    string socccd,
                                    string nienkhoa,
                                    string namnhaphoc,
                                    string malop,

                                    string hotennt,
                                    string quanhe,
                                    DateTime ngaysinhnt,
                                    string sdtnt)
        {
            string query = "USP_AddHoSoSinhVien @MASV , @HOTEN , @GIOITINH , @DANTOC , @NGAYSINH , @DIACHI , @SDT , @EMAIL , @SOCCCD , @NIENKHOA , @NAMNHAPHOC , @MALOP , @HOTENNT , @QUANHE , @NGAYSINHNT , @SDTNT ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { masv, hoten, gioitinh, dantoc, ngaysinh, diachi, sdt, email, socccd, nienkhoa, namnhaphoc, malop, hotennt, quanhe, ngaysinhnt, sdtnt });
 
        }

        public int UpdateHoSoSinhVien(string masv,
                                    string hoten,
                                    string gioitinh,
                                    string dantoc,
                                    DateTime ngaysinh,
                                    string diachi,
                                    string sdt,
                                    string email,
                                    string socccd,
                                    string nienkhoa,
                                    string namnhaphoc,
                                    string malop,

                                    string hotennt,
                                    string quanhe,
                                    DateTime ngaysinhnt,
                                    string sdtnt)
        {
            string query = "USP_UPDATESTUDENT @MASV , @HOTEN , @GIOITINH , @DANTOC , @NGAYSINH , @DIACHI , @SDT , @SOCCCD , @HOTENNT , @QUANHE , @NGAYSINHNT , @SDTNT , @MALOP , @NIENKHOA , @HDT , @NAMNHAPHOC";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { masv, hoten, gioitinh, dantoc, ngaysinh, diachi, sdt, email, socccd, nienkhoa, namnhaphoc, malop, hotennt, quanhe, ngaysinhnt, sdtnt });
        }


        public int DeleteStudent(string ID)
        {
            string query = "USP_DELETESTUDENT @MASV";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ID });
        }

        public DataTable FilterStudent(string columnname, string value)
        {
            string query = "USP_SEARCH_STUDENT @SearchColumn , @SearchValue";
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { columnname, value });
            return dataTable;
        }

        public DataTable GetStudent(string username)
        {
            string query = "Select * from v_SinhVien where [MÃ SV] = @username";
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { username });
            return dataTable;
        }

        public DataTable GetMalopByMaSV(string maSV)
        {
            string query = "SELECT MALOP FROM SINHVIEN WHERE MASV = @maSV";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { maSV });
        }

        public DataTable selectCount()
        {
            string query = "SELECT COUNT(*) FROM SinhVien";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }

}
