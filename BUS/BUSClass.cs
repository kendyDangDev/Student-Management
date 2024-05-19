using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BUS
{
    public class BUSClass
    {
        private static BUSClass _instance;
        public static BUSClass Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BUSClass();
                }
                return _instance;
            }
            set => _instance = value;
        }

        public void GetAllLopHoc(ComboBox cbx)
        {
            List<string> classList = new List<string>();
            DataTable dataTable = DALClass.Instance.GetAllLopHoc();
            foreach (DataRow row in dataTable.Rows)
            {
                classList.Add(row[0].ToString());
            }
            cbx.DataSource = classList;
        }
        //public void GetClassByID(ComboBox cbx, string malop)
        //{
        //    List<string> classList = new List<string>();
        //    DataTable dataTable = DALClass.Instance.GetClassByID(malop);
        //    foreach (DataRow row in dataTable.Rows)
        //    {
        //        classList.Add(row[0].ToString());
        //    }
        //    cbx.DataSource = classList;
        //}
        public string GetIDByName(string name)
        {
            string result = "";
            DataTable dataTable = DALClass.Instance.GetIDByName(name);

            foreach (DataRow row in dataTable.Rows)
            {
                result = row[0].ToString();
            }
            return result;
        }


        public void GetAllClass(DataGridView datagrid)
        {
            datagrid.DataSource = DALClass.Instance.GetAllClass();
        }

        public string InsertClass(string malop, string tenlop, string hedaotao, string maGV, string machuyennganh)
        {
            if (DALClass.Instance.GetClassByID(malop).Rows.Count > 0)
            {
                return "Lớp Có Mã Này Đã Tồn Tại";
            }
            else
            {
                if (DALClass.Instance.GetClassByName(tenlop).Rows.Count > 0)
                {
                    return "Lớp Có Tên Này Đã Tồn Tại";
                }
                else
                {
                    if (DALClass.Instance.InsertClass(malop, tenlop, hedaotao, maGV, machuyennganh) > 0)
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
        public string UpdateClass(string malop, string tenlop, string hedaotao, string maGV, string machuyennganh)
        {
            if (DALClass.Instance.GetClassByID(malop).Rows.Count == 0)
            {
                return "Lớp Có Mã Này Không Tồn Tại Tồn Tại";
            }
            else
            {
                if (DALClass.Instance.UpdateClass(malop, tenlop, hedaotao, maGV, machuyennganh) != 0)
                {
                    return "";
                }
                else
                {
                    return "Cập Nhật Không Thành Công";
                }

            }
        }

        public int DeleteClass(string malop)
        {
            return DALClass.Instance.DeleteClass(malop);
        }

        public void FilterClass(DataGridView datagird, string column, string value)
        {
            datagird.DataSource = DALClass.Instance.FilterClass(column, value);
        }

        public int SelectCount()
        {
            return int.Parse(DALClass.Instance.SelectCount().Rows[0][0].ToString());
        }
    }
}
