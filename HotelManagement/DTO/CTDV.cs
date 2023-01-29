namespace HotelManagement.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTDV")]
    public partial class CTDV
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(7)]
        public string MaCTDP { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string MaDV { get; set; }

        public int SL { get; set; }

        [Column(TypeName = "money")]
        public decimal ThanhTien { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "money")]
        public decimal DonGia { get; set; }

        public bool? DaXoa { get; set; }
        
        public CTDV(CTDV a)
        {
            this.SL = a.SL;
            this.DaXoa = a.DaXoa;
            this.DonGia = a.DonGia;
            this.ThanhTien = a.ThanhTien;
            this.MaDV = a.MaDV;
            this.MaCTDP = a.MaCTDP;
        }
        public CTDV()
        { }    
    }
}
