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
    public class LopHocBUS
    {
        LopHocDAL nd = new LopHocDAL();
        public void InsertLH(LopHoc lophoc)
        {
            nd.InsertLH(lophoc);
        }
        public void UpdateLH(LopHoc lophoc)
        {
            nd.UpdateLH(lophoc);
        }
        public void DeleteLH(LopHoc lophoc)
        {
            nd.DeleteLH(lophoc);
        }
        public string maxIDLH(LopHoc lophoc)
        {
            return nd.maxIDLH(lophoc);
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
