//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TmdLesson09.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TmdKetqua
    {
        public string TmdMaMH { get; set; }
        public string TmdMaSV { get; set; }
        public Nullable<decimal> TmdDiem { get; set; }
    
        public virtual TmdMonHoc TmdMonHoc { get; set; }
        public virtual TmdSinhVien TmdSinhVien { get; set; }
    }
}
