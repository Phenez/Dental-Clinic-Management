using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist_Clinic_Management_UI.DTO_Dentist_Clinic_Management
{
    public class StaffDTO
    {
        public StaffDTO(string MaNguoiDung, string HoTen, int VaiTro, string MatKhau)
        {
            this.Ma_NguoiDung = MaNguoiDung;
            this.Ho_Ten = HoTen;
            this.Vai_Tro = VaiTro;
            this.Mat_Khau = MatKhau;
        }
        public StaffDTO(DataRow row)
        {
            this.Ma_NguoiDung = row["MaNguoiDung"].ToString();
            this.Ho_Ten = row["HoTen"].ToString();
            this.Vai_Tro = Convert.ToInt32(row["VaiTro"]);
            this.Mat_Khau = row["MatKhau"].ToString();
        }
        private string MaNguoiDung;

        public string Ma_NguoiDung { get => MaNguoiDung; set => MaNguoiDung = value; }
        private string HoTen;
        public string Ho_Ten { get => HoTen; set => HoTen = value; }
        private int VaiTro;
        public int Vai_Tro { get => VaiTro; set => VaiTro = value; }
        private string MatKhau;
        public string Mat_Khau { get => MatKhau; set => MatKhau = value; }
    }
}
