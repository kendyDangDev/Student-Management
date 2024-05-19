using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUSSpecialty
    {
        private static BUSSpecialty _instance;
        public static BUSSpecialty Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BUSSpecialty();
                }
                return _instance;
            }
        }
        public void GetAllSpecialtyName(ComboBox cbx)
        {
            List<string> classList = new List<string>();
            DataTable dataTable = DALSpecialty.Instance.GetAllSpecialtyName();
            foreach (DataRow row in dataTable.Rows)
            {
                classList.Add(row[0].ToString());
            }
            cbx.DataSource = classList;
        }
        public string GetIDByName(string name)
        {
            string result = "";
            DataTable dataTable = DALSpecialty.Instance.GetIDByName(name);

            foreach (DataRow row in dataTable.Rows)
            {
                result = row[0].ToString();
            }
            return result;
        }

        public void GetAllSpecialty(DataGridView datagrid)
        {
            datagrid.DataSource = DALSpecialty.Instance.GetAllBranh();
        }
        public string InsertSpecialty(string macn, string tencn, string thoigiandaotao, string maNganh)
        {
            Regex regex = new Regex(@"^-?\d+(\.\d+)?$");
            if (!regex.IsMatch(thoigiandaotao))
            {
                return "Định Dạng Thời Gian Đào Tạo Không Hợp Lệ";
            }
            else
            {
                if (DALSpecialty.Instance.GetSpecialtyByID(macn).Rows.Count > 0)
                {
                    return "Chuyên ngành Có Mã Này Đã Tồn Tại";
                }
                else
                {
                    if (DALSpecialty.Instance.GetSpecialtyByName(tencn).Rows.Count > 0)
                    {
                        return "Chuyên ngành Có Tên Này Đã Tồn Tại";
                    }
                    else
                    {
                        if (DALSpecialty.Instance.InsertSpecialty(macn, tencn, int.Parse(thoigiandaotao), maNganh) > 0)
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
        }

        public string UpdateSpecialty(string macn, string tencn, string thoigiandaotao, string maNganh)
        {
            Regex regex = new Regex(@"^-?\d+(\.\d+)?$");
            if (!regex.IsMatch(thoigiandaotao))
            {
                return "Định Dạng Thời Gian Đào Tạo Không Hợp Lệ";
            }
            else
            {
                if (DALSpecialty.Instance.GetSpecialtyByID(macn).Rows.Count == 0)
                {
                    return "Chuyên Ngành Có Mã Này Không Tồn Tại";
                }
                else
                {

                    if (DALSpecialty.Instance.UpdateSpecialty(macn, tencn, int.Parse(thoigiandaotao), maNganh) != 0)
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

        public int DeleteSpecialty(string macn)
        {
            return DALSpecialty.Instance.DeleteSpecialty(macn);
        }

        public void FilterSpecialty(DataGridView datagird, string column, string value)
        {
            datagird.DataSource = DALSpecialty.Instance.FilterSpecialty(column, value);
        }

        public int SelectCount()
        {
            return int.Parse(DALSpecialty.Instance.selectCount().Rows[0][0].ToString());
        }
    }
}

