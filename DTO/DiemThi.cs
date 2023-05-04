using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DiemThi
    {
        public string MaHocVien { get; set; }
        public string MaKiThi { get; set; }
        public string NgayThi { get; set; }
        public string KetQuaThi { get; set; }
        public string DiemDanh { get; set; }

        public DiemThi() { }
        public DiemThi(string mahv, string makt, string ngaythi, string kqthi, string diemdanh)
        {
            this.MaHocVien = mahv;
            this.MaKiThi = makt;
            this.NgayThi = ngaythi;
            this.KetQuaThi = kqthi;
            this.DiemDanh = diemdanh;
        }
    }
}
