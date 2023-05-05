using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HocVien
    {
        public string MaHocVien { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string NgaySinh { get; set; }
        public string SDTGiaDinh { get; set; }
        public string SDTCaNhan { get; set; }
        public string MaChungNhan { get; set; }
        public byte[] Anh { get; set; }

        public HocVien() { }
        public HocVien(string mahv, string hoten, string diachi, string ngaysinh, string sdtgd, string sdtcn, string macn)
        {
            this.MaHocVien = mahv;
            this.HoTen = hoten;
            this.DiaChi = diachi;
            this.NgaySinh = ngaysinh;
            this.SDTGiaDinh = sdtgd;
            this.SDTCaNhan = sdtcn;
            this.MaChungNhan = macn;
        }
        public HocVien(string mahv, string hoten, string diachi, string ngaysinh, string sdtgd, string sdtcn, string macn, byte[] anh)
        {
            this.MaHocVien = mahv;
            this.HoTen = hoten;
            this.DiaChi = diachi;
            this.NgaySinh = ngaysinh;
            this.SDTGiaDinh = sdtgd;
            this.SDTCaNhan = sdtcn;
            this.MaChungNhan = macn;
            this.Anh = anh;
        }
    }
}
