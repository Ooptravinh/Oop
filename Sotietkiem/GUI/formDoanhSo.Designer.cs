namespace GUI
{
    partial class formDoanhSo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTongChi = new System.Windows.Forms.TextBox();
            this.tbTongThu = new System.Windows.Forms.TextBox();
            this.cbLoaiSo = new System.Windows.Forms.ComboBox();
            this.btUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtbNgay = new System.Windows.Forms.DateTimePicker();
            this.btQLSTK = new System.Windows.Forms.Button();
            this.btBaoCaoThang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources._20190710225615_f9b7_wm;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(686, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTongChi);
            this.groupBox1.Controls.Add(this.tbTongThu);
            this.groupBox1.Controls.Add(this.cbLoaiSo);
            this.groupBox1.Controls.Add(this.btUpdate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtbNgay);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 162);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doanh số trong ngày";
            // 
            // tbTongChi
            // 
            this.tbTongChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTongChi.Location = new System.Drawing.Point(489, 128);
            this.tbTongChi.Name = "tbTongChi";
            this.tbTongChi.Size = new System.Drawing.Size(166, 26);
            this.tbTongChi.TabIndex = 8;
            this.tbTongChi.TextChanged += new System.EventHandler(this.tbTongChi_TextChanged);
            // 
            // tbTongThu
            // 
            this.tbTongThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTongThu.Location = new System.Drawing.Point(147, 128);
            this.tbTongThu.Name = "tbTongThu";
            this.tbTongThu.Size = new System.Drawing.Size(166, 26);
            this.tbTongThu.TabIndex = 7;
            this.tbTongThu.TextChanged += new System.EventHandler(this.tbTongThu_TextChanged);
            // 
            // cbLoaiSo
            // 
            this.cbLoaiSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiSo.FormattingEnabled = true;
            this.cbLoaiSo.Location = new System.Drawing.Point(147, 89);
            this.cbLoaiSo.Name = "cbLoaiSo";
            this.cbLoaiSo.Size = new System.Drawing.Size(166, 28);
            this.cbLoaiSo.TabIndex = 6;
            this.cbLoaiSo.SelectedIndexChanged += new System.EventHandler(this.cbLoaiSo_SelectedIndexChanged);
            // 
            // btUpdate
            // 
            this.btUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.Location = new System.Drawing.Point(452, 40);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(113, 72);
            this.btUpdate.TabIndex = 9;
            this.btUpdate.Text = "Cập nhật";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(368, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tổng chi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng thu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loại sổ tiết kiệm:";
            // 
            // dtbNgay
            // 
            this.dtbNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbNgay.Location = new System.Drawing.Point(7, 44);
            this.dtbNgay.Name = "dtbNgay";
            this.dtbNgay.Size = new System.Drawing.Size(306, 26);
            this.dtbNgay.TabIndex = 1;
            this.dtbNgay.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btQLSTK
            // 
            this.btQLSTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQLSTK.Location = new System.Drawing.Point(61, 320);
            this.btQLSTK.Name = "btQLSTK";
            this.btQLSTK.Size = new System.Drawing.Size(229, 44);
            this.btQLSTK.TabIndex = 14;
            this.btQLSTK.Text = "QL sổ tiết kiệm";
            this.btQLSTK.UseVisualStyleBackColor = true;
            this.btQLSTK.Click += new System.EventHandler(this.btQLSTK_Click);
            // 
            // btBaoCaoThang
            // 
            this.btBaoCaoThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBaoCaoThang.Location = new System.Drawing.Point(296, 320);
            this.btBaoCaoThang.Name = "btBaoCaoThang";
            this.btBaoCaoThang.Size = new System.Drawing.Size(337, 44);
            this.btBaoCaoThang.TabIndex = 15;
            this.btBaoCaoThang.Text = "Báo cáo mở đóng tháng";
            this.btBaoCaoThang.UseVisualStyleBackColor = true;
            this.btBaoCaoThang.Click += new System.EventHandler(this.btBaoCaoThang_Click);
            // 
            // formDoanhSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 387);
            this.Controls.Add(this.btBaoCaoThang);
            this.Controls.Add(this.btQLSTK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formDoanhSo";
            this.Text = "Doanh số trong ngày";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTongChi;
        private System.Windows.Forms.TextBox tbTongThu;
        private System.Windows.Forms.ComboBox cbLoaiSo;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtbNgay;
        private System.Windows.Forms.Button btQLSTK;
        private System.Windows.Forms.Button btBaoCaoThang;
    }
}

