using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HocVienDAL:Database
    {
        public void InsertHV(HocVien hocvien)
        {
            InsertHVDAL(hocvien);
        }
        public void UpdateHV(HocVien hocvien)
        {
            UpdateHVDAL(hocvien);
        }
        public void DeleteHV(HocVien hocvien)
        {
            deleteHVDAL(hocvien);
        }
        public string maxIDHV(HocVien hocvien)
        {
            return maxIDHVDAL(hocvien);
        }
    }
}
