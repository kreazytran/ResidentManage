﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBLnh2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PBLEntities : DbContext
    {
        public PBLEntities()
            : base("name=PBLEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DSHoKhau> DSHoKhaus { get; set; }
        public virtual DbSet<QHChuho> QHChuhoes { get; set; }
        public virtual DbSet<Tamtru> Tamtrus { get; set; }
        public virtual DbSet<Thongtinnhankhau> Thongtinnhankhaus { get; set; }
        public virtual DbSet<Dangnhap> Dangnhaps { get; set; }
    }
}
