using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ThietKePhanMem.DataAcess;

namespace ThietKePhanMem.Business
{
    class thongke_lichthi
    {
        Data a = new Data();
        public DataTable hienthi(DateTime x2, DateTime x3)
        {
            string sql = "SELECT lop as N'Lớp',monhoc as N'Môn học', ngaythi as N'Ngày thi',canbocoithi1 as N'Cán bộ coi thi ' , hinhthucthi as N'Hình thức thi',phongthi as N'Phòng thi'   FROM DBO.THONGKELICHTHI() WHERE ngaythi >= '" + x2.ToString("yyyy-MM-dd") + "' and ngaythi <= '" + x3.ToString("yyyy-MM-dd") + "'";
            return a.GET(sql);
        }
        public DataTable hienthichitietlop(string x1, DateTime x2, DateTime x3)
        {
            string sql = "SELECT monhoc as N'Môn học', ngaythi as N'Ngày thi',canbocoithi1 as N'Cán bộ coi thi 1' , hinhthucthi as N'Hình thức thi',phongthi as N'Phòng thi'   FROM DBO.THONGKELICHTHI() WHERE lop = '" + x1 + "' and ngaythi >= '" + x2.ToString("yyyy-MM-dd") + "' and ngaythi <= '" + x3.ToString("yyyy-MM-dd") + "'  ";
            return a.GET(sql);
        }
        public DataTable hienthichitietmonhoc(string x1, DateTime x2, DateTime x3)
        {
            string sql = "SELECT lop as N'Lớp', ngaythi as N'Ngày thi',canbocoithi1 as N'Cán bộ coi thi 1' , hinhthucthi as N'Hình thức thi',phongthi as N'Phòng thi'   FROM DBO.THONGKELICHTHI() WHERE monhoc = '" + x1 + "' and ngaythi >= '" + x2.ToString("yyyy-MM-dd") + "' and ngaythi <= '" + x3.ToString("yyyy-MM-dd") + "'  ";
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
