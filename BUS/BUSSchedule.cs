using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUSSchedule
    {
        private static BUSSchedule _instance;
        public static BUSSchedule Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BUSSchedule();
                }
                return _instance;
            }
        }

        public void GetAllPhongHoc(ComboBox cbx)
        {
            List<string> classList = new List<string>();
            DataTable dataTable = DALSchedule.Instance.GetAllPhongHoc();
            foreach (DataRow row in dataTable.Rows)
            {
                classList.Add(row[0].ToString());
            }
            cbx.DataSource = classList;
        }
        public void GetLectureBySubject(ComboBox cbx, string maHP)
        {
            List<string> classList = new List<string>();
            DataTable dataTable = DALSchedule.Instance.GetLectureBySubject(maHP);
            foreach (DataRow row in dataTable.Rows)
            {
                classList.Add(row[0].ToString());
            }
            cbx.DataSource = classList;
        }

        public void GetScheduleByWeekandClass(int tuan, string Class, DataGridView datagird)
        {
            datagird.DataSource = DALSchedule.Instance.GetScheduleByWeekandClass(tuan, Class);
        }
        public void GetScheduleByWeek(int tuan, DataGridView datagird)
        {
            datagird.DataSource = DALSchedule.Instance.GetScheduleByWeek(tuan);
        }
        public void GetScheduleByClass(string Class, DataGridView datagird)
        {
            datagird.DataSource = DALSchedule.Instance.GetScheduleByClass(Class);
        }

        public string InsertLichHoc(int thu, int tuan, int tietBatDau, int soTiet, string phongHoc, string malop, string maHocPhan, string maGiangVien)
        {
            if (DALSchedule.Instance.GetTietHoc(malop, thu, tuan).Rows.Count > 0)
            {
                List<string> classList = new List<string>();
                DataTable dataTable = DALSchedule.Instance.GetTietHoc(malop, thu, tuan);
                foreach (DataRow row in dataTable.Rows)
                {
                    classList.Add(row[0].ToString());
                }

                foreach (var item in classList)
                {
                    int tietBatDauCheck = Convert(item);
                    if (tietBatDau == tietBatDauCheck)
                    {
                        return "Lớp Đã Được Xếp Lịch Học";
                    }
                }
                string tietHoc = tietBatDau + "-" + (tietBatDau + soTiet);

                if (DALSchedule.Instance.USP_GetPhongHoc(thu, tuan, phongHoc, tietHoc).Rows.Count > 0)
                {
                    return "Phòng Học Này Đã Có Lớp Học";
                }

                if (DALSchedule.Instance.USP_GetGiangVien(thu, tuan, tietHoc, maGiangVien).Rows.Count != 0)
                {
                    return "Giảng Viên Này Đã Được Xếp Lịch Dạy";
                }

                DALSchedule.Instance.InsertSchedule(thu, tuan, tietHoc, phongHoc, malop, maHocPhan, maGiangVien);
                return "";

            }
            else
            {
                string tietHoc = tietBatDau + "-" + (tietBatDau + soTiet);
                if (DALSchedule.Instance.USP_GetPhongHoc(thu, tuan, phongHoc, tietHoc).Rows.Count > 0)
                {
                    return "Phòng Học Này Đã Có Lớp Học";
                }

                if (DALSchedule.Instance.USP_GetGiangVien(thu, tuan, tietHoc, maGiangVien).Rows.Count != 0)
                {
                    return "Giảng Viên Này Đã Được Xếp Lịch Dạy";
                }

                DALSchedule.Instance.InsertSchedule(thu, tuan, tietHoc, phongHoc, malop, maHocPhan, maGiangVien);
                return "";
            }
        }
        public string UpdateLichHoc(int thu, int tuan, int tietBatDau, int soTiet, string phongHoc, string malop, string maHocPhan, string maGiangVien, int id)
        {
            if (DALSchedule.Instance.GetTietHoc(malop, thu, tuan).Rows.Count > 0)
            {
                List<string> classList = new List<string>();
                DataTable dataTable = DALSchedule.Instance.GetTietHoc(malop, thu, tuan);
                foreach (DataRow row in dataTable.Rows)
                {
                    classList.Add(row[0].ToString());
                }

                foreach (var item in classList)
                {
                    int tietBatDauCheck = Convert(item);
                    if (tietBatDau == tietBatDauCheck)
                    {
                        return "Lớp Đã Được Xếp Lịch Học";
                    }
                }
                string tietHoc = tietBatDau + "-" + (tietBatDau + soTiet);

                if (DALSchedule.Instance.USP_GetPhongHoc(thu, tuan, phongHoc, tietHoc).Rows.Count > 0)
                {
                    return "Phòng Học Này Đã Có Lớp Học";
                }

                if (DALSchedule.Instance.USP_GetGiangVien(thu, tuan, tietHoc, maGiangVien).Rows.Count != 0)
                {
                    return "Giảng Viên Này Đã Được Xếp Lịch Dạy";
                }

                DALSchedule.Instance.UpdateSchedule(thu, tuan, tietHoc, phongHoc, malop, maHocPhan, maGiangVien, id);
                return "";

            }
            else
            {
                string tietHoc = tietBatDau + "-" + (tietBatDau + soTiet);
                if (DALSchedule.Instance.USP_GetPhongHoc(thu, tuan, phongHoc, tietHoc).Rows.Count > 0)
                {
                    return "Phòng Học Này Đã Có Lớp Học";
                }

                if (DALSchedule.Instance.USP_GetGiangVien(thu, tuan, tietHoc, maGiangVien).Rows.Count != 0)
                {
                    return "Giảng Viên Này Đã Được Xếp Lịch Dạy";
                }

                DALSchedule.Instance.UpdateSchedule(thu, tuan, tietHoc, phongHoc, malop, maHocPhan, maGiangVien, id);
                return "";
            }
        }


        public int Convert(string str)
        {
            Match match = Regex.Match(str, @"^\d+");
            return int.Parse(match.Value);
        }

        public int DeleteSchedule(int id)
        {
            return DALSchedule.Instance.DeleteSchedule(id);

        }
    }
}
