using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace HotelManagement.DTO
{
    public partial class HotelDTO : DbContext
    {
        public HotelDTO()
            : base("name=HotelDTO")
        {
        }

        public virtual DbSet<CTDP> CTDPs { get; set; }
        public virtual DbSet<CTDV> CTDVs { get; set; }
        public virtual DbSet<CTTN> CTTNs { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhieuThue> PhieuThues { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<TienNghi> TienNghis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<CTDP>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.CTDP)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<PhieuThue>()
                .HasMany(e => e.CTDPs)
                .WithRequired(e => e.PhieuThue)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<DichVu>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);
               
            modelBuilder.Entity<HoaDon>()
                .Property(e => e.TriGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SDT)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.CCCD_Passport)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.PhieuThues)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiPhong>()
                .Property(e => e.GiaNgay)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LoaiPhong>()
                .Property(e => e.GiaGio)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LoaiPhong>()
                .HasMany(e => e.Phongs)
                .WithRequired(e => e.LoaiPhong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.Luong)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SDT)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.CCCD)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.PhieuThues)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.TaiKhoans)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TienNghi>()
            .HasMany(e => e.CTTNs)
            .WithRequired(e => e.TienNghi)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phong>()
            .HasMany(e => e.CTDPs)
            .WithRequired(e => e.Phong)
            .WillCascadeOnDelete(false);
        }
    }
}
