using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ThietKePhanMem.DataAcess;

namespace ThietKePhanMem.Business
{
    class BienBan
    {
        Data da = new Data();
        public DataTable hienthi()
        {
            string sql = "select * from  BIENBANTHI";
            return da.GET(sql);
        }
        public DataTable timkiem(string dk)
        {
            string sql = "select * from BIENBANTHI where maBB like '%" + dk + "%'";
            return da.GET(sql);
        }
    }
}
