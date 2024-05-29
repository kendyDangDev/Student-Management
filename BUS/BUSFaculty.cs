using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BUS
{
    public class BUSFaculty
    {
        private static BUSFaculty _instance;
        public static BUSFaculty Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BUSFaculty();
                }
                return _instance;
            }
        }

        public void GetAllFaculty(DataGridView datagrid)
        {
            datagrid.DataSource = DALFaculty.Instance.GetAllFaculty();
        }

        public void GetFacultyName(ComboBox cbx)
        {
            List<string> classList = new List<string>();
            DataTable dataTable = DALFaculty.Instance.GetFacultyName();
            foreach (DataRow row in dataTable.Rows)
            {
                classList.Add(row[0].ToString());
            }
            cbx.DataSource = classList;
        }

        public string GetIDByName(string name)
        {
            string result = "";
            DataTable dataTable = DALFaculty.Instance.GetIDByName(name);

            foreach (DataRow row in dataTable.Rows)
            {
                result = row[0].ToString();
            }
            return result;
        }

        public string GetNameByID(string makhoa)
        {
            string result = "";
            DataTable dataTable = DALFaculty.Instance.GetNameByID(makhoa);

            foreach (DataRow row in dataTable.Rows)
            {
                result = row[0].ToString();
            }
            return result;
        }
        public string InsertFaculty(string maKhoa, string tenKhoa, string sDT, string email)
        {
            Regex regexEmail = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            if (!regexEmail.IsMatch(email))
            {
                return "Địa Chỉ Email Không Hợp Lệ";
            }
            Regex regexNumber = new Regex(@"^0\d{9}$");
            if (!regexNumber.IsMatch(sDT))
            {
                return "Số Điện Thoại Không Hợp Lệ (10 số)";
            }
            if (DALFaculty.Instance.GetFacultyByID(maKhoa).Rows.Count > 0)
            {
                return "Khoa Có Mã Này Đã Tồn Tại";
            }
            else
            {
                if (DALFaculty.Instance.GetFacultyByName(tenKhoa).Rows.Count > 0)
                {
                    return "Khoa Có Tên Này Đã Tồn Tại";
                }
                else
                {
                    if (DALFaculty.Instance.InsertFaculty(maKhoa, tenKhoa, sDT, email) > 0)
                    {
                        return "";
                    }
                    else
                    {
                        return "Thêm Không Thành Công";
                    }

                }
            }
        }

        public string UpdateFaculty(string maKhoa, string tenKhoa, string sDT, string email)
        {
            Regex regexEmail = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            if (!regexEmail.IsMatch(email))
            {
                return "Địa Chỉ Email Không Hợp Lệ";
            }
            Regex regexNumber = new Regex("^[0-9]+$");
            if (!regexNumber.IsMatch(sDT))
            {
                return "Số Điện Thoại Không Hợp Lệ";
            }
            if (DALFaculty.Instance.GetFacultyByID(maKhoa).Rows.Count == 0)
            {
                return "Khoa Có Này Không Tồn Tại Tồn Tại";
            }
            else
            {

                if (DALFaculty.Instance.UpdateFaculty(maKhoa, tenKhoa, sDT, email) != 0)
                {
                    return "";
                }
                else
                {
                    return "Cập Nhật Không Thành Công";
                }


            }
        }

        public string DeleteFaculty(string maKhoa)
        {
            if (DALLecturer.Instance.GetGiangVienByIDKhoa(maKhoa).Rows.Count == 0)
            {
                DALFaculty.Instance.DeleteFaculty(maKhoa);
                return "";
            }
            else
            {
                return "Không Thể Xóa Khoa Này";
            }
        }

        public void FilterFaculty(DataGridView datagird, string column, string value)
        {
            datagird.DataSource = DALFaculty.Instance.FilterFaculty(column, value);
        }
    }
}
