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
    public class BUSMajor
    {
        private static BUSMajor _instance;
        public static BUSMajor Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BUSMajor();
                }
                return _instance;
            }
        }
        public void GetAllMajorName(ComboBox cbx)
        {
            List<string> classList = new List<string>();
            DataTable dataTable = DALMajor.Instance.GetAllMajorName();
            foreach (DataRow row in dataTable.Rows)
            {
                classList.Add(row[0].ToString());
            }
            cbx.DataSource = classList;
        }
        public string GetIDByName(string name)
        {
            string result = "";
            DataTable dataTable = DALMajor.Instance.GetIDByName(name);

            foreach (DataRow row in dataTable.Rows)
            {
                result = row[0].ToString();
            }
            return result;
        }

        public void GetAllMajor(DataGridView datagrid)
        {
            datagrid.DataSource = DALMajor.Instance.GetAllMajor();
        }
        public string InsertMajor(string maNganh, string tenNganh, string maKhoa)
        {
            if (DALMajor.Instance.GetMajorByID(maNganh).Rows.Count > 0)
            {
                return "Ngành Có Mã Này Đã Tồn Tại";
            }
            else
            {
                if (DALMajor.Instance.GetMajorByName(tenNganh).Rows.Count > 0)
                {
                    return "Ngành Có Tên Này Đã Tồn Tại";
                }
                else
                {
                    if (DALMajor.Instance.InsertMajor(maNganh, tenNganh, maKhoa) > 0)
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

        public string UpdateMajor(string maNganh, string tenNganh, string maKhoa)
        {
            if (DALMajor.Instance.GetMajorByID(maNganh).Rows.Count == 0)
            {
                return "Mã Ngành Không Tồn Tại";
            }
            else
            {
                if (DALMajor.Instance.GetMajorByName(tenNganh).Rows.Count > 1)
                {
                    return "Ngành Có Tên Này Đã Tồn Tại";
                }
                else
                {
                    if (DALMajor.Instance.UpdateMajor(maNganh, tenNganh, maKhoa) != 0)
                    {
                        return "";
                    }
                    else
                    {
                        return "Cập Nhật Không Thành Công";
                    }

                }
            }
        }

        public int DeleteMajor(string maNganh)
        {
            return DALMajor.Instance.DeleteMajor(maNganh);
        }

        public void FilterMajor(DataGridView datagird, string column, string value)
        {
            datagird.DataSource = DALMajor.Instance.FilterMajor(column, value);
        }
    }
}
