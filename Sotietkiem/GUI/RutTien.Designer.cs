﻿namespace GUI
{
    partial class RutTien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaSoRut = new System.Windows.Forms.TextBox();
            this.txtKhachHangRut = new System.Windows.Forms.TextBox();
            this.txtSoTienRut = new System.Windows.Forms.TextBox();
            this.dtPNgayRut = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiếu Rút Tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Sổ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khách Hàng";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Rút";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số Tiền Rút";
            // 
            // txtMaSoRut
            // 
            this.txtMaSoRut.Location = new System.Drawing.Point(82, 62);
            this.txtMaSoRut.Name = "txtMaSoRut";
            this.txtMaSoRut.Size = new System.Drawing.Size(100, 20);
            this.txtMaSoRut.TabIndex = 5;
            // 
            // txtKhachHangRut
            // 
            this.txtKhachHangRut.Location = new System.Drawing.Point(82, 105);
            this.txtKhachHangRut.Name = "txtKhachHangRut";
            this.txtKhachHangRut.Size = new System.Drawing.Size(100, 20);
            this.txtKhachHangRut.TabIndex = 6;
            // 
            // txtSoTienRut
            // 
            this.txtSoTienRut.Location = new System.Drawing.Point(82, 195);
            this.txtSoTienRut.Name = "txtSoTienRut";
            this.txtSoTienRut.Size = new System.Drawing.Size(100, 20);
            this.txtSoTienRut.TabIndex = 7;
            // 
            // dtPNgayRut
            // 
            this.dtPNgayRut.Location = new System.Drawing.Point(82, 150);
            this.dtPNgayRut.Name = "dtPNgayRut";
            this.dtPNgayRut.Size = new System.Drawing.Size(200, 20);
            this.dtPNgayRut.TabIndex = 8;
            // 
            // RutTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 319);
            this.Controls.Add(this.dtPNgayRut);
            this.Controls.Add(this.txtSoTienRut);
            this.Controls.Add(this.txtKhachHangRut);
            this.Controls.Add(this.txtMaSoRut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RutTien";
            this.Text = "RutTien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaSoRut;
        private System.Windows.Forms.TextBox txtKhachHangRut;
        private System.Windows.Forms.TextBox txtSoTienRut;
        private System.Windows.Forms.DateTimePicker dtPNgayRut;
    }
}