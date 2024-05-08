using Dentist_Clinic_Management_UI.DTO_Dentist_Clinic_Management;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist_Clinic_Management_UI.DAO_Dentist_Clinic_Management
{
    public class PatientDAO
    {
        private static PatientDAO instance;

        public static PatientDAO Instance
        {
            get { if (instance == null) instance = new PatientDAO(); return PatientDAO.instance; }
            private set { PatientDAO.instance = value; }
        }

        private PatientDAO() { }

        public List<PatientDTO> GetPatientList(int id)
        {
            List<PatientDTO> list = new List<PatientDTO>();
            string query = "select * from NguoiDung, KhachHang where KhachHang.MaKH = NguoiDung.MaNguoiDung and KhachHang.MaKH = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow dr in data.Rows)
            {
                PatientDTO patient = new PatientDTO(dr);
                list.Add(patient);
            }
            return list;
        } 

        public List<PatientDTO> GetPatientList()
        {
            List <PatientDTO> list = new List<PatientDTO>();
            string query = "select * from NguoiDung, KhachHang where KhachHang.MaKH = NguoiDung.MaNguoiDung";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow dr in data.Rows)
            {
                PatientDTO patient= new PatientDTO(dr);
                list.Add(patient);
            }
            return list;
        }

        public List<PatientDTO> SearchPatient(string name)
        {
            List<PatientDTO> list = new List<PatientDTO>();
            string query = string.Format("select * from NguoiDung, KhachHang where KhachHang.MaKH = NguoiDung.MaNguoiDung and NguoiDung.HoTen like N'%{0}%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in data.Rows)
            {
                PatientDTO patient = new PatientDTO(dr);
                list.Add(patient);
            }
            return list;
        }

        public bool InsertPatient(string id, string name, string pass, DateTime dob, string addr, string phone)
        {
            string query = string.Format("INSERT dbo.NguoiDung (MaNguoiDung, HoTen, VaiTro, MatKhau) VALUES ('{0}', N'{1}',3 , '{2}')", id, name, pass);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            query = string.Format("INSERT dbo.KhachHang (MaKH,NgaySinh,DiaChi,SDT) VALUES ('{0}', '{1}', N'{2}', '{3}')", id,dob,addr,phone);
            result += DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdatePatient(string id, string name, string pass, DateTime dob, string addr, string phone)
        {
            string query = string.Format("UPDATE dbo.NguoiDung SET Hoten = N'{0}', MatKhau = '{1}' WHERE MaNguoiDung = '{2}'", name, pass, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            query = string.Format("UPDATE dbo.KhachHang SET NgaySinh = '{0}', DiaChi = N'{1}', SDT = '{2}' WHERE MaKH = '{3}'", dob, addr, phone, id);
            result += DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeletePatient(string id)
        {
            string query = string.Format("Delete KhachHang where MaKH = '{0}'", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            query = string.Format("Delete NguoiDung where MaNguoiDung = '{0}'", id);
            result += DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}
