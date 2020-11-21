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
    public partial class formBaoCao : Form
    {
        public formBaoCao()
        {
            InitializeComponent();
        }

        private void cbLoaiSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //combobox chọn loại sổ tiết kiệm
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            //button để hiện thông tin về tháng cần tra cứu
        }

        private void tbThang_TextChanged(object sender, EventArgs e)
        {
            //textbox nhập tháng cần tra
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            //quay lại formDoanhSo
        }

        private void dtgDoanhThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //hiện thông tin về tháng cần tra theo bảng doanh số tháng
        }
    }
}
