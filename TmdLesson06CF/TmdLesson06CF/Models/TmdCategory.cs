using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TmdLesson06CF.Models
{
    public class TmdCategory
    {
        [Key]
        public int TmdId { get; set; }
        public string TmdCategoryName { get; set; }

        // Thuộc tính quan hệ
        public virtual ICollection<TmdBook> TmdBooks { get; set; }
    }
}