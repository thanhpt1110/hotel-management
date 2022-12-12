namespace HotelManagement.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            PhieuThues = new HashSet<PhieuThue>();
        }

        [Key]
        [StringLength(5)]
        public string MaKH { get; set; }

        [Required]
        [StringLength(50)]
        public string TenKH { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [Column("CCCD/Passport")]
        [Required]
        [StringLength(12)]
        public string CCCD_Passport { get; set; }

        [Required]
        [StringLength(30)]
        public string QuocTich { get; set; }

        [Required]
        [StringLength(3)]
        public string GioiTinh { get; set; }

        public bool? DaXoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuThue> PhieuThues { get; set; }
    }
}
