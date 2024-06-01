using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUSScore
    {
        private static BUSScore _instance;
        public static BUSScore Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BUSScore();
                }
                return _instance;
            }
        }
        public void GetAllScore(DataGridView datagird)
        {
            datagird.DataSource = DALScore.Instance.GetAllScore();
        }

        public string InsertScore(string diemGHP, string diemKTHP, string masv, string mahocphan)
        {
            Regex regex = new Regex(@"^-?\d+(\.\d+)?$");
            if (!regex.IsMatch(diemGHP) && !regex.IsMatch(diemKTHP))
            {
                return "Định Dạng Điểm Không Hợp Lệ";
            }
            else
            {
                float diemG = float.Parse(diemGHP);
                float diemK = float.Parse(diemKTHP);
                if (diemG < 0 || diemG > 10 || diemK < 0 || diemK > 10)
                {
                    return "Định Dạng Điểm Không Hợp Lệ";
                }
            }
            if (DALStudent.Instance.GetStudentByID(masv).Rows.Count > 0)
            {
                if(DALScore.Instance.GetScoreSubject(masv, mahocphan).Rows.Count == 0)
                {
                    if (DALScore.Instance.InsertScore(float.Parse(diemGHP), float.Parse(diemKTHP), masv, mahocphan) > 0)
                    {
                        return "";
                    }
                    else
                    {
                        return "Nhập Điểm Thất Bại";
                    }
                }
                else
                {
                    return "Sinh Viên Đã Có Điểm Môn Học Này";
                }
          
            }
            else
            {
                return "Sinh Viên Không Thuộc Lớp Này.";
            }
        }

        public string UpdateScore(string diemGHP, string diemKTHP, string masv, string mahocphan)
        {
            Regex regex = new Regex(@"^-?\d+(\.\d+)?$");
            if (!regex.IsMatch(diemGHP) && !regex.IsMatch(diemKTHP))
            {
                return "Định Dạng Điểm Không Hợp Lệ";
            }
            else
            {
                float diemG = float.Parse(diemGHP);
                float diemK = float.Parse(diemKTHP);
                if (diemG < 0 || diemG > 10 || diemK < 0 || diemK > 10)
                {
                    return "Định Dạng Điểm Không Hợp Lệ";
                }
            }
            if (DALScore.Instance.GetStudentByIDInScore(masv).Rows.Count > 0)
            {
                if (DALScore.Instance.GetScoreSubject(masv, mahocphan).Rows.Count != 0)
                {
                    if (DALScore.Instance.UpdateScore(float.Parse(diemGHP), float.Parse(diemKTHP), masv, mahocphan) > 0)
                    {
                        return "";
                    }
                    else
                    {
                        return "Cập Nhật Điểm Thất Bại";
                    }
                }
                else
                {
                    return "Sinh Viên Chưa Có Điểm Môn Học Này";
                }

            }
            else
            {
                return "Không Tồn Tại Sinh Viên Có Mã Này";
            }
        }

        public int DeleteScore(string mahp)
        {
            return DALScore.Instance.DeleteScore(mahp);
        }

        public void FilterScore(DataGridView datagird, string column, string value)
        {
            datagird.DataSource = DALScore.Instance.FilterScore(column, value);
        }

        public void SortDESC(DataGridView datagird)
        {
            datagird.DataSource = DALScore.Instance.SortDESC();
        }
        public void SortASC(DataGridView datagird)
        {
            datagird.DataSource = DALScore.Instance.SortASC();
        }
        public void SortDESC(DataGridView datagird, string maSV)
        {
            datagird.DataSource = DALScore.Instance.SortDESC(maSV);
        }
        public void SortASC(DataGridView datagird, string maSV)
        {
            datagird.DataSource = DALScore.Instance.SortASC(maSV);
        }

        public void GetScoreBymaSV(DataGridView datagird, string maSV)
        {
            datagird.DataSource = DALScore.Instance.GetScoreByMaSV(maSV);
        }

    }
}
