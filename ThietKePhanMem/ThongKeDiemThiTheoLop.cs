using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using ThietKePhanMem.Business;
using System.Data.SqlClient;
using DevExpress.XtraReports.UI;

namespace ThietKePhanMem
{
    public partial class ThongKeDiemThiTheoLop : Form
    {
        public ThongKeDiemThiTheoLop()
        {
            InitializeComponent();
        }
        thongke_diemthilop a = new thongke_diemthilop();
        private void ThongKeDiemThiTheoLop_Load(object sender, EventArgs e)
        {
            comboBox1lop.DataSource = a.hienthilop();
            comboBox2monhoc.DataSource = a.hienthimonhoc();
            comboBox2monhoc.DisplayMember = "tenMH";
            comboBox1lop.DisplayMember = "tenlop";
        }

        private void btt_thongke_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = a.hienthi(comboBox1lop.Text,comboBox2monhoc.Text);

        }

        private void btt_xembaocao_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=NGUYEN_VAN_HANH\SQLEXPRESS;Initial Catalog=thivachamthi;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from dbo.THONGKEDIEMTHITHEOLOP('"+comboBox1lop.Text+"','"+comboBox2monhoc.Text+"'", con);
            SqlDataAdapter c = new SqlDataAdapter(cmd);
            DataTable bang = new DataTable();
            c.Fill(bang);
            con.Close();
            XtraReport1_thongkelichthi x = new XtraReport1_thongkelichthi();
            x.DataSource = bang;
            x.ShowPreviewDialog();
        }

    }
}
