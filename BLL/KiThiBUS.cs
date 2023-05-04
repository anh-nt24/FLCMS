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
    public class KiThiBUS
    {
        KiThiDAL nd = new KiThiDAL();
        public void InsertKT(KiThi kithi)
        {
            nd.InsertKT(kithi);
        }
        public void UpdateKT(KiThi kithi)
        {
            nd.UpdateKT(kithi);
        }
        public void DeleteKT(KiThi kithi)
        {
            nd.DeleteKT(kithi);
        }
        public string maxIDKT(KiThi kithi)
        {
            return nd.maxIDKT(kithi);
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
