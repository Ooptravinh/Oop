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
    public partial class formSoTietKiem : Form
    {
        public formSoTietKiem()
        {
            InitializeComponent();
        }

        private void btThemSo_Click(object sender, EventArgs e)
        {
            //Thêm sổ tiết kiệm mới
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            //Xóa sổ tiết kiệm mới
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            //Thay đổi thông tin sổ tiết kiệm 
        }

        private void tbMaTK_TextChanged(object sender, EventArgs e)
        {
            //Text box nhập mã tài khoản
        }

        private void tbTenKH_TextChanged(object sender, EventArgs e)
        {
            //Text box nhập tên khách hàng
        }

        private void tbCMND_TextChanged(object sender, EventArgs e)
        {
            //Text box nhập CMND
        }

        private void tbDiaChi_TextChanged(object sender, EventArgs e)
        {
            //Textbox nhập địa chỉ
        }

        private void dtpNgayMoSo_ValueChanged(object sender, EventArgs e)
        {
            //Chọn ngày mở sổ
        }

        private void tbTienGui_TextChanged(object sender, EventArgs e)
        {
            //Textbox nhập số tiền trong sổ tiết kiệm
        }

        private void cbLoaiSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //combobox chọn loại tiết kiệm
        }

        private void dtgSoTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridview để hiện bảng sổ tiết kiệm
        }

        private void btGui_Click(object sender, EventArgs e)
        {
            //button hiện form gửi tiền
        }

        private void btRut_Click(object sender, EventArgs e)
        {
            //button hiện form rút tiền
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            //button quay lại form Doanh Số
        }
    }
}
