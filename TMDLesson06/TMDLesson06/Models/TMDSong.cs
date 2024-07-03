using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TMDLesson06.Models
{
    public class TMDSong
    {
        [Key]
        public long Id { get; set; }
        [Required(ErrorMessage = "TMD: Hãy nhập tiêu đề")]
        [DisplayName ("Tiêu đề")]
        public string TMDTitle { get; set; }
        [Required(ErrorMessage = "TMD: Hãy nhập tác giả")]
        [DisplayName("Tác giả")]
        public string TMDAuther { get; set; }
        [Required(ErrorMessage = "TMD: Hãy nhập nghệ sĩ")]
        [DisplayName("Nghệ sĩ")]
        [StringLength (50, MinimumLength = 2, ErrorMessage = "TMD: Tên nghệ sĩ có tối thiểu 2 ký tự, tối đa 50 ký tự")]
        public string TMDArtist { get; set; }
        [Required(ErrorMessage = "TMD: Hãy nhập năm xuất bản")]
        [DisplayName("Năm xuất bản")]
        [RegularExpression (@"[0-9]{4}", ErrorMessage = "TMD: Nhập xuất bản phải có 2 ký tự số")]
        [Range (1900, 2024, ErrorMessage = "TMD: Năm xuất bản trong khoảng 1900 - 2024")]
        public int TMDYearRelease { get; set; }

    }
}