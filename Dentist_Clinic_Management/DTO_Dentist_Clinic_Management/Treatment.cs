using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist_Clinic_Management_UI.DTO_Dentist_Clinic_Management
{
    public class Treatment
    {
        private string idKH;
        private string idBN;
        private string mota;
        private DateTime ngayDT;
        private string note;
        private decimal phi;
        private string TrangThai;
        private string MaDieuTri;

        public string IdKH { get => idKH; set => idKH = value; }
        public string IdBN { get => idBN; set => idBN = value; }
        public string Mota { get => mota; set => mota = value; }
        public DateTime NgayDT { get => ngayDT; set => ngayDT = value; }
        public string Note { get => note; set => note = value; }
        public decimal Phi { get => phi; set => phi = value; }
        public string TrangThai1 { get => TrangThai; set => TrangThai = value; }
        public string MaDieuTri1 { get => MaDieuTri; set => MaDieuTri = value; }
    }
}
