﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TmdLesson07Db.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TmdK22CNT4Lesson07DbEntities : DbContext
    {
        public TmdK22CNT4Lesson07DbEntities()
            : base("name=TmdK22CNT4Lesson07DbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tmdKhoa> tmdKhoa { get; set; }
        public virtual DbSet<tmdSinhVien> tmdSinhVien { get; set; }
    }
}
