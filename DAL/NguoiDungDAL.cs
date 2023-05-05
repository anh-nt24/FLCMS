using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class NguoiDungDAL: Database
    {
        public bool CheckLogin(NguoiDung nguoidung)
        {
            return CheckLoginDAL(nguoidung);
        }
        public bool CheckQuyen(NguoiDung nguoidung)
        {
            return CheckQuyenDAL(nguoidung);
        }

        public bool CheckEmail(NguoiDung nguoidung)
        {
            return CheckEmailDAL(nguoidung);
        }

        public bool Checkmkmoitrungmkcu(NguoiDung nguoidung)
        {
            return CheckmkmoitrungmkcuDAL(nguoidung);
        }
        public void Thaydoimk(NguoiDung nguoidung)
        {
            ThaydoimkDAL(nguoidung);
        }
        public void Thaydoimkkodk(NguoiDung nguoidung)
        {
            ThaydoimkkodkDAL(nguoidung);

        }
        public void InsertND(NguoiDung nguoidung)
        {
            InsertNDDAL(nguoidung);
        }
        public void UpdateND(NguoiDung nguoidung)
        {
            UpdateNDDAL(nguoidung);
        }
        public void DeleteND(NguoiDung nguoidung)
        {
            deleteNDDAL(nguoidung);
        }
        public string maxID(NguoiDung nguoidung)
        {
            return maxIDDAL(nguoidung);
        }
        public bool ChecktontaiTaiKhoan(NguoiDung nguoidung)
        {
            return ChecktontaiTaiKhoanDAL(nguoidung);
        }
        public bool ChecktontaiEmail(NguoiDung nguoidung)
        {
            return ChecktontaiEmailDAL(nguoidung);
        }



    }
}
