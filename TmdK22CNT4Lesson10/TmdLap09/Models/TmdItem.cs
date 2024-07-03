using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TmdLap09.Models
{
    public class TmdItem
    {
            public int TmdId { get; set; }
            public string TmdName { get; set; }
            public string TmdPicture { get; set; }
            public int TmdQuantity { get; set; }
            public decimal TmdPrice { get; set; }
            public decimal TmdAmount { get; set; }
    }
}