using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KiThiDAL:Database
    {
        public void InsertKT(KiThi kithi)
        {
            InsertKTDAL(kithi);
        }
        public void UpdateKT(KiThi kithi)
        {
            UpdateKTDAL(kithi);
        }
        public void DeleteKT(KiThi kithi)
        {
            deleteKTDAL(kithi);
        }
        public string maxIDKT(KiThi kithi)
        {
            return maxIDKTDAL(kithi);
        }
    }
}
