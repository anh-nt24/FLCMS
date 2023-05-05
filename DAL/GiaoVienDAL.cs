using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GiaoVienDAL:Database
    {
        public void InsertGV(GiaoVien giaovien)
        {
            InsertGVDAL(giaovien);
        }
        public void UpdateGV(GiaoVien giaovien)
        {
            UpdateGVDAL(giaovien);
        }
        public void DeleteGV(GiaoVien giaovien)
        {
            deleteGVDAL(giaovien);
        }
        public string maxIDGV(GiaoVien giaovien)
        {
            return maxIDGVDAL(giaovien);
        }
    }
}
