using Dentist_Clinic_Management_UI.DTO_Dentist_Clinic_Management;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist_Clinic_Management_UI.DAO_Dentist_Clinic_Management
{
    public class DentistDAO
    {
        private static DentistDAO instance;

        public static DentistDAO Instance
        {
            get { if (instance == null) instance = new DentistDAO(); return instance; }
            private set { instance = value; }
        }

        private DentistDAO() { }
        public List<DentistDTO> GetDentistList()
        {
            List<DentistDTO> list = new List<DentistDTO>();
            string query = "select * from NguoiDung, NhaSi where NhaSi.MaNS = NguoiDung.MaNguoiDung";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in data.Rows)
            {
                DentistDTO dentist = new DentistDTO(dr);
                list.Add(dentist);
            }
            return list;
        }
        public List<DentistDTO> SearchDentist(string name)
        {
            List<DentistDTO> list = new List<DentistDTO>();
            string query = string.Format("select * from NguoiDung, NhaSi where NhaSi.MaNS = NguoiDung.MaNguoiDung and NguoiDung.HoTen like N'%{0}%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in data.Rows)
            {
                DentistDTO dentist = new DentistDTO(dr);
                list.Add(dentist);
            }
            return list;
        }
        public bool InsertDentist(string id, string name, string pass, string specialize)
        {
            string query = string.Format("INSERT dbo.NguoiDung (MaNguoiDung, HoTen, VaiTro, MatKhau) VALUES ('{0}', N'{1}',2 , '{2}')", id, name, pass);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            query = string.Format("INSERT dbo.NhaSi (MaNS,ChuyenMon) VALUES ('{0}', N'{1}')", id, specialize);
            result += DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateDentist(string id, string name, string pass, string specialize)
        {
            string query = string.Format("UPDATE dbo.NguoiDung SET Hoten = N'{0}', MatKhau = '{1}' WHERE MaNguoiDung = '{2}'", name, pass, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            query = string.Format("UPDATE dbo.NhaSi SET ChuyenMon = '{0}' WHERE MaNS = '{1}'", specialize, id);
            result += DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteDentist(string id)
        {
            string query = string.Format("Delete NhaSi where MaNS = '{0}'", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            query = string.Format("Delete NguoiDung where MaNguoiDung = '{0}'", id);
            result += DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public DataTable GetListAppo( DateTime date, string id)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_SeenAppoint @date , @id", new object[] { date , id });
        }
        public DataTable GetFullList(string id)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_SeenAppointAll @id", new object[] { id });
        }
    }

}
