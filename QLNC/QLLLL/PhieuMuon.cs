//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLLLL
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhieuMuon
    {
        public string MaSV { get; set; }
        public string MaNC { get; set; }
        public Nullable<System.DateTime> NgayMuon { get; set; }
        public Nullable<System.DateTime> NgayTra { get; set; }
        public Nullable<double> ThanhTien { get; set; }
    
        public virtual NhacCu NhacCu { get; set; }
        public virtual SinhVien SinhVien { get; set; }
    }
}
