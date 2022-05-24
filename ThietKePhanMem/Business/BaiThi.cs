using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ThietKePhanMem.DataAcess;

namespace ThietKePhanMem.Business
{
    class BaiThi
    {
        Data da = new Data();
        public DataTable hienthi()
        {
            string sql = "select * from BAITHI ";
            return da.GET(sql);
        }
        public DataTable timkiem(string dk)
        {
            string sql = "select * from BAITHI where sbd like '%" + dk + "%' or maMH like '%" + dk + "%'";
            return da.GET(sql);
        }
    }
}
