namespace GUI
{
    partial class GuiTien
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
            this.txtMaSoGui = new System.Windows.Forms.TextBox();
            this.txtKhachHangGui = new System.Windows.Forms.TextBox();
            this.dtPNgayGui = new System.Windows.Forms.DateTimePicker();
            this.txtSoTienGui = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro Med", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiếu Gửi Tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Sổ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khách Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Gửi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số Tiền Gửi";
            // 
            // txtMaSoGui
            // 
            this.txtMaSoGui.Location = new System.Drawing.Point(85, 74);
            this.txtMaSoGui.Name = "txtMaSoGui";
            this.txtMaSoGui.Size = new System.Drawing.Size(100, 20);
            this.txtMaSoGui.TabIndex = 5;
            // 
            // txtKhachHangGui
            // 
            this.txtKhachHangGui.Location = new System.Drawing.Point(85, 114);
            this.txtKhachHangGui.Name = "txtKhachHangGui";
            this.txtKhachHangGui.Size = new System.Drawing.Size(100, 20);
            this.txtKhachHangGui.TabIndex = 6;
            // 
            // dtPNgayGui
            // 
            this.dtPNgayGui.Location = new System.Drawing.Point(85, 147);
            this.dtPNgayGui.Name = "dtPNgayGui";
            this.dtPNgayGui.Size = new System.Drawing.Size(200, 20);
            this.dtPNgayGui.TabIndex = 7;
            // 
            // txtSoTienGui
            // 
            this.txtSoTienGui.Location = new System.Drawing.Point(85, 182);
            this.txtSoTienGui.Name = "txtSoTienGui";
            this.txtSoTienGui.Size = new System.Drawing.Size(100, 20);
            this.txtSoTienGui.TabIndex = 8;
            // 
            // GuiTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 247);
            this.Controls.Add(this.txtSoTienGui);
            this.Controls.Add(this.dtPNgayGui);
            this.Controls.Add(this.txtKhachHangGui);
            this.Controls.Add(this.txtMaSoGui);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GuiTien";
            this.Text = "GuiTien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaSoGui;
        private System.Windows.Forms.TextBox txtKhachHangGui;
        private System.Windows.Forms.DateTimePicker dtPNgayGui;
        private System.Windows.Forms.TextBox txtSoTienGui;
    }
}