using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Dentist_Clinic_Management_UI.DTO_Dentist_Clinic_Management
{
    public class MedicineDTO
    {
        public MedicineDTO(string MaThuoc, string TenThuoc, string ChiDinh, string DonViTinh, double DonGia, int LuongTonKho, DateTime NgayHetHan)
        {
            this.IDThuoc = MaThuoc;
            this.Ten_Thuoc = TenThuoc;
            this.Chi_Dinh= ChiDinh;
            this.DVT = DonViTinh;
            this.Don_Gia = DonGia;
            this.Luong_Ton_Kho = LuongTonKho;
            this.Ngay_HetHan = NgayHetHan;
        }

        public MedicineDTO(DataRow row)
        {
            this.IDThuoc = row["MaThuoc"].ToString();
            this.Ten_Thuoc = row["TenThuoc"].ToString();
            this.Chi_Dinh = row["ChiDinh"].ToString();
            this.DonVi_Tinh = row["DonViTinh"].ToString();
            this.Don_Gia = Convert.ToDouble(row["DonGia"]);
            this.Luong_Ton_Kho = (int)row["LuongTonKho"];
            this.Ngay_HetHan = (DateTime)row["NgayHetHan"];
        }
        private string MaThuoc;

        public string IDThuoc { get => MaThuoc; set => MaThuoc = value; }

        private string TenThuoc;
        public string Ten_Thuoc { get => TenThuoc; set => TenThuoc = value; }


        private string ChiDinh;

        public string Chi_Dinh { get => ChiDinh; set => ChiDinh = value; }

        private double DonGia;
        public double Don_Gia { get => DonGia; set => DonGia = value; }
        private int LuongTonKho;
        public int Luong_Ton_Kho { get => LuongTonKho; set => LuongTonKho = value; }
        private string DVT;
        public string DonVi_Tinh { get => DVT; set => DVT = value; }
        private DateTime NgayHetHan; 
        public DateTime Ngay_HetHan { get => NgayHetHan; set => NgayHetHan = value; }
         }
}
