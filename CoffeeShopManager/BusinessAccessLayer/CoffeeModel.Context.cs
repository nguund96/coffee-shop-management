﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CoffeeEntities : DbContext
    {
        public CoffeeEntities()
            : base("name=CoffeeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Ban> Ban { get; set; }
        public virtual DbSet<CaLamViec> CaLamViec { get; set; }
        public virtual DbSet<ChamCong> ChamCong { get; set; }
        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDon { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<KhuVuc> KhuVuc { get; set; }
        public virtual DbSet<LichSuHoatDong> LichSuHoatDong { get; set; }
        public virtual DbSet<LoaiMon> LoaiMon { get; set; }
        public virtual DbSet<Mon> Mon { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<PhanCong> PhanCong { get; set; }
        public virtual DbSet<PhieuChi> PhieuChi { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<ThongTinQuan> ThongTinQuan { get; set; }
        public virtual DbSet<VW_Bill> VW_Bill { get; set; }
        public virtual DbSet<VW_Mon> VW_Mon { get; set; }
        public virtual DbSet<VW_ThongKeDoanhThu> VW_ThongKeDoanhThu { get; set; }
        public virtual DbSet<VW_ThongKeMonTheoNgay> VW_ThongKeMonTheoNgay { get; set; }
    }
}