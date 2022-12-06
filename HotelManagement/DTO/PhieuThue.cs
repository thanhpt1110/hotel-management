namespace HotelManagement.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuThue")]
    public partial class PhieuThue
    {
        [Key]
        [StringLength(5)]
        public string MaPT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime NgPT { get; set; }

        [Required]
        [StringLength(5)]
        public string MaKH { get; set; }

        [Required]
        [StringLength(5)]
        public string MaNV { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
