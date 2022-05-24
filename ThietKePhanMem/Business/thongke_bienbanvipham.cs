using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ThietKePhanMem.DataAcess;

namespace ThietKePhanMem.Business
{
    class thongke_bienbanvipham
    {
        Data a = new Data();
        public DataTable hienthi(DateTime x2, DateTime x3)
        {
            string sql = "SELECT SBD as N'Số báo danh', HOTEN as N'Họ tên', NGAYSINH AS N'Ngày sinh ',LOP as N'Lớp', NGAYLAP AS N'Ngày lập', MONTHI as N'Môn thi'  FROM DBO.THONGKEBIENBANVIPHAM() WHERE NGAYLAP >= '" + x2.ToString("yyyy-MM-dd") + "' and NGAYLAP <= '" + x3.ToString("yyyy-MM-dd") + "'";
            return a.GET(sql);
        }
        public DataTable hienthichitietlop(string x1, DateTime x2, DateTime x3)
        {
            string sql = "SELECT SBD as N'Số báo danh', HOTEN as N'Họ tên', NGAYSINH AS N'Ngày sinh ', NGAYLAP AS N'Ngày lập', MONTHI as N'Môn thi'  FROM DBO.THONGKEBIENBANVIPHAM() WHERE LOP = '"+x1+"' and NGAYLAP >= '" + x2.ToString("yyyy-MM-dd") + "' and NGAYLAP <= '" + x3.ToString("yyyy-MM-dd") + "'";
            return a.GET(sql);
        }
        public DataTable hienthichitietmonhoc(string x1, DateTime x2, DateTime x3)
        {
            string sql = "SELECT SBD as N'Số báo danh', HOTEN as N'Họ tên', NGAYSINH AS N'Ngày sinh ', NGAYLAP AS N'Ngày lập', LOP as N'Lớp'  FROM DBO.THONGKEBIENBANVIPHAM() WHERE MONTHI = '" + x1 + "' and NGAYLAP >= '" + x2.ToString("yyyy-MM-dd") + "' and NGAYLAP <= '" + x3.ToString("yyyy-MM-dd") + "'";
            return a.GET(sql);
        }
        public DataTable hienthilop()
        {
            string sql = "select tenlop from LOP";
            return a.GET(sql);
        }
        public DataTable hienthimonhoc()
        {
            string sql = "select tenMH from MONTHI";
            return a.GET(sql);
        }
    
    }
}
