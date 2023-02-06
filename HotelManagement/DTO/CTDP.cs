namespace HotelManagement.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTDP")]
    public partial class CTDP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CTDP()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        [StringLength(7)]
        public string MaCTDP { get; set; }

        [Column(TypeName = "money")]
        public decimal DonGia { get; set; }
        public int? SoNguoi { get; set; }

        [Required]
        [StringLength(5)]
        public string MaPT { get; set; }

        [Required]
        [StringLength(5)]
        public string MaPH { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CheckIn { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime CheckOut { get; set; }

        [Required]
        [StringLength(20)]
        public string TrangThai { get; set; }
        public decimal ThanhTien { get; set; }
        public bool? DaXoa { get; set; }

        public bool TheoGio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        public virtual PhieuThue PhieuThue { get; set; }

        public virtual Phong Phong { get; set; }
    }
}
