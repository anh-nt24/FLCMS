using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguoiDung
    {
        public string Taikhoan { get; set; }
        public string MatKhau { get; set; }
        public string Email { get; set; }
        public NguoiDung() { }
        public NguoiDung(string taikhoan, string matkhau) 
        {
            this.Taikhoan = taikhoan;
            this.MatKhau = matkhau;
        }
        public NguoiDung(string email)
        {
            this.Email = email;
        }
        public NguoiDung(string taikhoan, string matkhau, string email)
        {
            this.Taikhoan = taikhoan;
            this.MatKhau = matkhau;
            this.Email = email;
        }
    }
}
