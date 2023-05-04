using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChungNhanDAL:Database
    {
        public void InsertCN(ChungNhan chungnhan)
        {
            InsertCNDAL(chungnhan);
        }
        public void UpdateCN(ChungNhan chungnhan)
        {
            UpdateCNDAL(chungnhan);
        }
        public void DeleteCN(ChungNhan chungnhan)
        {
            deleteCNDAL(chungnhan);
        }
        public string maxIDCN(ChungNhan chungnhan)
        {
            return maxIDCNDAL(chungnhan);
        }
    }
}
