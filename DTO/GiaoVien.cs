using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiaoVien
    {
        public string MaGiaoVien { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public string NgaySinh { get; set; }
        public string NgayVaoLam { get; set; }
        public string ChuyenMon { get; set; }
        public string BangCap { get; set; }
        public string MaHopDong { get; set; }
        public string MaLop { get; set; }
        public byte[] Anh { get; set; }



        public GiaoVien() { }
        public GiaoVien(string magv, string hoten, string diachi, string sdt, string ns, string nvl, string chuyenmon, string bangcap, string mahd, string malop)
        {
            this.MaGiaoVien = magv;
            this.HoTen = hoten;
            this.DiaChi = diachi;
            this.Sdt = sdt;
            this.NgaySinh = ns;
            this.NgayVaoLam = nvl;
            this.ChuyenMon = chuyenmon;
            this.BangCap = bangcap;
            this.MaHopDong = mahd;
            this.MaLop = malop;
        }
        public GiaoVien(string magv, string hoten, string diachi, string sdt, string ns, string nvl, string chuyenmon, string bangcap, string mahd, string malop, byte[] anh)
        {
            this.MaGiaoVien = magv;
            this.HoTen = hoten;
            this.DiaChi = diachi;
            this.Sdt = sdt;
            this.NgaySinh = ns;
            this.NgayVaoLam = nvl;
            this.ChuyenMon = chuyenmon;
            this.BangCap = bangcap;
            this.MaHopDong = mahd;
            this.MaLop = malop;
            this.Anh = anh;
        }

    }
}
