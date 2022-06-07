using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ThietKePhanMem.DataAcess;

namespace ThietKePhanMem.Business
{
    class CanBoCoiThi
    {
        Data da = new Data();
        public DataTable hienthi()
        {
            string sql = "select * from CANBOCOITHI ";
            return da.GET(sql);
        }
        public DataTable timkiem(string dk)
        {
            string sql = "select * from CANBOCOITHI where maCB like '%" + dk + "%'";
            return da.GET(sql);
        }

        public void them(string maCB, string tenCB, string donvi,string chucvu)
        {
            string sql = "insert into CANBOCOITHI values(N'" + maCB + "',N'" + tenCB + "',N'" + donvi + "',N'" + chucvu + "') ";
            da.AC(sql);
        }
        public void sua(string maCB, string tenCB, string donvi, string chucvu)
        {
            string sql = "update CANBOCOITHI set tenCB='" + tenCB + "',donvi=N'" + donvi + "',chucvu=N'" + chucvu + "' where maCB='" + maCB + "'";
            da.AC(sql);
        }
        public void xoa(string maCB)
        {
            string sql = "delete from CANBOCOITHI where maCB='" + maCB + "'";
            da.AC(sql);
        }
    }
}
