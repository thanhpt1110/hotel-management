namespace HotelManagement.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiPhong")]
    public partial class LoaiPhong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiPhong()
        {
            Phongs = new HashSet<Phong>();
        }

        [Key]
        [StringLength(5)]
        public string MaLPH { get; set; }

        [Required]
        [StringLength(20)]
        public string TenLPH { get; set; }

        public int SoGiuong { get; set; }

        public int SoNguoiToiDa { get; set; }

        [Column(TypeName = "money")]
        public decimal GiaNgay { get; set; }

        [Column(TypeName = "money")]
        public decimal GiaGio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phong> Phongs { get; set; }
    }
}
