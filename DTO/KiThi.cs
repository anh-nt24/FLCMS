using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KiThi
    {
        public string MaKiThi { get; set; }
        public string TenKiThi { get; set; }
        public string ThoiGianBatDau { get; set; }
        public string ThoiGianKetThuc { get; set; }
        public string MoTa { get; set; }

        public KiThi() { }
        public KiThi(string makithi, string tenkithi, string thoigianbatdau, string thoigianketthuc,string mota)
        {
            this.MaKiThi = makithi;
            this.TenKiThi = tenkithi;
            this.ThoiGianBatDau = thoigianbatdau;
            this.ThoiGianKetThuc = thoigianketthuc;
            this.MoTa  = mota;
        }
    }
}
