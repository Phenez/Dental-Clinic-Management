using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist_Clinic_Management_UI.DTO_Dentist_Clinic_Management
{
    public class DentistDTO
    {
        public DentistDTO(string MaNS, string HoTen, int VaiTro, string MatKhau, string ChuyenMon)
        {
            this.Ma_NS = MaNS;
            this.Ho_Ten = HoTen;
            this.Vai_Tro = VaiTro;
            this.Mat_Khau = MatKhau;
            this.Chuyen_Mon = ChuyenMon;
        }
        public DentistDTO(DataRow row)
        {
            this.Ma_NS = row["MaNS"].ToString();
            this.Ho_Ten = row["HoTen"].ToString();
            this.Vai_Tro = Convert.ToInt32(row["VaiTro"]);
            this.Mat_Khau = row["MatKhau"].ToString();
            this.Chuyen_Mon = row["ChuyenMon"].ToString();
        }
        private string MaNS;

        public string Ma_NS { get => MaNS; set => MaNS = value; }
        private string HoTen;
        public string Ho_Ten { get => HoTen; set => HoTen = value; }
        private int VaiTro;
        public int Vai_Tro { get => VaiTro; set => VaiTro = value; }
        private string MatKhau;
        public string Mat_Khau { get => MatKhau; set => MatKhau = value; }

        private string ChuyenMon;

        public string Chuyen_Mon { get => ChuyenMon; set => ChuyenMon = value; }
    }
}
