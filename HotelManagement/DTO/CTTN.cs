namespace HotelManagement.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTTN")]
    public partial class CTTN
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string MaLPH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string MaTN { get; set; }

        public int? SL { get; set; }
        public bool? DaXoa { get; set; }

        public virtual TienNghi TienNghi { get; set; }
    }
}
