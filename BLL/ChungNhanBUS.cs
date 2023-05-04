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
    public class ChungNhanBUS
    {
        ChungNhanDAL nd = new ChungNhanDAL();
        public void InsertCN(ChungNhan chungnhan)
        {
            nd.InsertCN(chungnhan);
        }
        public void UpdateCN(ChungNhan chungnhan)
        {
            nd.UpdateCN(chungnhan);
        }
        public void DeleteCN(ChungNhan chungnhan)
        {
            nd.DeleteCN(chungnhan);
        }
        public string maxIDCN(ChungNhan chungnhan)
        {
            return nd.maxIDCN(chungnhan);
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
