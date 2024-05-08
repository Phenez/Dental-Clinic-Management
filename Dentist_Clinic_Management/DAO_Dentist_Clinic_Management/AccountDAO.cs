using Dentist_Clinic_Management.DTO_Dentist_Clinic_Management;
using Dentist_Clinic_Management.DAO_Dentist_Clinic_Management;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Dentist_Clinic_Management_UI.DAO_Dentist_Clinic_Management;
using System.Xml.Linq;

namespace Dentist_Clinic_Management.DAO_Dentist_Clinic_Management
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set { AccountDAO.instance = value; }
        }
        private AccountDAO() { }

        public string ID { get; set; }
        public string Name { get; set; }
        public string Pass { get; set; }

        public bool login(string usename, string password, string role)
        {
            string query = "USP_Login @user , @pass , @role";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { usename, password, role });

            return result.Rows.Count > 0;
        }

        public bool account_lock(string username, string password, string role)
        {
            string query = "USP_Lock @user , @pass , @role";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password, role });

            return result.Rows.Count > 0;
        }

        public bool Insert_Account(string name, DateTime birth, string addr, string phone, string pass)
        {
            string query = "USP_AddClient @name , @birth , @addr , @phone , @pass";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, birth, addr, phone, pass });
            return result > 0;
        }

        public string GetClientName(string sdt, string pass)
        {
            string query = "USP_Clent_Name @SDT , @pass";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { sdt, pass });
            return result.ToString();
        }
        public string GetOtherName(string id)
        {
            string query = "USP_Other_Name @id";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { id });
            return result.ToString();
        }
        public string GetCM(string id)
        {
            string query = "GetChuyenMon @id";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { id });
            return result.ToString();
        }
    }
}
