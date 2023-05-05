using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HopDongDAL:Database
    {
        public void InsertHD(HopDong hopdong)
        {
            InsertHDDAL(hopdong);
        }
        public void UpdateHD(HopDong hopdong)
        {
            UpdateHDDAL(hopdong);
        }
        public void DeleteHD(HopDong hopdong)
        {
            deleteHDDAL(hopdong);
        }
        public string maxIDHD(HopDong hopdong)
        {
            return maxIDHDDAL(hopdong);
        }
    }
}
