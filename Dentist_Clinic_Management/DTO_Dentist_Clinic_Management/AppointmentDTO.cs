using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist_Clinic_Management_UI.DTO_Dentist_Clinic_Management
{
    public class AppointmentDTO
    {
        public AppointmentDTO(string MaCuocHen, string MaNhaSi, string MaBenhNhan,
            string MaTroKham, DateTime NgayHen, DateTime ThoiGianHen, 
            string PhongKham, string LoaiCuocHen, string TinhTrang)
        {
            this.MaCuocHen1 = MaCuocHen;
            this.MaNhaSi1 = MaNhaSi;
            this.MaBenhNhan1 = MaBenhNhan;
            this.MaTroKham1 = MaTroKham;
            this.NgayHen1 = NgayHen;
            this.ThoiGianHen1 = ThoiGianHen;
            this.PhongKham1 = PhongKham;
            this.LoaiCuocHen1 = LoaiCuocHen;
            this.TinhTrang1 = TinhTrang;
        }

        public AppointmentDTO (DataRow row)
        {
            MaCuocHen1 = row["MaCuocHen"].ToString();
            MaNhaSi1 = row["MaNhaSi"].ToString();
            MaBenhNhan1 = row["MaBenhNhan"].ToString();
            MaTroKham1 = row["MaTroKham"].ToString();
            NgayHen1 = (DateTime)row["NgayHen"];
            ThoiGianHen1 = (DateTime)row["ThoiGianHen"];
            PhongKham1 = row["PhongKham"].ToString();
            LoaiCuocHen1 = row["LoaiCuocHen"].ToString();
            TinhTrang1 = row["TinhTrang"].ToString();
        }

        private string MaCuocHen;
        private string MaNhaSi;
        private string MaBenhNhan;
        private string MaTroKham;
        private DateTime NgayHen;
        private DateTime ThoiGianHen;
        private string PhongKham;
        private string LoaiCuocHen;
        private string TinhTrang;

        public string TenBenhNhan { get; set; }
        public string TenNhaSi { get; set; }
        public string TenTroKham { get; set; }
        public string MaCuocHen1 { get => MaCuocHen; set => MaCuocHen = value; }
        public string MaNhaSi1 { get => MaNhaSi; set => MaNhaSi = value; }
        public string MaBenhNhan1 { get => MaBenhNhan; set => MaBenhNhan = value; }
        public string MaTroKham1 { get => MaTroKham; set => MaTroKham = value; }
        public DateTime NgayHen1 { get => NgayHen; set => NgayHen = value; }
        public DateTime ThoiGianHen1 { get => ThoiGianHen; set => ThoiGianHen = value; }
        public string PhongKham1 { get => PhongKham; set => PhongKham = value; }
        public string LoaiCuocHen1 { get => LoaiCuocHen; set => LoaiCuocHen = value; }
        public string TinhTrang1 { get => TinhTrang; set => TinhTrang = value; }
    }
}
