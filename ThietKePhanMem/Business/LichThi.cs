using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ThietKePhanMem.DataAcess;

namespace ThietKePhanMem.Business
{
    class LichThi
    {
        Data da = new Data();
        public DataTable hienthi()
        {
            string sql = "select * from LICHTHI ";
            return da.GET(sql);
        }
        public DataTable timkiem(string dk)
        {
            string sql = "select * from LICHTHI where maCB like '%" + dk + "%' or maMH like '%" + dk + "%' or malop like '%" + dk + "%'";
            return da.GET(sql);
        }
    }
}
