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
    public class GiaoVienBUS
    {
        GiaoVienDAL nd = new GiaoVienDAL();
        public void InsertGV(GiaoVien giaovien)
        {
            nd.InsertGV(giaovien);
        }
        public void UpdateGV(GiaoVien giaovien)
        {
            nd.UpdateGV(giaovien);
        }
        public void DeleteGV(GiaoVien giaovien)
        {
            nd.DeleteGV(giaovien);
        }
        public string maxIDGV(GiaoVien giaovien)
        {
            return nd.maxIDGV(giaovien);
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
