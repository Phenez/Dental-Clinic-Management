using Dentist_Clinic_Management_UI.DTO_Dentist_Clinic_Management;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist_Clinic_Management_UI.DAO_Dentist_Clinic_Management
{
    public class MedicineDAO
    {
        private static MedicineDAO instance;

        public static MedicineDAO Instance
        {
            get {if (instance == null) instance = new MedicineDAO(); return MedicineDAO.instance; }
            private set { MedicineDAO.instance = value; }
        }
        private MedicineDAO() { }

        public List<MedicineDTO> GetMedicinesList (int id)
        {
            List<MedicineDTO> list = new List<MedicineDTO>();
            string query = "select * from Thuoc where MaThuoc = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in data.Rows)
            {
                MedicineDTO medicine = new MedicineDTO(dr);
                list.Add(medicine);
            }
            return list;
        }
        public List<MedicineDTO>  GetListMedicine()
        {
            List<MedicineDTO> list = new List<MedicineDTO>();
            string query = "select * from dbo.Thuoc";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in data.Rows)
            {
                MedicineDTO medicine = new MedicineDTO(dr);
                list.Add(medicine);
            }
            return list;
        }

        public List<MedicineDTO> SearchMedicine(string name)
        {
            List<MedicineDTO> list = new List<MedicineDTO>();
            string query = string.Format("select * from dbo.Thuoc where TenThuoc like N'%{0}%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in data.Rows)
            {
                MedicineDTO medicine = new MedicineDTO(dr);
                list.Add(medicine);
            }
            return list;
        }
        //public List<MedicineDTO> EndMedicine(DateTime end)
        //{
        //    List<MedicineDTO> list = new List<MedicineDTO>();
        //    string query = "select * from dbo.Thuoc where NgayHetHan < " + end;
        //    DataTable data = DataProvider.Instance.ExecuteQuery(query);
        //    foreach (DataRow dr in data.Rows)
        //    {
        //        MedicineDTO medicine = new MedicineDTO(dr);
        //        list.Add(medicine);
        //    }
        //    return list;
        //}
        public bool InsertMedicine(string id, string name, string detail, string unit, double cost, int available, DateTime enddate)
        {
            string query = string.Format("INSERT dbo.Thuoc (MaThuoc, TenThuoc, ChiDinh, DonViTinh, DonGia, LuongTonKho, NgayHetHan) VALUES ('{0}', N'{1}', N'{2}', N'{3}', N'{4}', '{5}','{6}')",id,name,detail,unit,cost,available,enddate);

            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateMedicine(string id, string name, string detail, string unit, double cost, int available, DateTime enddate)
        {
            string query = string.Format("UPDATE dbo.Thuoc SET TenThuoc = N'{0}', ChiDinh = N'{1}', DonViTinh = N'{2}', DonGia = N'{3}',LuongTonKho = '{4}', NgayHetHan = '{5}' WHERE MaThuoc = '{6}'", name, detail, unit, cost, available, enddate,id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteMedicine(string id)
        {

            string query = string.Format("Delete Thuoc where MaThuoc = '{0}'", id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
