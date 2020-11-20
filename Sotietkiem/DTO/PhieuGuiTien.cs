using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    [Table("PhieuGuiTien")]
    public class PhieuGuiTien
    {
        string maPhieuGui;
        string maKH;
        double soTienGui;
        string ngayGuiTien;
        [Key]
        public string MaPhieuGui { get => maPhieuGui; set => maPhieuGui = value; }
        [ForeignKey("MaKH")]
        public virtual KhachHang KH { get; set; }
        [Required]
        public string MaKH { get => maKH; set => maKH = value; }
        public double SoTienGui { get => soTienGui; set => soTienGui = value; }
        [Required]
        public string NgayGuiTien { get => ngayGuiTien; set => ngayGuiTien = value; }
        public PhieuGuiTien() { }
        public PhieuGuiTien(string maPhieuGui, string maKH, double soTienGui, string ngayGuiTien)
        {
            this.maPhieuGui = maPhieuGui;
            this.maKH = maKH;
            this.soTienGui = soTienGui;
            this.ngayGuiTien = ngayGuiTien;
        }
    }
}
