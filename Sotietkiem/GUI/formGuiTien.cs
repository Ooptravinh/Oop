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
    public partial class formGuiTien : Form
    {
        public formGuiTien()
        {
            InitializeComponent();
        }

        private void tbMaSo_TextChanged(object sender, EventArgs e)
        {
            //textbox nhập mã số phiếu
        }

        private void tbTenKH_TextChanged(object sender, EventArgs e)
        {
            //text box nhập tên khách hàng
        }

        private void dtpNgayGui_ValueChanged(object sender, EventArgs e)
        {
            //chọn ngày gửi
        }

        private void tbTienGui_TextChanged(object sender, EventArgs e)
        {
            //textbox nhập số tiền gửi thêm vào
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            //button xác nhận việc gửi tiền
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            //button quay lại về form sổ tiết kiệm
        }
    }
}
