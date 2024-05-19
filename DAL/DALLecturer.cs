using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALLecturer
    {
        private static DALLecturer _instance;
        public static DALLecturer Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DALLecturer();
                return _instance;
            }

        }
        public DataTable GetAllGiangVien()
        {
            DataTable dataTable = new DataTable();
            string query = "USP_GetAllGiangVien";
            dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }
        public DataTable GetNameGiangVien()
        {
            DataTable dataTable = new DataTable();
            string query = "select tengiangvien from giangvien";
            dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }
        public DataTable GetIDByName(string name)
        {
            string query = "select magiangvien from giangvien where tengiangvien = @name";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { name });
        }

        public DataTable GetGiangVienByID(string ID)
        {
            DataTable dataTable = new DataTable();
            string query = $"SELECT * FROM giangvien WHERE MAgiangvien = @ID";
            dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { ID });
            return dataTable;
        }
        public DataTable GetGiangVienByIDKhoa(string maKhoa)
        {
            DataTable dataTable = new DataTable();
            string query = $"SELECT * FROM giangvien WHERE makhoa = @makhoa";
            dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { maKhoa });
            return dataTable;
        }
        public DataTable GetSoCCCD(string cccd)
        {
            DataTable dataTable = new DataTable();
            string query = $"SELECT * FROM giangvien WHERE cccd = @cccd";
            dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { cccd });
            return dataTable;
        }

        public int InsertGiangVien(string magv,
                             string hoten,
                             string gioitinh,
                             string trinhdo,
                             DateTime ngaysinh,
                             string diachi,
                             string socccd,
                             string sdt,
                             string makhoa)
        {
            string query = "USP_INSERT_GIANGVIEN @MAGV , @HOTEN , @GIOITINH , @TRINHDO , @NGAYSINH , @DIACHI , @SOCCCD , @SODIENTHOAI , @MAKHOA";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { magv, hoten, gioitinh, trinhdo, ngaysinh, diachi, socccd, sdt, makhoa });
        }

        public int UpdateGiangVien(
                                 string magv,
                                 string hoten,
                                 string gioitinh,
                                 string trinhdo,
                                 DateTime ngaysinh,
                                 string diachi,
                                 string socccd,
                                 string sdt,
                                 string makhoa)
        {
            string query = "USP_UPDATE_GIANGVIEN @MAGV , @HOTEN , @GIOITINH , @TRINHDO , @NGAYSINH , @DIACHI , @SOCCCD , @SODIENTHOAI , @MAKHOA";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { magv, hoten, gioitinh, trinhdo, ngaysinh, diachi, socccd, sdt, makhoa });
        }


        public int DeleteGiangVien(string ID)
        {
            string query = "USP_DeleteGiangVien @magv";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ID });
        }

        public DataTable FilterLectures(string columnname, string value)
        {
            string query = "USP_SearchLecture @SearchColumn , @SearchValue";
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { columnname, value });
            return dataTable;
        }

        public DataTable selectCount()
        {
            string query = "SELECT COUNT(*) FROM GIANGVIEN";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
