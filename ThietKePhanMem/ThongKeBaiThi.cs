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
    public partial class ThongKeBaiThi : Form
    {
        public ThongKeBaiThi()
        {
            InitializeComponent();
        }
        thongke_baithi a = new thongke_baithi();
        private void ThongKeBaiThi_Load(object sender, EventArgs e)
        {
            comboBox1lop.DataSource = a.hienthilop();
            comboBox2monhoc.DataSource = a.hienthimonhoc();
            comboBox2monhoc.DisplayMember = "tenMH";
            comboBox1lop.DisplayMember = "tenlop";
        }

        private void btt_thongke_Click(object sender, EventArgs e)
        {
            if (radioButtonlop.Checked)
            {
                DateTime dt1 = Convert.ToDateTime(dateTimePicker1.Value.ToString());
                DateTime dt2 = Convert.ToDateTime(dateTimePicker2.Value.ToString());

                dataGridView1.DataSource = a.hienthichitietlop(comboBox1lop.Text);
            }
            if (radioButtonmonhoc.Checked)
            {
                DateTime dt1 = Convert.ToDateTime(dateTimePicker1.Value.ToString());
                DateTime dt2 = Convert.ToDateTime(dateTimePicker2.Value.ToString());
                dataGridView1.DataSource = a.hienthichitietmonhoc(comboBox2monhoc.Text);
            }
            else
            {
                MessageBox.Show("ban can chon ");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DateTime dt1 = Convert.ToDateTime(dateTimePicker1.Value.ToString());
            DateTime dt2 = Convert.ToDateTime(dateTimePicker2.Value.ToString());
            dataGridView1.DataSource = a.hienthi();
        }

        private void btt_xembaocao_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=NGUYEN_VAN_HANH\SQLEXPRESS;Initial Catalog=thivachamthi;Integrated Security=True");
            con.Open();
            DateTime dt1 = Convert.ToDateTime(dateTimePicker1.Value.ToString());
            DateTime dt2 = Convert.ToDateTime(dateTimePicker2.Value.ToString());
            SqlCommand cmd = new SqlCommand("Select * from dbo.THONGKEBAITHI() ", con);
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
