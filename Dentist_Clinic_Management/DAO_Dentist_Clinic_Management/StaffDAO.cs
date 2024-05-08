using Dentist_Clinic_Management_UI.DTO_Dentist_Clinic_Management;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist_Clinic_Management_UI.DAO_Dentist_Clinic_Management
{
    public class StaffDAO
    {
        private static StaffDAO instance;
        public static StaffDAO Instance
        {
            get { if (instance == null) instance = new StaffDAO(); return instance; }
            private set { instance = value; }
        }
        private StaffDAO() { }
        public List<StaffDTO> GetStaffList()
        {
            List<StaffDTO> list = new List<StaffDTO>();
            string query = "select * from NguoiDung where VaiTro = 1";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in data.Rows)
            {
                StaffDTO staff = new StaffDTO(dr);
                list.Add(staff);
            }
            return list;
        }
        public List<StaffDTO> SearchStaff(string name)
        {
            List<StaffDTO> list = new List<StaffDTO>();
            string query = string.Format("select * from NguoiDung where VaiTro = 1 and HoTen like N'%{0}%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in data.Rows)
            {
                StaffDTO staff = new StaffDTO(dr);
                list.Add(staff);
            }
            return list;
        }
        public bool InsertStaff(string id, string name, string pass)
        {
            string query = string.Format("INSERT dbo.NguoiDung (MaNguoiDung, HoTen, VaiTro, MatKhau) VALUES ('{0}', N'{1}',1 , '{2}')", id, name, pass);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateStaff(string id, string name, string pass)
        {
            string query = string.Format("UPDATE dbo.NguoiDung SET Hoten = N'{0}', MatKhau = '{1}' WHERE MaNguoiDung = '{2}'", name, pass, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteStaff(string id)
        {
            string query = string.Format("Delete NguoiDung where MaNguoiDung = '{0}'", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
