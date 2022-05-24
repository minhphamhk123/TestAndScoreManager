using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ThietKePhanMem.DataAcess;
using System.Data;
using ThietKePhanMem.DataAcess;

namespace ThietKePhanMem.Business
{
    class TaiKhoan
    {
        Data da = new Data();
        public string matk;
        public int phanquyen;

        public DataTable hienthi()
        {
            string sql = "select * from NGUOIDUNG";
            return da.GET(sql);
        }
        public DataTable hienthi(string tentk)
        {
            string sql = "select * from NGUOIDUNG where tendangnhap='"+tentk+"'";
            return da.GET(sql);
        }
        public int timkiem(string tentk, string mk)
        {
            string sql = "select tendangnhap,loaitaikhoan from NGUOIDUNG where tendangnhap='" + tentk + "' and   matkhau = '" + mk + "'";
            DataTable dt = new DataTable();
            dt = da.GET(sql);
            DataRow[] tkrow;
            tkrow = dt.Select();
            if (tkrow.Length != 0)
            {
                matk = tkrow[0][0].ToString();
                phanquyen = int.Parse(tkrow[0][1].ToString());
                return phanquyen;            
            }
            else
            {
                return 0;
            }
        }
        public void them(string tentk,string mk,string tendung,int loai)
        {
            string sql = "insert into NGUOIDUNG values(N'" + tentk + "','" + mk + "',N'" + tendung + "','" + loai + "') ";
            da.AC(sql);
        }
        public void sua(string tentk, string mk,string tennguoidung)
        {
            string sql = "update NGUOIDUNG set matkhau='" + mk + "',tennguoidung=N'" + tennguoidung + "' where tendangnhap='" + tentk + "'";
            da.AC(sql);
        }
        public void xoa(string tentk)
        {
            string sql = "delete from NGUOIDUNG where tendangnhap='" + tentk + "'";
            da.AC(sql);
        }
    }
}
