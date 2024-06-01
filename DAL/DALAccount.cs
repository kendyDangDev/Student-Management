using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DAL
{
    public class DALAccount
    {
        private static DALAccount _instance;
        public static DALAccount Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DALAccount();
                }
                return _instance;
            }
        }

        public DataTable IsLogin(string username, string password)
        {
            string query = "USP_GetAccountsLogin @Username , @Password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password /*list*/});

            return result;
        }

        public int CreateAccount(string username, string password, string phonenumber, string email)
        {
            if (GetAllUsername(username) == 0)
            {
                string query = "USP_AddAccount @username , @password , @Sdt , @email";
                return DataProvider.Instance.ExecuteNonQuery(query, new object[] { username, password, phonenumber, email });
            }
            else return -1;

        }

        public int GetAllUsername(string username)
        {
            string query = "select count(*) from TaiKhoan where USERNAME = '" + username + "'";
            return (int)DataProvider.Instance.ExecuteScalar(query);
        }

        public DataTable GetPassword(string username, string phonenumber, string email)
        {
            string query = "USP_ForgotPassword @Username , @PhoneNumber , @email";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, phonenumber, email});

            return result;
        }

        public DataTable GetAccountByUserName(string username)
        {
            string query = "select USERNAME from TAIKHOAN where username = @username";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { username });
        }

        public int GrantPermission(string us, string accountType)
        {
            string query = "USP_GrantPermission @Username , @permission ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { us, accountType });
        }
        public int UpdateLoginLog(string us)
        {
            string query = "USP_UpdateLoginLog @Username";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { us });
        }

        public DataTable GetAllAccount()
        {
            string query = "USP_GetAllAccount";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int DeleteAccount(string us)
        {
            string query = "delete TAIKHOAN where USERname = @US";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { us });
        }
        public DataTable GetAccountType(string username)
        {
            string query = "select accounttype from taikhoan where username = @username and (accounttype = 'admin' or accounttype = 'user')";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { username });
        }

        public int CheckAccountType(string us)
        {
            string query = "CheckTypeAccount @username";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { us });
        }

        public DataTable GetAccountTypeLogin(string username)
        {
            string query = "GetAccountType @username";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { username });
        }

        public DataTable CheckEmail(string us, string email)
        {
            string query = "USP_CheckEmail @username , @email";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { us, email });
        }

        public DataTable CheckPhoneNumber(string us, string phoneNumber)
        {
            string query = "USP_ChecKPhoneNumber @username , @PhoneNumber";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { us, phoneNumber });
        }

        //Check account
        public DataTable CheckExist(string us)
        {
            string query = "USP_CheckExist @username ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { us });

        }

        public DataTable GetAccountByUsername(string username)
        {
            string query = "USP_GetAccountByUserName @us";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { username });
        }
    }
}
