using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HopDong
    {
        public string MaHopDong { get; set; }
        public string TenHopDong { get; set; }
        public string NoiDung { get; set; }
        public string NgayLap { get; set; }
        public string ThoiHan { get; set; }

        public HopDong() { }
        public HopDong(string mahd, string tenhd, string nd, string ngayl, string thoihan)
        {
            this.MaHopDong = mahd;
            this.TenHopDong = tenhd;
            this.NoiDung = nd;
            this.NgayLap = ngayl;
            this.ThoiHan = thoihan;
        }
    }
}
