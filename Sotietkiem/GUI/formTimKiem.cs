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
    public partial class formTimKiem : Form
    {
        public formTimKiem()
        {
            InitializeComponent();
        }

        private void tbMaKH_TextChanged(object sender, EventArgs e)
        {
            //Nhap ma khach hàng
        }

        private void tbTenKH_TextChanged(object sender, EventArgs e)
        {
            //Nhập tên khách hàng
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            //Xác nhận thông tin để tìm
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            //Quay lại from rút tiền/gửi tiền
        }
    }
}
