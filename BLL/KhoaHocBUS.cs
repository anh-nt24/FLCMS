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
    public class KhoaHocBUS
    {
        KhoaHocDAL nd = new KhoaHocDAL();
        public void InsertKH(KhoaHoc khoahoc)
        {
            nd.InsertKH(khoahoc);
        }
        public void UpdateKH(KhoaHoc khoahoc)
        {
            nd.UpdateKH(khoahoc);
        }
        public void DeleteKH(KhoaHoc khoahoc)
        {
            nd.DeleteKH(khoahoc);
        }
        public string maxIDKH(KhoaHoc khoahoc)
        {
            return nd.maxIDKH(khoahoc);
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
