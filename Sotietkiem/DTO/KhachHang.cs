using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    [Table("KhachHang")]
    public class KhachHang
    {
        string maKH;
        string hoTen;
        string diaChi;
        string CMND;
        public virtual IEnumerable<KhachHang> KH { get; set; }
        [Key]
        public string MaKH { get => maKH; set => maKH = value; }
        [Required]
        public string HoTen { get => hoTen; set => hoTen = value; }
        [Required]
        public string DiaChi { get => diaChi; set => diaChi = value; }
        [Required]
        public string CMND1 { get => CMND; set => CMND = value; }
        public KhachHang() { }
        public KhachHang(string maKH, string hoTen, string diaChi, string CMND)
        {
            this.CMND = CMND;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.maKH = maKH;
        }
    }
}
