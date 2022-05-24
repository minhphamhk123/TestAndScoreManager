using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ThietKePhanMem.DataAcess;

namespace ThietKePhanMem.Business
{
    class thongke_baithi
    {
        Data a = new Data();
        public DataTable hienthi()
        {
            string sql = "SELECT LOP as N'Lớp' MONHOC as N'Môn học', TONGSOBAITHI as N'Tổng số bài thi',SOHOCVIENCHUATHI as N'Số học viên chưa thi ' FROM DBO.THONGKEBAITHI()";
            return a.GET(sql);
        }
        public DataTable hienthichitietlop(string x1)
        {
            string sql = "SELECT MONHOC as N'Môn học', TONGSOBAITHI as N'Tổng số bài thi',SOHOCVIENCHUATHI as N'Số học viên chưa thi '  FROM DBO.THONGKEBAITHI() WHERE LOP = '" + x1 + "' ";
            return a.GET(sql);
        }
        public DataTable hienthichitietmonhoc(string x1)
        {
            string sql = "SELECT LOP as N'Lớp', TONGSOBAITHI as N'Tổng số bài thi',SOHOCVIENCHUATHI as N'Số học viên chưa thi'   FROM DBO.THONGKEBAITHI() WHERE MONHOC = '" + x1 + "' ";
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
