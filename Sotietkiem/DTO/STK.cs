using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{   
    [Table("SoTietKiem")]
    public class STK
    {
        string maSTK;
        string maKH;
        string maLoaiTK;
        string ngayMoSo;
        double soTienGui;
        [Key]
        public string MaSTK { get => maSTK; set => maSTK = value; }
        [ForeignKey("MaKH")]
        public virtual KhachHang KH { get; set; }
        [Required]
        public string MaKH { get => maKH; set => maKH = value; }
        [ForeignKey("MaLoaiTK")]
        public virtual LoaiTietKiem loaiTK { get; set; }
        [Required]
        public string MaLoaiTK { get => maLoaiTK; set => maLoaiTK = value; }
        [Required]
        public string NgayMoSo { get => ngayMoSo; set => ngayMoSo = value; }
        public double SoTienGui { get => soTienGui; set => soTienGui = value; }
        public STK() { }
        public STK(string maSTK, string maKH, string maLoaiTK, string ngayMoSo, double soTienGui)
        {
            this.maSTK = maSTK;
            this.maKH = maKH;
            this.maLoaiTK = maLoaiTK;
            this.ngayMoSo = ngayMoSo;
            this.soTienGui = soTienGui;
        }
    }
}
