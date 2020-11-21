namespace GUI
{
    partial class formSoTietKiem
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
            this.dtgSoTK = new System.Windows.Forms.DataGridView();
            this.cbLoaiSo = new System.Windows.Forms.ComboBox();
            this.dtpNgayMoSo = new System.Windows.Forms.DateTimePicker();
            this.tbTienGui = new System.Windows.Forms.TextBox();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.tbCMND = new System.Windows.Forms.TextBox();
            this.tbTenKH = new System.Windows.Forms.TextBox();
            this.tbMaTK = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.btConfirm = new System.Windows.Forms.Button();
            this.btDeleteTxt = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btRut = new System.Windows.Forms.Button();
            this.btGui = new System.Windows.Forms.Button();
            this.btThayDoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSoTK)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources._20190710225615_f9b7_wm;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(686, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dtgSoTK
            // 
            this.dtgSoTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSoTK.Location = new System.Drawing.Point(12, 418);
            this.dtgSoTK.Name = "dtgSoTK";
            this.dtgSoTK.RowTemplate.Height = 24;
            this.dtgSoTK.Size = new System.Drawing.Size(661, 223);
            this.dtgSoTK.TabIndex = 38;
            this.dtgSoTK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSoTK_CellContentClick);
            // 
            // cbLoaiSo
            // 
            this.cbLoaiSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiSo.FormattingEnabled = true;
            this.cbLoaiSo.Location = new System.Drawing.Point(444, 373);
            this.cbLoaiSo.Name = "cbLoaiSo";
            this.cbLoaiSo.Size = new System.Drawing.Size(167, 28);
            this.cbLoaiSo.TabIndex = 37;
            this.cbLoaiSo.SelectedIndexChanged += new System.EventHandler(this.cbLoaiSo_SelectedIndexChanged);
            // 
            // dtpNgayMoSo
            // 
            this.dtpNgayMoSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayMoSo.Location = new System.Drawing.Point(155, 337);
            this.dtpNgayMoSo.Name = "dtpNgayMoSo";
            this.dtpNgayMoSo.Size = new System.Drawing.Size(283, 26);
            this.dtpNgayMoSo.TabIndex = 36;
            this.dtpNgayMoSo.ValueChanged += new System.EventHandler(this.dtpNgayMoSo_ValueChanged);
            // 
            // tbTienGui
            // 
            this.tbTienGui.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTienGui.Location = new System.Drawing.Point(156, 375);
            this.tbTienGui.Name = "tbTienGui";
            this.tbTienGui.Size = new System.Drawing.Size(147, 26);
            this.tbTienGui.TabIndex = 35;
            this.tbTienGui.TextChanged += new System.EventHandler(this.tbTienGui_TextChanged);
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiaChi.Location = new System.Drawing.Point(156, 300);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(248, 26);
            this.tbDiaChi.TabIndex = 34;
            this.tbDiaChi.TextChanged += new System.EventHandler(this.tbDiaChi_TextChanged);
            // 
            // tbCMND
            // 
            this.tbCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCMND.Location = new System.Drawing.Point(156, 258);
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.Size = new System.Drawing.Size(248, 26);
            this.tbCMND.TabIndex = 33;
            this.tbCMND.TextChanged += new System.EventHandler(this.tbCMND_TextChanged);
            // 
            // tbTenKH
            // 
            this.tbTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenKH.Location = new System.Drawing.Point(156, 217);
            this.tbTenKH.Name = "tbTenKH";
            this.tbTenKH.Size = new System.Drawing.Size(248, 26);
            this.tbTenKH.TabIndex = 32;
            this.tbTenKH.TextChanged += new System.EventHandler(this.tbTenKH_TextChanged);
            // 
            // tbMaTK
            // 
            this.tbMaTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaTK.Location = new System.Drawing.Point(156, 175);
            this.tbMaTK.Name = "tbMaTK";
            this.tbMaTK.Size = new System.Drawing.Size(248, 26);
            this.tbMaTK.TabIndex = 31;
            this.tbMaTK.TextChanged += new System.EventHandler(this.tbMaTK_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(319, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 22);
            this.label8.TabIndex = 30;
            this.label8.Text = "Loại tiết kiệm:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 22);
            this.label7.TabIndex = 29;
            this.label7.Text = "Ngày mở sổ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 22);
            this.label6.TabIndex = 28;
            this.label6.Text = "CMND:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 22);
            this.label5.TabIndex = 27;
            this.label5.Text = "Số tiền gửi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tên khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "QUẢN LÝ SỔ TIẾT KIỆM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã tài khoản:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btThayDoi);
            this.groupBox1.Controls.Add(this.btXoa);
            this.groupBox1.Controls.Add(this.btConfirm);
            this.groupBox1.Controls.Add(this.btDeleteTxt);
            this.groupBox1.Controls.Add(this.btThem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(458, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 192);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng:";
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(6, 79);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(98, 48);
            this.btXoa.TabIndex = 4;
            this.btXoa.Text = "Xóa sổ";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.button1_Click);
            // 
            // btConfirm
            // 
            this.btConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirm.Location = new System.Drawing.Point(110, 102);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(99, 48);
            this.btConfirm.TabIndex = 3;
            this.btConfirm.Text = "Xác nhận";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // btDeleteTxt
            // 
            this.btDeleteTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteTxt.Location = new System.Drawing.Point(109, 48);
            this.btDeleteTxt.Name = "btDeleteTxt";
            this.btDeleteTxt.Size = new System.Drawing.Size(98, 48);
            this.btDeleteTxt.TabIndex = 2;
            this.btDeleteTxt.Text = "Làm mới";
            this.btDeleteTxt.UseVisualStyleBackColor = true;
            this.btDeleteTxt.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(6, 25);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(98, 48);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "Mở sổ";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThemSo_Click);
            // 
            // btRut
            // 
            this.btRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRut.Location = new System.Drawing.Point(352, 662);
            this.btRut.Name = "btRut";
            this.btRut.Size = new System.Drawing.Size(143, 39);
            this.btRut.TabIndex = 40;
            this.btRut.Text = "Rút tiền ";
            this.btRut.UseVisualStyleBackColor = true;
            this.btRut.Click += new System.EventHandler(this.btRut_Click);
            // 
            // btGui
            // 
            this.btGui.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGui.Location = new System.Drawing.Point(155, 662);
            this.btGui.Name = "btGui";
            this.btGui.Size = new System.Drawing.Size(154, 39);
            this.btGui.TabIndex = 39;
            this.btGui.Text = "Gửi tiền";
            this.btGui.UseVisualStyleBackColor = true;
            this.btGui.Click += new System.EventHandler(this.btGui_Click);
            // 
            // btThayDoi
            // 
            this.btThayDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThayDoi.Location = new System.Drawing.Point(6, 133);
            this.btThayDoi.Name = "btThayDoi";
            this.btThayDoi.Size = new System.Drawing.Size(98, 48);
            this.btThayDoi.TabIndex = 5;
            this.btThayDoi.Text = "Thay đổi";
            this.btThayDoi.UseVisualStyleBackColor = true;
            this.btThayDoi.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // formSoTietKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 725);
            this.Controls.Add(this.btRut);
            this.Controls.Add(this.btGui);
            this.Controls.Add(this.dtgSoTK);
            this.Controls.Add(this.cbLoaiSo);
            this.Controls.Add(this.dtpNgayMoSo);
            this.Controls.Add(this.tbTienGui);
            this.Controls.Add(this.tbDiaChi);
            this.Controls.Add(this.tbCMND);
            this.Controls.Add(this.tbTenKH);
            this.Controls.Add(this.tbMaTK);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formSoTietKiem";
            this.Text = "Quản lý sổ tiết kiệm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSoTK)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtgSoTK;
        private System.Windows.Forms.ComboBox cbLoaiSo;
        private System.Windows.Forms.DateTimePicker dtpNgayMoSo;
        private System.Windows.Forms.TextBox tbTienGui;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.TextBox tbCMND;
        private System.Windows.Forms.TextBox tbTenKH;
        private System.Windows.Forms.TextBox tbMaTK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btDeleteTxt;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btRut;
        private System.Windows.Forms.Button btGui;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThayDoi;
    }
}