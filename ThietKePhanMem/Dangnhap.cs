using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ThietKePhanMem.Business;
using System.Data.SqlClient;

namespace ThietKePhanMem
{
    public partial class Dangnhap : DevExpress.XtraEditors.XtraForm
    {
        TaiKhoan tk = new TaiKhoan();
        public static int loaitk;
        public static string matk;
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (txt_tk.Text == "" || txt_mk.Text == "")
            {
                MessageBox.Show("Thông tin chưa đầy đủ!\n Vui long nhập lại thông tin!");
            }
            else
            {
                if (tk.timkiem(txt_tk.Text, txt_mk.Text) == 1 )
                {
                    MessageBox.Show("Chào Mừng  " + txt_tk.Text + " Đã Đến Với\nPhần Mềm Quản Lý Thi Và Chấm Thi                                            Trường T36");
                    Form_Main f = new Form_Main();
                    f.Show();
                    Hide();
                    Dispose();
                }

                else if (tk.timkiem(txt_tk.Text, txt_mk.Text) == 2)
                {
                    MessageBox.Show("Chào Mừng == " + txt_tk.Text + "==Đã Đến Với Phần Mềm Quản Lý Thi Và Chấm Thi                                            Trường T36");
                    Form_Main f = new Form_Main();
                    f.Show();
                    Hide();
                    Dispose();
                }

                else
                {
                    if (MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!\nVui lòng nhập lại thông tin?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        txt_tk.Focus();
                    else
                    {
                        this.Close();
                    }
                }
            }
        }
        private void b2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi hệ thống không ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question )==DialogResult.Yes)
            {               
                GioiThieu f = new GioiThieu();
                f.Show();
                Close();
             //   Application.Exit();
            }
        }
        private void ck1_CheckedChanged(object sender, EventArgs e)
        {
            if (ck1.Checked == true)
                txt_mk.PasswordChar = (Char)0;
            else
                txt_mk.PasswordChar = '*';
        }
    }
}
