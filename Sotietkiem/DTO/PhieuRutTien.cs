using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    [Table("PhieuRutTien")]
    public class PhieuRutTien
    {
        string maPhieuRut;
        string maKH;
        double soTienRut;
        string ngayRutTien;
        [Key]
        public string MaPhieuGui { get => maPhieuRut; set => maPhieuRut = value; }
        [ForeignKey("MaKH")]
        public virtual KhachHang KH { get; set; }
        [Required]
        public string MaKH { get => maKH; set => maKH = value; }
        public double SoTienGui { get => soTienRut; set => soTienRut = value; }
        [Required]
        public string NgayGuiTien { get => ngayRutTien; set => ngayRutTien = value; }
        public PhieuRutTien() { }
        public PhieuRutTien(string maPhieuGui, string maKH, double soTienGui, string ngayGuiTien)
        {
            this.maPhieuRut = maPhieuGui;
            this.maKH = maKH;
            this.soTienRut = soTienGui;
            this.ngayRutTien = ngayGuiTien;
        }
    }
}
