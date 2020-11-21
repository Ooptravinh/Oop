namespace GUI
{
    partial class GUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThemSo = new System.Windows.Forms.Button();
            this.btnXoaSo = new System.Windows.Forms.Button();
            this.btnSuaSo = new System.Windows.Forms.Button();
            this.btnRutTien = new System.Windows.Forms.Button();
            this.btnGuiTien = new System.Windows.Forms.Button();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSoTienGui = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.cmBLoaiTietKiem = new System.Windows.Forms.ComboBox();
            this.dtPNgayMoSo = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(717, 161);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtPNgayMoSo);
            this.groupBox1.Controls.Add(this.cmBLoaiTietKiem);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.txtSoTienGui);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtKhachHang);
            this.groupBox1.Controls.Add(this.btnSuaSo);
            this.groupBox1.Controls.Add(this.btnXoaSo);
            this.groupBox1.Controls.Add(this.btnThemSo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 358);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Sổ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 57);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sổ Tiết Kiệm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Khách Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Loại Tiết Kiệm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa Chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "CMND";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Số Tiền Gửi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(427, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ngày Mở Sổ";
            // 
            // btnThemSo
            // 
            this.btnThemSo.Location = new System.Drawing.Point(31, 149);
            this.btnThemSo.Name = "btnThemSo";
            this.btnThemSo.Size = new System.Drawing.Size(75, 23);
            this.btnThemSo.TabIndex = 7;
            this.btnThemSo.Text = "Thêm Sổ";
            this.btnThemSo.UseVisualStyleBackColor = true;
            // 
            // btnXoaSo
            // 
            this.btnXoaSo.Location = new System.Drawing.Point(334, 149);
            this.btnXoaSo.Name = "btnXoaSo";
            this.btnXoaSo.Size = new System.Drawing.Size(75, 23);
            this.btnXoaSo.TabIndex = 8;
            this.btnXoaSo.Text = "Xóa Sổ";
            this.btnXoaSo.UseVisualStyleBackColor = true;
            // 
            // btnSuaSo
            // 
            this.btnSuaSo.Location = new System.Drawing.Point(673, 149);
            this.btnSuaSo.Name = "btnSuaSo";
            this.btnSuaSo.Size = new System.Drawing.Size(75, 23);
            this.btnSuaSo.TabIndex = 9;
            this.btnSuaSo.Text = "Sửa Sổ";
            this.btnSuaSo.UseVisualStyleBackColor = true;
            // 
            // btnRutTien
            // 
            this.btnRutTien.Location = new System.Drawing.Point(43, 456);
            this.btnRutTien.Name = "btnRutTien";
            this.btnRutTien.Size = new System.Drawing.Size(75, 25);
            this.btnRutTien.TabIndex = 5;
            this.btnRutTien.Text = "Rút Tiền";
            this.btnRutTien.UseVisualStyleBackColor = true;
            // 
            // btnGuiTien
            // 
            this.btnGuiTien.Location = new System.Drawing.Point(346, 456);
            this.btnGuiTien.Name = "btnGuiTien";
            this.btnGuiTien.Size = new System.Drawing.Size(75, 23);
            this.btnGuiTien.TabIndex = 6;
            this.btnGuiTien.Text = "Gửi Tiền";
            this.btnGuiTien.UseVisualStyleBackColor = true;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(685, 456);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(75, 23);
            this.btnTraCuu.TabIndex = 7;
            this.btnTraCuu.Text = "Tra Cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Location = new System.Drawing.Point(101, 17);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(177, 20);
            this.txtKhachHang.TabIndex = 10;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(101, 57);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(177, 20);
            this.txtDiaChi.TabIndex = 11;
            // 
            // txtSoTienGui
            // 
            this.txtSoTienGui.Location = new System.Drawing.Point(101, 100);
            this.txtSoTienGui.Name = "txtSoTienGui";
            this.txtSoTienGui.Size = new System.Drawing.Size(177, 20);
            this.txtSoTienGui.TabIndex = 12;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(507, 57);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(188, 20);
            this.txtCMND.TabIndex = 14;
            // 
            // cmBLoaiTietKiem
            // 
            this.cmBLoaiTietKiem.FormattingEnabled = true;
            this.cmBLoaiTietKiem.Location = new System.Drawing.Point(507, 17);
            this.cmBLoaiTietKiem.Name = "cmBLoaiTietKiem";
            this.cmBLoaiTietKiem.Size = new System.Drawing.Size(188, 21);
            this.cmBLoaiTietKiem.TabIndex = 16;
            // 
            // dtPNgayMoSo
            // 
            this.dtPNgayMoSo.Location = new System.Drawing.Point(507, 100);
            this.dtPNgayMoSo.Name = "dtPNgayMoSo";
            this.dtPNgayMoSo.Size = new System.Drawing.Size(200, 20);
            this.dtPNgayMoSo.TabIndex = 17;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 493);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.btnGuiTien);
            this.Controls.Add(this.btnRutTien);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "GUI";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtSoTienGui;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.Button btnSuaSo;
        private System.Windows.Forms.Button btnXoaSo;
        private System.Windows.Forms.Button btnThemSo;
        private System.Windows.Forms.Button btnRutTien;
        private System.Windows.Forms.Button btnGuiTien;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.DateTimePicker dtPNgayMoSo;
        private System.Windows.Forms.ComboBox cmBLoaiTietKiem;
    }
}

