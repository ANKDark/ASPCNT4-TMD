using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TmdLesson06CF.Models
{
    public class TmdBook
    {
        [Key]
        public int TmdId { get; set; }
        public string TmdBookId { get; set; }
        public string TmdTitle { get; set; }
        public string TmdAuthor { get; set;}
        public int TmdYear { get; set;}
        public string TmdPublic { get; set;}
        public string TmdPicture { get; set;}
        public int TmdCategoryId { get; set;}
        // Thuộc tính quan hệ
        public virtual TmdCategory TmdCategory { get; set;}
    }
}