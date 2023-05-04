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
    public class DiemThiBUS
    {
        DiemThiDAL nd = new DiemThiDAL();
        public void InsertDT(DiemThi diemthi)
        {
            nd.InsertDT(diemthi);
        }
        public void UpdateDT(DiemThi diemthi)
        {
            nd.UpdateDT(diemthi);
        }
        public void DeleteDT(DiemThi diemthi)
        {
            nd.DeleteDT(diemthi);
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
