using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUSLecturer
    {
        private static BUSLecturer _instance;
        public static BUSLecturer Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BUSLecturer();
                }
                return _instance;
            }
        }

        public void GetAllGiangVien(DataGridView griddata)
        {
            griddata.DataSource = DALLecturer.Instance.GetAllGiangVien();
            foreach (DataGridViewColumn column in griddata.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        public string GetIDByName(string name)
        {
            string result = "";
            DataTable dataTable = DALLecturer.Instance.GetIDByName(name);

            foreach (DataRow row in dataTable.Rows)
            {
                result = row[0].ToString();
            }
            return result;
        }
        public void GetNameGiangVien(ComboBox cbx)
        {
            List<string> classList = new List<string>();
            DataTable dataTable = DALLecturer.Instance.GetNameGiangVien();
            foreach (DataRow row in dataTable.Rows)
            {
                classList.Add(row[0].ToString());
            }
            cbx.DataSource = classList;
        }


        public string InsertGiangVien(string maGV,
                                    string hoten,
                                    string gioitinh,
                                    string trinhdo,
                                    DateTime ngaysinh,
                                    string diachi,
                                    string socccd,
                                    string sdt,
                                    string makhoa)
        {
            Regex regexString = new Regex(@"^[\p{L} ]+$");
            Regex regexNumber = new Regex("^[0-9]+$");
            if (!regexString.IsMatch(hoten))
            {
                return "Họ Tên Không Hợp Lệ";
            }

            if (!regexNumber.IsMatch(sdt) || !regexNumber.IsMatch(socccd) || !regexNumber.IsMatch(sdt))
            {
                return "Số Điện Thoại Hoặc Số CCCD Không Hợp Lệ";
            }
            if (DateTime.Now.Year - ngaysinh.Year < 1)
            {
                return "Ngày Sinh Không Hợp Lệ.";
            }

            if (DALLecturer.Instance.GetGiangVienByID(maGV).Rows.Count == 0)
            {
                if (DALLecturer.Instance.GetSoCCCD(socccd).Rows.Count == 0)
                {
                    int result = DALLecturer.Instance.InsertGiangVien(maGV, hoten, gioitinh, trinhdo, ngaysinh, diachi, socccd, sdt, makhoa);
                    if (result > 0)
                    {
                        return "";
                    }
                    else
                    {
                        return "Thêm Thông Tin Giảng Viên Mới Thành Công";
                    }
                }
                else
                {
                    return "Số CCCD Đã Tồn Tại Cho Giảng Viên Khác";
                }

            }
            else
            {
                return "Giảng Viên Có Mã Này Đã Tồn Tại";
            }
        }

        public string UpdateGiangVien(string maGV,
                                    string hoten,
                                    string gioitinh,
                                    string trinhdo,
                                    DateTime ngaysinh,
                                    string diachi,
                                    string socccd,
                                    string sdt,
                                    string makhoa)
        {
            Regex regexString = new Regex(@"^[\p{L} ]+$");
            Regex regexNumber = new Regex("^[0-9]+$");
            if (!regexString.IsMatch(hoten))
            {
                return "Họ Tên Không Hợp Lệ";
            }

            if (!regexNumber.IsMatch(sdt) || !regexNumber.IsMatch(socccd) || !regexNumber.IsMatch(sdt))
            {
                return "Số Điện Thoại Hoặc Số CCCD Không Hợp Lệ";
            }
            if (DateTime.Now.Year - ngaysinh.Year < 1)
            {
                return "Ngày Sinh Không Hợp Lệ.";
            }

            if (!(DALLecturer.Instance.GetGiangVienByID(maGV).Rows.Count == 0))
            {
                if (DALLecturer.Instance.GetSoCCCD(socccd).Rows.Count <= 1)
                {
                    int result = DALLecturer.Instance.UpdateGiangVien(maGV, hoten, gioitinh, trinhdo, ngaysinh, diachi, socccd, sdt, makhoa);
                    if (result > 0)
                    {
                        return "";
                    }
                    else
                    {
                        return "Cập Nhật Thông Tin Giảng Viên Không Thành Công";
                    }
                }
                else
                {
                    return "Số CCCD Đã Tồn Tại Cho Giảng Viên Khác";
                }

            }
            else
            {
                return "Không Tồn Tại Giảng Viên có mã này";
            }
        }

        public bool DeleteGiangVien(string magv)
        {
            return DALLecturer.Instance.DeleteGiangVien(magv) > 0;

        }
        public void FilterLectures(DataGridView data, string columnname, string value)
        {
            data.DataSource = DALLecturer.Instance.FilterLectures(columnname, value);
        }
        public int SelectCount()
        {
            return int.Parse(DALLecturer.Instance.selectCount().Rows[0][0].ToString());
        }
    }

}
