using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUSStudent
    {
        private static BUSStudent _instance;
        public static BUSStudent Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BUSStudent();
                }
                return _instance;
            }
        }

        public void GetAllStudent(DataGridView data)
        {
            data.DataSource = DALStudent.Instance.GetAllStudent();
        }
        public DataTable GetAllStudent()
        {
            return DALStudent.Instance.GetAllStudent();

        }

        public string AddHoSoSinhVien(string masv,
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
            Regex regexString = new Regex(@"^[\p{L} ]+$");
            Regex regexNumber = new Regex("^[0-9]+$");
            Regex regexEmail = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            if (!regexString.IsMatch(hoten))
            {
                return "Họ Tên Không Hợp Lệ";
            }

            if (!regexNumber.IsMatch(sdt) || !regexNumber.IsMatch(socccd) || !regexNumber.IsMatch(sdtnt))
            {
                return "Số Điện Thoại Hoặc Số CCCD Không Hợp Lệ";
            }
            if (!regexEmail.IsMatch(email))
            {
                return "Địa Chỉ Email Không Hợp Lệ";
            }
            if (DateTime.Now.Year - ngaysinh.Year < 18)
            {
                return "Ngày Sinh Không Hợp Lệ. Bạn Chưa Đủ 18 Tuổi";
            }

            if (DALStudent.Instance.GetStudentByID(masv).Rows.Count == 0)
            {
                if (DALStudent.Instance.GetStudentByCCCD(socccd).Rows.Count == 0)
                {
                    int result = DALStudent.Instance.AddHoSoSinhVien(masv, hoten, gioitinh, dantoc, ngaysinh, diachi, sdt, email, socccd, nienkhoa, namnhaphoc, malop, hotennt, quanhe, ngaysinhnt, sdtnt);
                    if (result > 0)
                    {
                        return "";
                    }
                    else
                    {
                        return "Thêm Sinh Viên Không Thành Công";
                    }
                }
                else
                {
                    return "Số CCCD Đã Tồn Tại Cho Sinh Viên Khác";
                }

            }
            else
            {
                return "Đã Tồn Tại Sinh Viên Có Mã Này";
            }
        }
        public string UpdateHoSoSinhVien(string masv,
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
            Regex regexString = new Regex(@"^[\p{L} ]+$");
            Regex regexNumber = new Regex("^[0-9]+$");
            Regex regexEmail = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            if (!regexString.IsMatch(hoten))
            {
                return "Họ Tên Không Hợp Lệ";
            }

            if (!regexNumber.IsMatch(sdt) || !regexNumber.IsMatch(socccd) || !regexNumber.IsMatch(sdtnt))
            {
                return "Số Điện Thoại Hoặc Số CCCD Không Hợp Lệ";
            }
            if (!regexEmail.IsMatch(email))
            {
                return "Địa Chỉ Email Không Hợp Lệ";
            }
            if (DateTime.Now.Year - ngaysinh.Year < 18)
            {
                return "Ngày Sinh Không Hợp Lệ. Bạn Chưa Đủ 18 Tuổi";
            }

            if (!(DALStudent.Instance.GetStudentByID(masv).Rows.Count == 0))
            {
                if (DALStudent.Instance.GetStudentByCCCD(socccd).Rows.Count <= 1)
                {
                    int result = DALStudent.Instance.UpdateHoSoSinhVien(masv, hoten, gioitinh, dantoc, ngaysinh, diachi, sdt, email, socccd, nienkhoa, namnhaphoc, malop, hotennt, quanhe, ngaysinhnt, sdtnt);
                    if (result > 0)
                    {
                        return "";
                    }
                    else
                    {
                        return "Cập Nhật Thông Tin Sinh Viên Không Thành Công";
                    }
                }
                else
                {
                    return "Số CCCD Đã Tồn Tại Cho Sinh Viên Khác";
                }
            }
            else
            {
                return "Không Tồn Tại Sinh Viên có mã này";
            }

        }

        public bool DeleteStudent(string ID)
        {
            return DALStudent.Instance.DeleteStudent(ID) > 0;
        }

        public void FilterStudent(DataGridView data, string columnname, string value)
        {
            data.DataSource = DALStudent.Instance.FilterStudent(columnname, value);
        }

        public void GetStudent(DataGridView data, string username)
        {
            data.DataSource = DALStudent.Instance.GetStudent(username);
        }

        public string GetMalopByMaSV(string maSV)
        {
            if (DALStudent.Instance.GetMalopByMaSV(maSV).Rows.Count > 0)
            {
                return DALStudent.Instance.GetMalopByMaSV(maSV).Rows[0][0].ToString();
            }
            return "";
        }
        public int SelectCount()
        {
            return int.Parse(DALStudent.Instance.selectCount().Rows[0][0].ToString());
        }

        public string GetIDByName(string name)
        {
            string result = "";
            DataTable dataTable = DALStudent.Instance.GetIDByName(name);

            foreach (DataRow row in dataTable.Rows)
            {
                result = row[0].ToString();
            }
            return result;
        }

        public int GetNameStudentbyClass(ComboBox cbx, string malop)
        {
            List<string> classList = new List<string>();
            DataTable dataTable = DALStudent.Instance.GetNameStudentByClass(malop);
            foreach (DataRow row in dataTable.Rows)
            {
                classList.Add(row[0].ToString());
            }
            cbx.DataSource = classList;

            return dataTable.Rows.Count;

        }
    }
}
