﻿using System;
using System.Collections.Generic;
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

    }
}