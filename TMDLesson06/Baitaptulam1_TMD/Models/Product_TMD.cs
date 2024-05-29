using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Baitaptulam1_TMD.Models
{
    public class Product_TMD
    {
            [Required (ErrorMessage ="Hãy nhập Id sản phẩm")]
            public string ProductId_TMD { get; set; }
            [Required(ErrorMessage = "Hãy nhập tên sản phẩm")]
            public string ProductName_TMD { get; set; }
            [Required(ErrorMessage = "Hãy nhập công cụ sản phẩm")]
            public string Unit_TMD { get; set; }
            [Required(ErrorMessage = "Hãy nhập công giá sản phẩm")]
            [Range (1, 100000000, ErrorMessage = "Giá sản phẩm phải là số dương từ 1 - 100000000")]    
            public int Price_TMD { get; set; }
    }
}