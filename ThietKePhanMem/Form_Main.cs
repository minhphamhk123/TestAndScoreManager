using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThietKePhanMem.Business;
using ThietKePhanMem;

namespace ThietKePhanMem
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        
        TaiKhoan tk = new TaiKhoan();
        HocVien hv = new HocVien();
        Lop lop = new Lop();
        CanBoCoiThi cbct = new CanBoCoiThi();
        GiaoVienChamThi gvct = new GiaoVienChamThi();
        DeThiDapAn dtda = new DeThiDapAn();
        BienBan bb = new BienBan();
        LichThi lt = new LichThi();
        BaiThi bt = new BaiThi();
        Dangnhap dn = new Dangnhap();
        
           
        
        

        private void Form_Main_Load(object sender, EventArgs e)
        {
            
            //{
            //    thongke.PageEnabled = false;
            //    hethong_taikhoan.PageEnabled = false;
            //}

            dg_taikhoan.DataSource = tk.hienthi();
            dg_thisinh.DataSource = hv.hienthi();
            dg_lop.DataSource = lop.hienthi();
            dg_dethi.DataSource = dtda.hienthi();
            dg_coithi.DataSource = cbct.hienthi();
            dg_chamthi.DataSource = gvct.hienthi();
            dg_baithi.DataSource = bt.hienthi();
            dg_lichthi.DataSource = lt.hienthi();
            dg_bienban.DataSource = bb.hienthi();

        }

        private void dg_taikhoan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txt_taikhoan_tendn.Text = dg_taikhoan.Rows[dong].Cells[0].Value.ToString();
            txt_taikhoan_mk.Text = dg_taikhoan.Rows[dong].Cells[1].Value.ToString();
            txt_taikhoan_tennd.Text = dg_taikhoan.Rows[dong].Cells[2].Value.ToString();
            cmb_taikhoan_phanquyen.Text = dg_taikhoan.Rows[dong].Cells[3].Value.ToString();
        }
        private void dg_lop_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txt_lop_malop.Text=dg_lop.Rows[dong].Cells[0].Value.ToString();
            txt_lop_tenlop.Text = dg_lop.Rows[dong].Cells[1].Value.ToString();
            txt_lop_siso.Text = dg_lop.Rows[dong].Cells[2].Value.ToString();
        }
        private void dg_lichthi_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txt_lichthi_macb.Text = dg_lichthi.Rows[dong].Cells[0].Value.ToString();
            txt_lichthi_mamh.Text = dg_lichthi.Rows[dong].Cells[1].Value.ToString();
            txt_lichthi_malop.Text = dg_lichthi.Rows[dong].Cells[2].Value.ToString();
            dtp_lichthi_ngaythi.Text= dg_lichthi.Rows[dong].Cells[3].Value.ToString();
            txt_lichthi_phongthi.Text = dg_lichthi.Rows[dong].Cells[4].Value.ToString();
        }
        private void dg_bienban_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txt_bb_mabb.Text = dg_bienban.Rows[dong].Cells[0].Value.ToString();
            txt_bb_sbd.Text = dg_bienban.Rows[dong].Cells[1].Value.ToString();
            dtp_bb_ngaylap.Text = dg_bienban.Rows[dong].Cells[2].Value.ToString();
        }

        private void dg_baithi_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txt_baithi_sbd.Text = dg_baithi.Rows[dong].Cells[0].Value.ToString();
            txt_baithi_mamon.Text = dg_baithi.Rows[dong].Cells[1].Value.ToString();
            txt_baithi_diem.Text = dg_baithi.Rows[dong].Cells[2].Value.ToString();
        }

        private void dg_thisinh_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txt_thisinh_sbd.Text = dg_thisinh.Rows[dong].Cells[0].Value.ToString();
            txt_thisinh_hoten.Text = dg_thisinh.Rows[dong].Cells[1].Value.ToString();
            dtp_thisinh_ngaysinh.Text = dg_thisinh.Rows[dong].Cells[2].Value.ToString();
            txt_thisinh_malop.Text = dg_thisinh.Rows[dong].Cells[3].Value.ToString();
            
        }

        private void dg_dethi_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txt_dethi_ma.Text = dg_dethi.Rows[dong].Cells[0].Value.ToString();
            txt_dethi_tenmon.Text = dg_dethi.Rows[dong].Cells[1].Value.ToString();
        }

        private void dg_chamthi_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;                
                txt_giaovien_ma.Text = dg_chamthi.Rows[dong].Cells[0].Value.ToString();
                txt_giaovien_ten.Text = dg_chamthi.Rows[dong].Cells[1].Value.ToString();
                txt_giaovien_donvi.Text = dg_chamthi.Rows[dong].Cells[2].Value.ToString();
                txt_giaovien_chucvu.Text = dg_chamthi.Rows[dong].Cells[3].Value.ToString();
                txt_giaovien_mamon.Text = dg_chamthi.Rows[dong].Cells[4].Value.ToString();                    
        }

        private void dg_coithi_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txt_canbo_ma.Text = dg_coithi.Rows[dong].Cells[0].Value.ToString();
            txt_canbo_ten.Text = dg_coithi.Rows[dong].Cells[1].Value.ToString();
            txt_canbo_donvi.Text = dg_coithi.Rows[dong].Cells[2].Value.ToString();
            txt_canbo_chucvu.Text = dg_coithi.Rows[dong].Cells[3].Value.ToString();           
        }
        //--------------------------------------------------------------------------------
        //      -------------------------------------------------------
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThongKeLichThi a = new ThongKeLichThi();
            a.Show();
            Hide();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThongKeBaiThi a = new ThongKeBaiThi();
            a.ShowDialog();
            Hide();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThongKeDiemThiTheoLop a = new ThongKeDiemThiTheoLop();
            a.Show();
            Hide();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThongKeBienBanViPham a = new ThongKeBienBanViPham();
            a.Show();
            Hide();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThongKeCanBo a = new ThongKeCanBo();
            a.Show();
            Hide();
        }
        // 1 ============================thao tac tren bang tai khoan==================================_____________________________________________
        //==========================================================================================
        //==========================================================================================

        private void tk_taikhoan_Click(object sender, EventArgs e)
        {
            if(txt_taikhoan_timkiem.Text=="")
            {
                MessageBox.Show("Ban chua dien thong tin tim kiem");
            }
            else
            {
                DataTable dt = new DataTable();
                dt = tk.hienthi(txt_taikhoan_timkiem.Text);
                dg_taikhoan.DataSource = dt;             
                if (dt.Rows.Count == 0)
                {
                    txt_taikhoan_timkiem.ForeColor = Color.Red;
                    txt_taikhoan_timkiem.Text = "Không tìm thấy dữ liệu";
                    txt_taikhoan_timkiem.ResetText();
                }
                else
                    txt_taikhoan_timkiem.ResetText();
            }
        }
        private void them_taikhoan_Click(object sender, EventArgs e)
        {
            try
            {
                tk.them(txt_taikhoan_tendn.Text, txt_taikhoan_mk.Text, txt_taikhoan_tennd.Text, int.Parse(cmb_taikhoan_phanquyen.Text));
                MessageBox.Show("thanh cong");
                txt_taikhoan_tendn.Text = "";
                txt_taikhoan_mk.Text = "";
                txt_taikhoan_tennd.Text = "";
                Form_Main_Load(sender, e);
                cmb_taikhoan_phanquyen.Text = "";
            }
            catch
            {
                MessageBox.Show("da ton tai tai khoan");
            }           
        }
        private void sua_taikhoan_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn sửa tài khoản không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    tk.sua(txt_taikhoan_tendn.Text, txt_taikhoan_mk.Text, txt_taikhoan_tennd.Text);
                    MessageBox.Show("Sửa tài khoản thành công");
                    Form_Main_Load(sender, e);
                }                   
            }
            catch
            {
                MessageBox.Show("Thông tin không đúng\nSửa tài khoản thành công");
                
                //{
                //    txt_tennd_tk.Focus();
                //}
            }
        }
        private void xoa_taikhoan_Click(object sender, EventArgs e)
        {
            if (txt_taikhoan_tendn.TextLength == 0)
                MessageBox.Show("Bạn cần chọn Tài Khoản để xóa");
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    tk.xoa(txt_taikhoan_tendn.Text);
                    MessageBox.Show("Đã xóa thành công");
                    Form_Main_Load(sender, e);
                }
            }
        }

        private void reset_taikhoan_Click(object sender, EventArgs e)
        {
            Form_Main_Load(sender, e);
            txt_lop_timkiem.Text = "";
            txt_lop_timkiem.Focus();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất khỏi hệ thống không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GioiThieu f = new GioiThieu();
                f.Show();
                Close();
                // Application.Exit();
            }
        }


        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        //2 ============================thao tac tren bang lop==================================_____________________________________________
        //==========================================================================================
        //==========================================================================================      
        private void timkiem_lop_Click(object sender, EventArgs e)
        {
            if (txt_lop_timkiem.Text == "")
            {
                MessageBox.Show("Ban chua dien thong tin tim kiem");
            }
            else
            {
                DataTable dt = new DataTable();
                dt = lop.timkiem(txt_lop_timkiem.Text);
                dg_lop.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    txt_lop_timkiem.ForeColor = Color.Red;
                    txt_lop_timkiem.Text = "Không tìm thấy dữ liệu";
                    txt_lop_timkiem.ResetText();
                }
                else
                    txt_lop_timkiem.ResetText();
            }
            
        }

        private void them_lop_Click(object sender, EventArgs e)
        {
            try
            {
                lop.them(txt_lop_malop.Text, txt_lop_tenlop.Text, txt_lop_siso.Text);
                MessageBox.Show("Thêm lớp mới thành công");
                Form_Main_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Thêm lớp mới thất bại");
            }


            
        }

        private void sua_lop_Click(object sender, EventArgs e)
        {
            try
            {
                lop.sua(txt_lop_malop.Text, txt_lop_tenlop.Text, txt_lop_siso.Text);
                MessageBox.Show("Sửa lớp  thành công");
                Form_Main_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Sửa lớp không thanh công thành công");
            }
        }

        private void xoa_lop_Click(object sender, EventArgs e)
        {
            if (txt_lop_malop.TextLength == 0)
                MessageBox.Show("Bạn cần chọn Tài Khoản để xóa");
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    lop.xoa(txt_lop_malop.Text);
                    MessageBox.Show("Đã xóa thành công");
                    Form_Main_Load(sender, e);
                }
            }
        }

        private void reset_lop_Click(object sender, EventArgs e)
        {
            Form_Main_Load(sender, e);
            txt_lop_timkiem.Text = "";
            txt_lop_timkiem.Focus();
        }

        // 3 ============================thao tac tren bang thisinh==================================_____________________________________________
        //==========================================================================================
        //==========================================================================================    
        

        private void tk_thisinh_Click(object sender, EventArgs e)
        {
            if (txt_thisinh_timkiem.Text == "")
            {
                MessageBox.Show("Ban chua dien thong tin tim kiem");
            }
            else
            {
                DataTable dt = new DataTable();
                dt = hv.timkiem(txt_thisinh_timkiem.Text);
                dg_thisinh.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    txt_thisinh_timkiem.ForeColor = Color.Red;
                    txt_thisinh_timkiem.Text = "Không tìm thấy dữ liệu";
                    txt_thisinh_timkiem.ResetText();
                }
                else
                    txt_thisinh_timkiem.ResetText();
            }
        }
        private void reset_thisinh_Click(object sender, EventArgs e)
        {
            Form_Main_Load(sender, e);
            txt_thisinh_timkiem.Text = "";
            txt_thisinh_timkiem.Focus();
        }

        private void them_thisinh_Click(object sender, EventArgs e)
        {

        }

        private void sua_thisinh_Click(object sender, EventArgs e)
        {

        }

        private void xoa_thisinh_Click(object sender, EventArgs e)
        {

        }

        

       

        
        // 4 ============================thao tac tren bang bien de thi==================================_____________________________________________
        //==========================================================================================
        //==========================================================================================
        private void tk_dethi_Click(object sender, EventArgs e)
        {
            if (txt_dethi_timkiem.Text == "")
            {
                MessageBox.Show("Ban chua dien thong tin tim kiem");
            }
            else
            {
                DataTable dt = new DataTable();
                dt = dtda.timkiem(txt_dethi_timkiem.Text);
                dg_dethi.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    txt_dethi_timkiem.ForeColor = Color.Red;
                    txt_dethi_timkiem.Text = "Không tìm thấy dữ liệu";
                    txt_dethi_timkiem.ResetText();
                }
                else
                    txt_dethi_timkiem.ResetText();
            }
        }

        private void them_dethi_Click(object sender, EventArgs e)
        {

        }

        private void sua_dethi_Click(object sender, EventArgs e)
        {

        }

        private void xoa_dethi_Click(object sender, EventArgs e)
        {

        }

        private void reset_dethi_Click(object sender, EventArgs e)
        {
            Form_Main_Load(sender, e);
            txt_dethi_timkiem.Text = "";
            txt_dethi_timkiem.Focus();
        }
        // 5 ============================thao tac tren bang giao vien cham thi==================================_____________________________________________
        //=======================================================================================
        //========================================================================================== 
        private void tk_giaovien_Click(object sender, EventArgs e)
        {
            if (txt_giaovien_timkiem.Text == "")
            {
                MessageBox.Show("Ban chua dien thong tin tim kiem");
            }
            else
            {
                DataTable dt = new DataTable();
                dt = gvct.timkiem(txt_giaovien_timkiem.Text);
                dg_chamthi.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    txt_giaovien_timkiem.ForeColor = Color.Red;
                    txt_giaovien_timkiem.Text = "Không tìm thấy dữ liệu";
                    txt_giaovien_timkiem.ResetText();
                }
                else
                    txt_giaovien_timkiem.ResetText();
            }
        }

        private void them_giaovien_Click(object sender, EventArgs e)
        {

        }
        private void sua_giaovien_Click(object sender, EventArgs e)
        {

        }
        private void xoa_giaovien_Click(object sender, EventArgs e)
        {

        }

        private void reset_giaovien_Click(object sender, EventArgs e)
        {
            Form_Main_Load(sender, e);
            txt_giaovien_timkiem.Text = "";
            txt_giaovien_timkiem.Focus();
        }
        private void xtp_thongtin_giaovien_Paint(object sender, PaintEventArgs e)
        {

        }
        // 6 ============================thao tac tren bang can bo coi thi==================================_____________________________________________
        //==========================================================================================
        //==========================================================================================
        private void timkiem_canbo_Click(object sender, EventArgs e)
        {
            if (txt_canbo_timkiem.Text == "")
            {
                MessageBox.Show("Ban chua dien thong tin tim kiem");
            }
            else
            {
                DataTable dt = new DataTable();
                dt = cbct.timkiem(txt_canbo_timkiem.Text);
                dg_coithi.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    txt_canbo_timkiem.ForeColor = Color.Red;
                    txt_canbo_timkiem.Text = "Không tìm thấy dữ liệu";
                    txt_canbo_timkiem.ResetText();
                }
                else
                    txt_canbo_timkiem.ResetText();
            }
        }

        private void them_canbo_Click(object sender, EventArgs e)
        {

        }

        private void sua_canbo_Click(object sender, EventArgs e)
        {

        }

        private void xoa_canbo_Click(object sender, EventArgs e)
        {

        }

        private void reset_canbo_Click(object sender, EventArgs e)
        {
            Form_Main_Load(sender, e);
            txt_canbo_timkiem.Text = "";
            txt_canbo_timkiem.Focus();
        }
        // 7 ============================thao tac tren bang bai thi==================================_____________________________________________
        //==========================================================================================
        //==========================================================================================  
        private void tk_baithi_Click(object sender, EventArgs e)
        {
            if (txt_baithi_timkiem.Text == "")
            {
                MessageBox.Show("Ban chua dien thong tin tim kiem");
            }
            else
            {
                DataTable dt = new DataTable();
                dt = bt.timkiem(txt_baithi_timkiem.Text);
                dg_baithi.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    txt_baithi_timkiem.ForeColor = Color.Red;
                    txt_baithi_timkiem.Text = "Không tìm thấy dữ liệu";
                    txt_baithi_timkiem.ResetText();
                }
                else
                    txt_baithi_timkiem.ResetText();
            }
        }

        private void them_baithi_Click(object sender, EventArgs e)
        {

        }

        private void sua_baithi_Click(object sender, EventArgs e)
        {

        }

        private void xoa_baithi_Click(object sender, EventArgs e)
        {

        }

        private void reset_baithi_Click(object sender, EventArgs e)
        {
            Form_Main_Load(sender, e);
            txt_baithi_timkiem.Text = "";
            txt_baithi_timkiem.Focus();
        }


        // 8 ============================thao tac tren bang bien ban thi==================================_____________________________________________
        //==========================================================================================
        //==========================================================================================    
        private void tk_bienban_Click(object sender, EventArgs e)
        {
            if (txt_bb_timkiem.Text == "")
            {
                MessageBox.Show("Ban chua dien thong tin tim kiem");
            }
            else
            {
                DataTable dt = new DataTable();
                dt = bb.timkiem(txt_bb_timkiem.Text);
                dg_bienban.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    txt_bb_timkiem.ForeColor = Color.Red;
                    txt_bb_timkiem.Text = "Không tìm thấy dữ liệu";
                    txt_bb_timkiem.ResetText();
                }
                else
                    txt_bb_timkiem.ResetText();
            }
        }

        private void them_bienban_Click(object sender, EventArgs e)
        {

        }

        private void xoa_bienban_Click(object sender, EventArgs e)
        {

        }

        private void sua_bienban_Click(object sender, EventArgs e)
        {

        }

        private void reset_bienban_Click(object sender, EventArgs e)
        {
            Form_Main_Load(sender, e);
            txt_bb_timkiem.Text = "";
            txt_bb_timkiem.Focus();
        }
        // 9 ============================thao tac tren bang lich thi==================================_____________________________________________
        //==========================================================================================
        //========================================================================================== 
        private void timkiem_lichthi_Click(object sender, EventArgs e)
        {
            if (txt_lichthi_timkiem.Text == "")
            {
                MessageBox.Show("Ban chua dien thong tin tim kiem");
            }
            else
            {
                DataTable dt = new DataTable();
                dt = lt.timkiem(txt_lichthi_timkiem.Text);
                dg_lichthi.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    txt_lichthi_timkiem.ForeColor = Color.Red;
                    txt_lichthi_timkiem.Text = "Không tìm thấy dữ liệu";
                    txt_lichthi_timkiem.ResetText();
                }
                else
                    txt_lichthi_timkiem.ResetText();
            }
        }

        private void them_lichthi_Click(object sender, EventArgs e)
        {

        }

        private void sua_lichthi_Click(object sender, EventArgs e)
        {

        }

        private void xoa_lichthi_Click(object sender, EventArgs e)
        {

        }

        private void reset_lichthi_Click(object sender, EventArgs e)
        {
            Form_Main_Load(sender, e);
            txt_lichthi_timkiem.Text = "";
            txt_lichthi_timkiem.Focus();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
