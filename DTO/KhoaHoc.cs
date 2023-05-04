using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhoaHoc
    {
        public string MaKH { get; set; }
        public string TenKhoaHoc { get; set; }
        public string CapDo { get; set; }
        public string SoBuoi { get; set; }
        public string HocPhi { get; set; }
        public string MaLop { get; set; }

        public KhoaHoc() { }
        public KhoaHoc(string makh, string tenkh, string capdo, string sobuoi, string hocphi, string malop)
        {
            this.MaKH = makh;
            this.TenKhoaHoc = tenkh;
            this.CapDo = capdo;
            this.SoBuoi = sobuoi;
            this.HocPhi = hocphi;
            this.MaLop = malop;
        }
    }
}
