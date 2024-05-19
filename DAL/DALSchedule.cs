using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace DAL
{
    public class DALSchedule
    {
        private static DALSchedule _instance;
        public static DALSchedule Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DALSchedule();
                }
                return _instance;
            }
        }
        public DataTable GetScheduleByWeekandClass(int tuan, string Class)
        {
            string query = "USP_GetScheduleByWeekAndClass @week , @malop";
            return DataProvider.Instance.ExecuteQuery(query, new object[] {tuan, Class});
        }
        public DataTable GetAllPhongHoc()
        {
            string query = "select distinct phonghoc from thoikhoabieu";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetScheduleByWeek(int tuan)
        {
            string query = "USP_GetScheduleByWeek @week";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { tuan });
        }
        public DataTable GetScheduleByClass(string Class)
        {
            string query = "USP_GetScheduleByClass @malop";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { Class });
        }

        public DataTable GetTietHoc(string Class, int thu, int tuan)
        {
            string query = "USP_GetTietHoc @malop , @thu , @tuan";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { Class, thu, tuan });
        }

        public DataTable USP_GetPhongHoc(int thu, int tuan, string phongHoc, string tietHoc)
        {
            string query = "USP_GetPhongHoc @thu , @tuan , @phongHoc , @tietHoc";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { thu, tuan, phongHoc, tietHoc });
        }

        public DataTable USP_GetGiangVien(int thu, int tuan, string tietHoc,string maGiangVien)
        {
            string query = "USP_GetGV @thu , @tuan , @tietHoc , @maGV";
            return DataProvider.Instance.ExecuteQuery(query, new object[] {thu, tuan, tietHoc, maGiangVien });
        }

        public int InsertSchedule(int thu, int tuan, string tietHoc, string phongHoc, string maLop, string maHP, string maGV)
        {
            string query = "USP_InsertSchedule @thu , @tuan , @tietHoc , @phongHoc , @malop , @mahp , @magv";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { thu, tuan, tietHoc, phongHoc, maLop, maHP, maGV });
        }
        public int UpdateSchedule(int thu, int tuan, string tietHoc, string phongHoc, string maLop, string maHP, string maGV, int id)
        {
            string query = "USP_UpdateSchedule @thu , @tuan , @tietHoc , @phongHoc , @malop , @mahp , @magv , @id";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { thu, tuan, tietHoc, phongHoc, maLop, maHP, maGV, id });
        }

        public DataTable GetLectureBySubject(string maHP)
        {
            string query = "USP_GetLectureBySubject @maHP";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { maHP });
        }

        public int DeleteSchedule(int id)
        {
            string query = "USP_DeleteSchedule @id";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
        }
    }
}
