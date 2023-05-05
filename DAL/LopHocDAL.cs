using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LopHocDAL:Database
    {
        public void InsertLH(LopHoc lophoc)
        {
            InsertLHDAL(lophoc);
        }
        public void UpdateLH(LopHoc lophoc)
        {
            UpdateLHDAL(lophoc);
        }
        public void DeleteLH(LopHoc lophoc)
        {
            deleteLHDAL(lophoc);
        }
        public string maxIDLH(LopHoc lophoc)
        {
            return maxIDLHDAL(lophoc);
        }
    }
}
