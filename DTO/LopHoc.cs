using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LopHoc
    {
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public string TenPhongHoc { get; set; }
        public string NgayBatDau { get; set; }

        public LopHoc() { }
        public LopHoc(string malh, string tenlh, string tenph, string ngaybd)
        {
            this.MaLop = malh;
            this.TenLop = tenlh;
            this.TenPhongHoc = tenph;
            this.NgayBatDau = ngaybd;
        }
    }
}
