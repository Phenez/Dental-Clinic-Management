using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist_Clinic_Management_UI.DTO_Dentist_Clinic_Management
{
    public class PatientDTO
    {
        public PatientDTO(string MaKH, string HoTen, int VaiTro, string MatKhau, DateTime dob, string DiaChi, string SDT)
        {
            this.Ma_KH = MaKH;
            this.Ho_Ten = HoTen;
            this.Vai_Tro = VaiTro;
            this.Mat_Khau = MatKhau;
            this.dateoB = dob;
            this.Dia_Chi = DiaChi;
            this.Sdt = SDT;
        }
        public PatientDTO(DataRow row)
        {
            this.Ma_KH = row["MaKH"].ToString();
            this.Ho_Ten = row["HoTen"].ToString();
            this.Vai_Tro = Convert.ToInt32(row["VaiTro"]);
            this.Mat_Khau = row["MatKhau"].ToString();
            this.dateoB = (DateTime)row["NgaySinh"];
            this.Dia_Chi = row["DiaChi"].ToString();
            this.Sdt = row["SDT"].ToString();
        }

        private string MaKH;

        public string Ma_KH { get => MaKH; set => MaKH = value; }
        private string HoTen;
        public string Ho_Ten { get => HoTen; set => HoTen = value; }
        private int VaiTro;
        public int Vai_Tro { get => VaiTro; set => VaiTro = value; }
        private string MatKhau;
        public string Mat_Khau { get => MatKhau; set => MatKhau = value; }
        private DateTime dob;
        public DateTime dateoB { get => dob; set => dob = value; }
        private string DiaChi;
        public string Dia_Chi { get => DiaChi; set => DiaChi = value; }
        private string SDT;
        public string Sdt { get => SDT; set => SDT = value; }
    }
}
