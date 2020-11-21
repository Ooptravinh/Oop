using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class formRutTien : Form
    {
        public formRutTien()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbMaRut_TextChanged(object sender, EventArgs e)
        {
            //textbox nhập mã phiếu rút tiền
        }

        private void tbTenKH_TextChanged(object sender, EventArgs e)
        {
            //tetxbox nhập tên khách hàng
        }

        private void dtpNgayRut_ValueChanged(object sender, EventArgs e)
        {
            //Ngày rút
        }

        private void tbTienRut_TextChanged(object sender, EventArgs e)
        {
            //textbox nhập số tiền rút
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            //button xác nhận rút tiền
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            //button quay lại form sổ tiết kiệm
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            //Tìm kiếm thông tin khách hàng
        }
    }
}
