//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Thongtinnhankhau
    {
        public int CMND { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> dob { get; set; }
        public Nullable<bool> Gender { get; set; }
        public string Dantoc { get; set; }
        public Nullable<int> IDQuanhe { get; set; }
        public Nullable<int> SoSHK { get; set; }
        public string NgheNghiep { get; set; }
        public string Diachi { get; set; }
        public string NguyenQuan { get; set; }
        public string SDT { get; set; }
        public Nullable<int> IDtamtru { get; set; }
    
        public virtual DSHoKhau DSHoKhau { get; set; }
        public virtual QHChuho QHChuho { get; set; }
        public virtual Tamtru Tamtru { get; set; }
    }
}
