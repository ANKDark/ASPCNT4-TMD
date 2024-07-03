using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TmdLesson06CF.Models
{
    public class TmdBookStore : DbContext
    {
        public TmdBookStore() : base("TmdBookStoreConnectionString") { }

        // Khai báo các thuộc tính ứng với các bảng trong cơ sở dữ liệu
        public DbSet<TmdCategory> TmdCategories { get; set; }
        public DbSet<TmdBook> TmdBooks { get; set; }
    }
}
