namespace ThietKePhanMem
{
    partial class ThongKeDiemThiTheoLop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btt_quaylai = new DevExpress.XtraEditors.SimpleButton();
            this.comboBox2monhoc = new System.Windows.Forms.ComboBox();
            this.comboBox1lop = new System.Windows.Forms.ComboBox();
            this.btt_xembaocao = new DevExpress.XtraEditors.SimpleButton();
            this.btt_thongke = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 246);
            this.dataGridView1.TabIndex = 4;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.btt_quaylai);
            this.groupControl1.Controls.Add(this.comboBox2monhoc);
            this.groupControl1.Controls.Add(this.comboBox1lop);
            this.groupControl1.Controls.Add(this.btt_xembaocao);
            this.groupControl1.Controls.Add(this.btt_thongke);
            this.groupControl1.Location = new System.Drawing.Point(0, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(760, 153);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "TÙY CHỌN THỐNG KÊ";
            // 
            // btt_quaylai
            // 
            this.btt_quaylai.Location = new System.Drawing.Point(645, 114);
            this.btt_quaylai.Name = "btt_quaylai";
            this.btt_quaylai.Size = new System.Drawing.Size(86, 23);
            this.btt_quaylai.TabIndex = 11;
            this.btt_quaylai.Text = "QUAY LẠI";
            // 
            // comboBox2monhoc
            // 
            this.comboBox2monhoc.FormattingEnabled = true;
            this.comboBox2monhoc.Location = new System.Drawing.Point(204, 68);
            this.comboBox2monhoc.Name = "comboBox2monhoc";
            this.comboBox2monhoc.Size = new System.Drawing.Size(121, 21);
            this.comboBox2monhoc.TabIndex = 10;
            // 
            // comboBox1lop
            // 
            this.comboBox1lop.FormattingEnabled = true;
            this.comboBox1lop.Location = new System.Drawing.Point(5, 68);
            this.comboBox1lop.Name = "comboBox1lop";
            this.comboBox1lop.Size = new System.Drawing.Size(121, 21);
            this.comboBox1lop.TabIndex = 9;
            // 
            // btt_xembaocao
            // 
            this.btt_xembaocao.Location = new System.Drawing.Point(645, 68);
            this.btt_xembaocao.Name = "btt_xembaocao";
            this.btt_xembaocao.Size = new System.Drawing.Size(86, 23);
            this.btt_xembaocao.TabIndex = 6;
            this.btt_xembaocao.Text = "XEM BÁO CÁO";
            this.btt_xembaocao.Click += new System.EventHandler(this.btt_xembaocao_Click);
            // 
            // btt_thongke
            // 
            this.btt_thongke.Location = new System.Drawing.Point(645, 30);
            this.btt_thongke.Name = "btt_thongke";
            this.btt_thongke.Size = new System.Drawing.Size(86, 23);
            this.btt_thongke.TabIndex = 5;
            this.btt_thongke.Text = "THỐNG KÊ";
            this.btt_thongke.Click += new System.EventHandler(this.btt_thongke_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "CHỌN LỚP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "CHỌN MÔN HỌC";
            // 
            // ThongKeDiemThiTheoLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 407);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ThongKeDiemThiTheoLop";
            this.Text = "THỐNG KÊ ĐIỂM THITHEO LỚP";
            this.Load += new System.EventHandler(this.ThongKeDiemThiTheoLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btt_quaylai;
        private System.Windows.Forms.ComboBox comboBox2monhoc;
        private System.Windows.Forms.ComboBox comboBox1lop;
        private DevExpress.XtraEditors.SimpleButton btt_xembaocao;
        private DevExpress.XtraEditors.SimpleButton btt_thongke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}