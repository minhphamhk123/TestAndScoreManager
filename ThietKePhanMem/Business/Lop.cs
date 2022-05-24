using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ThietKePhanMem.DataAcess;

namespace ThietKePhanMem.Business
{
    class Lop
    {
        Data da = new Data();
        public DataTable hienthi()
        {
            string sql = "select * from LOP ";
            return da.GET(sql);
        }
        public DataTable timkiem(string dk)
        {
            string sql = "select * from LOP where malop like '%"+dk+ "%'";
            return da.GET(sql);
        }

        public void them(string malop, string tenlop, string siso)
        {
            string sql = "insert into LOP values(N'" + malop + "','" + tenlop + "',N'" + siso + "') ";
            da.AC(sql);
        }
        public void sua(string malop, string tenlop, string siso)
        {
            string sql = "update LOP set tenlop='" + tenlop + "',siso=N'" + siso + "' where malop='" + malop + "'";
            da.AC(sql);
        }
        public void xoa(string malop)
        {
            string sql = "delete from LOP where malop='" + malop + "'";
            da.AC(sql);
        }
    }
}
