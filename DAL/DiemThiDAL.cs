using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DiemThiDAL:Database
    {
        public void InsertDT(DiemThi diemthi)
        {
            InsertDTDAL(diemthi);
        }
        public void UpdateDT(DiemThi diemthi)
        {
            UpdateDTDAL(diemthi);
        }
        public void DeleteDT(DiemThi diemthi)
        {
            deleteDTDAL(diemthi);
        }
    }
}
