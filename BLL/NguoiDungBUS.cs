using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class NguoiDungBUS
    {
        NguoiDungDAL nd = new NguoiDungDAL();
        public bool CheckLogin(NguoiDung nguoidung)
        {
            return nd.CheckLogin(nguoidung);
        }
        public bool CheckEmail(NguoiDung nguoidung)
        {
            return nd.CheckEmail(nguoidung);
        }
        public bool Checkmkmoitrungmkcu(NguoiDung nguoidung)
        {
            return nd.Checkmkmoitrungmkcu(nguoidung);
        }
        public void Thaydoimk(NguoiDung nguoidung)
        {
            nd.Thaydoimk(nguoidung);
        }

    }
}
