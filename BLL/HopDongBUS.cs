using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HopDongBUS
    {
        HopDongDAL nd = new HopDongDAL();
        public void InsertHD(HopDong hopdong)
        {
            nd.InsertHD(hopdong);
        }
        public void UpdateHD(HopDong hopdong)
        {
            nd.UpdateHD(hopdong);
        }
        public void DeleteHD(HopDong hopdong)
        {
            nd.DeleteHD(hopdong);
        }
        public string maxIDHD(HopDong hopdong)
        {
            return nd.maxIDHD(hopdong);
        }
        Database dgv = new Database();

        public DataTable DatagvFind(string sql)
        {
            return dgv.DatagvFind(sql);
        }
        public DataTable LoadComboBox(string sql)
        {
            return dgv.LoadComboBox(sql);
        }
    }
}
