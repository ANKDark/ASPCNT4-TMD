using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TMDLap05._1.Models
{
    public class TMDMember
    {
        [Required(ErrorMessage = "TMD: Hãy nhập mã số")]
        [DataType(DataType.Currency)]
        public int? Id { get; set; }
        [Required(ErrorMessage = "TMD: Hãy nhập tên đăng nhập")]
        public string TMDUsername { get; set; }
        [Required(ErrorMessage = "TMD: Hãy nhập họ và tên")]
        public string TMDFullName { get; set; }
        [Required(ErrorMessage = "TMD: Hãy nhập mật khẩu")]
        [DataType(DataType.Password)]
        public string TMDPassword { get; set; }
        [Required(ErrorMessage = "TMD: Hãy nhập tuổi")]
        [Range (18, 50, ErrorMessage = "TMD: Tuổi từ 18 - 50")]
        public int? TMDAge { get; set; }
        [Required(ErrorMessage = " Hãy nhập email")]
        [RegularExpression (@"[A-Za - z0-9._%+-] + @[A-Za - z0-9.-]+\.[A-Za - z] {2 - 4}", ErrorMessage = "TMD: Email phải đúng định dạng")]
        public string TMDEmail { get; set; }
    }
}