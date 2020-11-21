namespace GUI
{
    partial class formBaoCao
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
            this.cbLoaiSo = new System.Windows.Forms.ComboBox();
            this.dtgDoanhThu = new System.Windows.Forms.DataGridView();
            this.tbThang = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btSelect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDoanhThu)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbLoaiSo
            // 
            this.cbLoaiSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiSo.FormattingEnabled = true;
            this.cbLoaiSo.Location = new System.Drawing.Point(199, 190);
            this.cbLoaiSo.Name = "cbLoaiSo";
            this.cbLoaiSo.Size = new System.Drawing.Size(232, 37);
            this.cbLoaiSo.TabIndex = 20;
            this.cbLoaiSo.SelectedIndexChanged += new System.EventHandler(this.cbLoaiSo_SelectedIndexChanged);
            // 
            // dtgDoanhThu
            // 
            this.dtgDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDoanhThu.Location = new System.Drawing.Point(10, 290);
            this.dtgDoanhThu.Name = "dtgDoanhThu";
            this.dtgDoanhThu.RowTemplate.Height = 24;
            this.dtgDoanhThu.Size = new System.Drawing.Size(662, 150);
            this.dtgDoanhThu.TabIndex = 19;
            this.dtgDoanhThu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDoanhThu_CellContentClick);
            // 
            // tbThang
            // 
            this.tbThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbThang.Location = new System.Drawing.Point(199, 237);
            this.tbThang.Name = "tbThang";
            this.tbThang.Size = new System.Drawing.Size(232, 36);
            this.tbThang.TabIndex = 18;
            this.tbThang.TextChanged += new System.EventHandler(this.tbThang_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btThoat);
            this.groupBox1.Controls.Add(this.btSelect);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(448, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 83);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(126, 34);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(92, 31);
            this.btThoat.TabIndex = 1;
            this.btThoat.Text = "Quay lại";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(6, 34);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(97, 31);
            this.btSelect.TabIndex = 0;
            this.btSelect.Text = "Tra cứu";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tháng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Loại tiết kiệm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(419, 39);
            this.label2.TabIndex = 14;
            this.label2.Text = "Báo cáo doanh thu tháng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources._20190710225615_f9b7_wm;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(686, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // formBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.cbLoaiSo);
            this.Controls.Add(this.dtgDoanhThu);
            this.Controls.Add(this.tbThang);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formBaoCao";
            this.Text = "Báo cáo doanh thu tháng";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDoanhThu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbLoaiSo;
        private System.Windows.Forms.DataGridView dtgDoanhThu;
        private System.Windows.Forms.TextBox tbThang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}