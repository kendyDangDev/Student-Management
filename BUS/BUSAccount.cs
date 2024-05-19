using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BUS
{
    public class BUSAccount
    {
        private static BUSAccount _instance;
        public static BUSAccount Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BUSAccount();
                }
                return _instance;
            }
        }

        public bool IsLogin(string username, string password)
        {
            return DALAccount.Instance.IsLogin(username, password).Rows.Count > 0;
        }

        public string Createaccount(string username, string password, string phoneNumber, string email)
        {
            Regex regexNumber = new Regex("^[0-9]+$");
            Regex regexEmail = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            if (!regexNumber.IsMatch(phoneNumber))
            {
                return "Số Điện Thoại Không Hợp Lệ";
            }
            if (!regexEmail.IsMatch(email))
            {
                return "Địa Chỉ Email Không Hợp Lệ";
            }
            if (DALAccount.Instance.GetAccountByUserName(username).Rows.Count == 0)
            {
                int result = DALAccount.Instance.CreateAccount(username, password, phoneNumber, email);
                if (result > 0)
                {
                    return "";
                }
                else
                {
                    return "Thêm Tài Khoản Không Thành Công";
                }
            }
            else
            {
                return "Username Đã Tồn Tại Cho Tài Khoản Khác";
            }
        }

  
 
        public string GetPassword(string username, string phonenumber, string email)
        {
            string Password = null;
            DataTable data = DALAccount.Instance.GetPassword(username, phonenumber, email);
            foreach (DataRow row in data.Rows)
            {
                Password = row[0].ToString();

            }
        
            if (DALAccount.Instance.CheckEmail(username, email).Rows.Count <= 0)
            {
                return "";

            }
            if (DALAccount.Instance.CheckPhoneNumber(username, phonenumber).Rows.Count <= 0)
            {
                return "";
            }

            return Password;
        }


        public string GrantPermission(string username, string accountType)
        {
            if (DALAccount.Instance.GetAccountByUserName(username).Rows.Count == 0)
            {
                return "Username không Tồn Tại";
            }
            else
            {

                if (DALAccount.Instance.GrantPermission(username, accountType) != 0)
                {
                    return "";
                }
                else
                {
                    return "Cập Nhật Không Thành Công";
                }


            }
        }
        public void UpdateLoginLog(string username)
        {
            DALAccount.Instance.UpdateLoginLog(username);

        }

        public void GetAllAccount(DataGridView datagird)
        {
            datagird.DataSource = DALAccount.Instance.GetAllAccount();
        }
        public void GetAccountByUsername(DataGridView datagird, string username)
        {
            datagird.DataSource = DALAccount.Instance.GetAccountByUsername(username);
        }
        public string DeleteAccount(string username)
        {
            if (DALAccount.Instance.GetAccountType(username).Rows.Count != 0)
            {
                return "Không thể xóa tài khoản quản trị";
            }
            if (DALAccount.Instance.GetAccountByUserName(username).Rows.Count != 0)
            {
                DALAccount.Instance.DeleteAccount(username);
                return "";
            }
            else
            {
                return $"UserName: {username} Không Tồn Tại";
            }
        }

        public string CheckAccountType(string username)
        {
            if (DALAccount.Instance.GetAccountType(username).Rows.Count > 0)
            {
                return "";
            }
            else
            {
                return "Tài Khoản Chưa Được Cấp Quyền";
            }
        }

        public string GetAccountTypeLogin(string username)
        {
            DataTable dataTable = DALAccount.Instance.GetAccountTypeLogin(username);
            return dataTable.Rows[0][0].ToString();
        }

        public string CheckExist(string username)
        {
            if (DALAccount.Instance.CheckExist(username).Rows.Count != 0)
            {
                return "";
            }
            else
            {
                return $"Tài Khoản Không Tồn Tại";
            }
        }
    }


}


