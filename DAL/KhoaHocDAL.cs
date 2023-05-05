using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhoaHocDAL:Database
    {
        public void InsertKH(KhoaHoc khoahoc)
        {
            InsertKHDAL(khoahoc);
        }
        public void UpdateKH(KhoaHoc khoahoc)
        {
            UpdateKHDAL(khoahoc);
        }
        public void DeleteKH(KhoaHoc khoahoc)
        {
            deleteKHDAL(khoahoc);
        }
        public string maxIDKH(KhoaHoc khoahoc)
        {
            return maxIDKHDAL(khoahoc);
        }
    }
}
