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
    public class HocVienBUS
    {
        HocVienDAL nd = new HocVienDAL();
        public void InsertHV(HocVien hocvien)
        {
            nd.InsertHV(hocvien);
        }
        public void UpdateHV(HocVien hocvien)
        {
            nd.UpdateHV(hocvien);
        }
        public void DeleteHV(HocVien hocvien)
        {
            nd.DeleteHV(hocvien);
        }
        public string maxIDHV(HocVien hocvien)
        {
            return nd.maxIDHV(hocvien);
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
