namespace HotelManagement.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phong")]
    public partial class Phong
    {
        [Key]
        [StringLength(5)]
        public string MaPH { get; set; }

        [Required]
        [StringLength(20)]
        public string TTPH { get; set; }

        [Required]
        [StringLength(20)]
        public string TTDD { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }

        [Required]
        [StringLength(5)]
        public string MaLPH { get; set; }

        public virtual LoaiPhong LoaiPhong { get; set; }
    }
}
