namespace ThietKePhanMem
{
    partial class ThongKeCanBo
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.comboBox2monhoc = new System.Windows.Forms.ComboBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btt_xembaocao = new DevExpress.XtraEditors.SimpleButton();
            this.btt_thongke = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.comboBox2monhoc);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.btt_xembaocao);
            this.groupControl1.Controls.Add(this.btt_thongke);
            this.groupControl1.Location = new System.Drawing.Point(0, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(765, 153);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "TÙY CHỌN THỐNG KÊ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "CHỌN ĐƠN VỊ";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(505, 97);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(86, 23);
            this.simpleButton2.TabIndex = 11;
            this.simpleButton2.Text = "QUAY LẠI";
            // 
            // comboBox2monhoc
            // 
            this.comboBox2monhoc.FormattingEnabled = true;
            this.comboBox2monhoc.Location = new System.Drawing.Point(28, 46);
            this.comboBox2monhoc.Name = "comboBox2monhoc";
            this.comboBox2monhoc.Size = new System.Drawing.Size(196, 21);
            this.comboBox2monhoc.TabIndex = 10;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(505, 46);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(86, 23);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "THỐNG KÊ TỔNG";
            // 
            // btt_xembaocao
            // 
            this.btt_xembaocao.Location = new System.Drawing.Point(388, 46);
            this.btt_xembaocao.Name = "btt_xembaocao";
            this.btt_xembaocao.Size = new System.Drawing.Size(86, 23);
            this.btt_xembaocao.TabIndex = 6;
            this.btt_xembaocao.Text = "XEM BÁO CÁO";
            // 
            // btt_thongke
            // 
            this.btt_thongke.Location = new System.Drawing.Point(271, 46);
            this.btt_thongke.Name = "btt_thongke";
            this.btt_thongke.Size = new System.Drawing.Size(86, 23);
            this.btt_thongke.TabIndex = 5;
            this.btt_thongke.Text = "THỐNG KÊ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(765, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // ThongKeCanBo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 313);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupControl1);
            this.Name = "ThongKeCanBo";
            this.Text = "THỐNG KÊ CÁN BỘ";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.ComboBox comboBox2monhoc;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btt_xembaocao;
        private DevExpress.XtraEditors.SimpleButton btt_thongke;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}