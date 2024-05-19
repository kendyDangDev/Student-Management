using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUSSubject
    {
        private static BUSSubject _instance;
        public static BUSSubject Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BUSSubject();
                }
                return _instance;
            }
        }

        public void GetAllSubject(ComboBox cbx)
        {
            List<string> classList = new List<string>();
            DataTable dataTable = DALSubject.Instance.GetAllSubject();
            foreach (DataRow row in dataTable.Rows)
            {
                classList.Add(row[0].ToString());
            }
            cbx.DataSource = classList;
        }

        public string GetIDByName(string name)
        {
            string result = "";
            DataTable dataTable = DALSubject.Instance.GetIDByName(name);

            foreach (DataRow row in dataTable.Rows)
            {
                result = row[0].ToString();
            }
            return result;
        }

        public void GetAllHocPhan(DataGridView datagrid)
        {
            datagrid.DataSource = DALSubject.Instance.GetAllHocPhan();
        }

        public string InsertSubject(string mahp, string tenhp, int sotc,string loaiHP, string Khoa)
        {
            if (DALSubject.Instance.GetSubjectByID(mahp).Rows.Count > 0)
            {
                return "Học Phần Có Mã Này Đã Tồn Tại";
            }
            else
            {
                if (DALSubject.Instance.GetSubjectByName(tenhp).Rows.Count > 0)
                {
                    return "Học Phần Có Tên Này Đã Tồn Tại";
                }
                else
                {
                    if (DALSubject.Instance.InsertSubject(mahp, tenhp, sotc, loaiHP, Khoa) > 0)
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
        public string UpdateSubject(string mahp, string tenhp, int sotc, string loaiHP, string Khoa)
        {
            if (DALSubject.Instance.GetSubjectByID(mahp).Rows.Count == 0)
            {
                return "Học Phần Có Mã Này Không Tồn Tại Tồn Tại";
            }
            else
            {

                if (DALSubject.Instance.UpdateSubject(mahp, tenhp, sotc, loaiHP, Khoa) != 0)
                {
                    return "";
                }
                else
                {
                    return "Cập Nhật Không Thành Công";
                }


            }
        }

        public int DeleteSubject(string mahp)
        {
            return DALSubject.Instance.DeleteSubject(mahp);
        }

        public void FilterSubject(DataGridView datagird, string column, string value)
        {
            datagird.DataSource = DALSubject.Instance.FilterSubject(column, value);
        }
        public int SelectCount()
        {
            return int.Parse(DALSubject.Instance.selectCount().Rows[0][0].ToString());
        }
    }
}
