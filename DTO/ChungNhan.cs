using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChungNhan
    {
        public string MaChungNhan { get; set; }
        public string TenChungNhan { get; set; }
        public string NgayCap { get; set; }
        public string XepLoai { get; set; }

        public ChungNhan() { }
        public ChungNhan(string macn, string tencn, string ngaycap, string loai)
        {
            this.MaChungNhan = macn;
            this.TenChungNhan = tencn;
            this.NgayCap = ngaycap;
            this.XepLoai = loai;
        }
    }
}
