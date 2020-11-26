using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class formSoTietKiem : Form
    {
        private  QuanlySoTietKiemEntities database = new QuanlySoTietKiemEntities();
        public formSoTietKiem()
        {
            InitializeComponent();
        }
        
        private void btThemSo_Click(object sender, EventArgs e)
        {
            tbMaTK.ReadOnly = true;
            tbTenKH.Enabled = true;
            tbDiaChi.Enabled = true;
            tbCMND.Enabled = true;
            tbTienGui.Enabled = true;
            dtpNgayMoSo.Enabled = true;
            cbLoaiSo.Enabled = true;
            tbMaTK.Enabled = true;
            cbLoaiSo.DataSource = database.LOAITIETKIEMs.ToList();
            cbLoaiSo.DisplayMember = "LOAI";
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            tbMaTK.Clear();
            tbTenKH.Clear();
            tbDiaChi.Clear();
            tbCMND.Clear();
            tbTienGui.Clear();
            dtpNgayMoSo.Value = DateTime.Now;
            cbLoaiSo.DataSource = database.LOAITIETKIEMs.ToList();
            cbLoaiSo.DisplayMember = "LOAI";
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
            formGuiTien frm2 = new formGuiTien();
            frm2.TopLevel = false;
            panelGuiTien.Controls.Add(frm2);
            frm2.Dock = DockStyle.Fill;
            frm2.Show();
        }

        private void btRut_Click(object sender, EventArgs e)
        {
            formRutTien frm2 = new formRutTien();
            frm2.TopLevel = false;
            panelGuiTien.Controls.Add(frm2);
            frm2.Dock = DockStyle.Fill;
            frm2.Show();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            //button quay lại form Doanh Số
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            int count = 0;
            count = dtgSoTK.Rows.Count;
            string chuoi = "STK0";
            int chuoi2 = 0;
            //chuoi = Convert.ToString(dtgSoTK.Rows[count - 2].Cells[0].Value);
            chuoi2 = Convert.ToInt32(chuoi.Remove(0,3));
            if (chuoi2 + 1 > 0)
            {
                if (count == 0)
                {
                    tbMaTK.Text = "STK01";
                }
                else
                    tbMaTK.Text = "STK0" + (chuoi2 + 1).ToString();
            }
            string MaTK = tbMaTK.Text;
            string TenKH = tbTenKH.Text;
            string DiaChi = tbDiaChi.Text;
            string CMND = tbCMND.Text;
            DateTime ngayMoSo = dtpNgayMoSo.Value;
            double soTienGui = Convert.ToDouble(tbTienGui.Text);
            LOAITIETKIEM Loai = cbLoaiSo.SelectedValue as LOAITIETKIEM;

            //da xuat hien trong csdl

            SOTIETKIEM stk = database.SOTIETKIEMs.Where(s => s.MASOTK == MaTK).SingleOrDefault();
            if (stk != null)
            {
                MessageBox.Show("Sổ Tiết Kiệm đã tồn tại");
                return;
            }
            else
            {
                KHACHHANG kh = new KHACHHANG();
                int countkh = 0;
                string chuoikh = "";
                int chuoikh2 = 0;
                //chuoi = Convert.ToString(dtgSoTK.Rows[count - 2].Cells[0].Value);
                //chuoi2 = Convert.ToInt32(chuoi.Remove(0,2));
                if (chuoikh2 + 1 > 0)
                {
                    if (count == 0)
                    {
                        kh.MAKH = "KH01";
                        countkh++;
                    }
                    else
                    {
                        kh.MAKH = "KH0" + (chuoi2 + 1).ToString();
                        countkh++;
                    }
                }
                stk.MAKH = MaTK;
                stk.MAKH = kh.MAKH;
                kh.HOTEN = TenKH;
                stk.MALOAITK = Loai.MALOAITK;
                kh.CMND = Convert.ToByte(CMND);
                kh.DIACHI = DiaChi;
                stk.NGAYMOSO = ngayMoSo;
                stk.SOTIENGUI = soTienGui;
                database.SOTIETKIEMs.Add(stk);
                database.KHACHHANGs.Add(kh);
                database.SaveChanges();
                LoadThongTin();
                MessageBox.Show("Thêm mới sinh viên thành công");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Xóa sổ tiệt kiệm
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Thay đổi thông tin sổ tiết kiệm
        }

        private void formSoTietKiem_Load(object sender, EventArgs e)
        {
            tbMaTK.ReadOnly = true;
            tbTenKH.Enabled = false;
            tbDiaChi.Enabled = false;
            tbCMND.Enabled = false;
            tbTienGui.Enabled = false;
            dtpNgayMoSo.Enabled = false;
            cbLoaiSo.Enabled = false;
            tbMaTK.Enabled = false;
        }
        private void LoadThongTin()
        {
            int count = 0;
            count = dtgSoTK.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            //chuoi = Convert.ToString(dtgSoTK.Rows[count - 2].Cells[0].Value);
            //chuoi2 = Convert.ToInt32(chuoi.Remove(0,3));
            if (chuoi2 + 1 > 0)
            {
                if (count == 0)
                {
                    tbMaTK.Text = "STK01";
                }
                else
                    tbMaTK.Text = "STK0" + (chuoi2 + 1).ToString();
            }
            var dsSTK = from stk in database.SOTIETKIEMs
                        select new
                        {
                            MaTK = stk.MASOTK,
                            TenKH = stk.KHACHHANG.HOTEN,
                            TienGui = stk.SOTIENGUI,
                            DiaChi = stk.KHACHHANG.DIACHI,
                            CMND = stk.KHACHHANG.CMND,
                            NgayMoSo = stk.NGAYMOSO,
                            LoaiSo = stk.LOAITIETKIEM.LOAI
                        };
            dtgSoTK.DataSource = dsSTK.ToList();
            cbLoaiSo.DataSource = database.LOAITIETKIEMs.ToList();
            cbLoaiSo.DisplayMember = "Loai";

            //Add bingding
            //AddSoTietKiemBindings();
        }
        private void AddSoTietKiemBindings()
        {
            tbMaTK.DataBindings.Clear();
            tbTenKH.DataBindings.Clear();
            tbTienGui.DataBindings.Clear();
            tbCMND.DataBindings.Clear();
            tbDiaChi.DataBindings.Clear();
            dtpNgayMoSo.DataBindings.Clear();
            cbLoaiSo.DataBindings.Clear();
            //Add lai binding
            tbMaTK.DataBindings.Add("Text", dtgSoTK.DataSource, "MASOTK");
            tbTenKH.DataBindings.Add("Text", dtgSoTK.DataSource, "HOTEN");
            tbTienGui.DataBindings.Add("Text", dtgSoTK.DataSource, "SOTIENGUI");
            tbCMND.DataBindings.Add("Text", dtgSoTK.DataSource, "CMND");
            tbDiaChi.DataBindings.Add("Text", dtgSoTK.DataSource, "DIACHI");
            dtpNgayMoSo.DataBindings.Add("Text", dtgSoTK.DataSource, "NGAYMOSO");
            cbLoaiSo.DataBindings.Add("Text", dtgSoTK.DataSource, "LOAI");
        }
}
}
