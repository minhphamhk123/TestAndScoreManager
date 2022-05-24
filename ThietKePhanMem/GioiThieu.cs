using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKePhanMem
{
    public partial class GioiThieu : DevExpress.XtraEditors.XtraForm
    {
        public GioiThieu()
        {
            InitializeComponent();
        }
        string A;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Dangnhap f = new Dangnhap();
            f.Show();
            Hide();
        }

        private void GioiThieu_Load(object sender, EventArgs e)
        {
            A = label2.Text;
            timer2.Start();
            label2.Text = "";
        }
        int x = 50, y = 60, a = 1;
        Random rd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                x += a;
                label1.Location = new Point(x, y);
                if (x > 250)
                {
                    a = -1;
                    label1.ForeColor = Color.FromArgb(rd.Next(0, 200), rd.Next(0, 200), rd.Next(0, 200));
                }
                if (x < 50)
                {
                    a = 1;
                    label1.ForeColor = Color.FromArgb(rd.Next(0, 200), rd.Next(0, 200), rd.Next(0, 200));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            int d = 0, b;
            b = A.Length;
            d++;
            string c = A.Substring(0, 1);
            A = A.Substring(1, A.Length - 1);
            label2.Text = label2.Text + c;
            if (d == b)
            {
                timer2.Stop();
            }
        }
    }
}
