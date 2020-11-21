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
    public partial class formDoanhSo : Form
    {
        public formDoanhSo()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //Ngày hiện tại cần coi
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            //Cập nhật lại doanh số ở text box tổng thu/tổng chi
        }

        private void cbLoaiSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Combobox cho loại số tiết kiệm
        }

        private void tbTongThu_TextChanged(object sender, EventArgs e)
        {
            //Text box để hiện tổng tiền thu
        }

        private void tbTongChi_TextChanged(object sender, EventArgs e)
        {
            //Text box để hiện tổng tiền chi
        }

        private void btQLSTK_Click(object sender, EventArgs e)
        {
            //button mở form Sổ tiết kiệm
        }

        private void btBaoCaoThang_Click(object sender, EventArgs e)
        {
            //button mở form báo cáo tháng
        }
    }
}
