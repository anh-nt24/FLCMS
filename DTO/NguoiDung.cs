using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguoiDung
    {
        public string MaND { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public string Taikhoan { get; set; }
        public string MatKhau { get; set; }
        public string Quyen { get; set; }
        public string NgaySinh { get; set; }
        public string ViTriLamViec { get; set; }
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

        public NguoiDung(string taikhoan, string matkhau, string email, string quyen)
        {
            this.Taikhoan = taikhoan;
            this.MatKhau = matkhau;
            this.Email = email;
            this.Quyen = quyen; 
        }

        public NguoiDung(string mand,string hoten, string diachi,string sdt, string taikhoan, string matkhau,string quyen, string ngaysinh, string vitrivieclam,string email)
        {
            this.MaND= mand;
            this.HoTen = hoten;
            this.DiaChi = diachi;
            this.Sdt = sdt;
            this.Taikhoan = taikhoan;
            this.MatKhau = matkhau;
            this.Quyen= quyen;
            this.NgaySinh = ngaysinh;
            this.ViTriLamViec = vitrivieclam;
            this.Email = email;
        }
    }
}
