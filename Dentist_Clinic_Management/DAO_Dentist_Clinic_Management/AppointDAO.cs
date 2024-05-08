using Dentist_Clinic_Management_UI.DAO_Dentist_Clinic_Management;
using Dentist_Clinic_Management_UI.DTO_Dentist_Clinic_Management;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dentist_Clinic_Management.DAO_Dentist_Clinic_Management
{
    public class AppointDAO
    {
        private static AppointDAO instance;

        public static AppointDAO Instance
        {
            get { if (instance == null) instance = new AppointDAO(); return AppointDAO.instance; }
            private set { AppointDAO.instance = value; }
        }
        private AppointDAO() { }
        public string name { get; set; }
        public string phone { get; set; }
        public string ID_C { get; set; }
        public DateTime Date { get; set; }
        public string Dentist { get; set; }
        public string Day { get; set; }
        public string Hour { get; set; }
        public string ID_D { get; set; }
        public string ID_S { get; set; }
        public DateTime Date_Book { get; set; }
        public int Status { get; set; }

        public string GetIDDentist(string name)
        {
            string query = "USP_Get_ID @Hoten";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { name });
            return result.ToString();
        }
        public DataTable GetListDentist(DateTime date)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_Dentist_Ranh @Hen", new object[] { date });
        }

        public bool Insert_Appoint(string id_K, DateTime date, string id_N, DateTime book)
        {
            string query = "USP_AddAppoint @id , @date , @id2 , @book";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id_K, date, id_N, book });
            return result > 0;
        }
        public DataTable GetListAppoint(string id)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_ListAppoint @id", new object[] { id });
        }
        public bool CancelAppoint(string id, DateTime hen)
        {
            string query = "USP_CanceledAppoint @id , @hen";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, hen });
            return result > 0;
        }
        public bool Insert_Appoint_NoAcc(string name, DateTime date, string addr, string phone, string id2, DateTime date2)
        {
            string query = "USP_AddAppoint_NoAccount @name , @date , @addr , @phone , @id2 , @date2";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name , date , addr , phone , id2 , date2 });
            return result > 0;
        }
        public bool PhoneFine(string phone)
        {
            string query = "USP_FindPhone @phone";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { phone });
            return result.Rows.Count > 0;
        }
        public DataTable GetListRec()
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_RecordList");
        }
        public DataTable FindListRec(string phone)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_FindRec @phone", new object[] { phone });
        }
        public bool Insert_Appoint_S(string name, string phone, string id3, DateTime book, DateTime date, string id2)
        {
            string query = "USP_AddAppoint_Staff @name , @phone , @id3 , @book , @date , @id2";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name , phone , id3 , book , date , id2 });
            return result > 0;
        }
        public bool Insert_D_A(string id, DateTime date, string id2, DateTime date2)
        {
            string query = "USP_Add_App_Dent @id , @date , @id2 , @date2";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id , date , id2 , date2 });
            return result > 0;
        }

    }
}
