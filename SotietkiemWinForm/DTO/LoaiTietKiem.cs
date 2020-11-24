using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{   
    [Table("LoaiTietKiem")]
    public class LoaiTietKiem
    {
        string maLoaiTK;
        string loai;
        string kyHan;
        double laiSuat;
        IEnumerable<LoaiTietKiem> loaiTK { get; set; }
        [Key]
        public string MaLoaiTK { get => maLoaiTK; set => maLoaiTK = value; }
        [Required]
        public string Loai { get => loai; set => loai = value; }
        [Required]
        public string KyHan { get => kyHan; set => kyHan = value; }
        public double LaiSuat { get => laiSuat; set => laiSuat = value; }
        public LoaiTietKiem() { }
        public LoaiTietKiem(string maLoaiTK, string loai, string kyHan, double laiSuat)
        {
            this.maLoaiTK = maLoaiTK;
            this.loai = loai;
            this.laiSuat = laiSuat;
            this.kyHan = kyHan;
        }
    }
}
