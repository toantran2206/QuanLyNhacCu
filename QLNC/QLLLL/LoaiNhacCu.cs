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
    
    public partial class LoaiNhacCu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiNhacCu()
        {
            this.NhacCus = new HashSet<NhacCu>();
        }
    
        public string MaLoaiNC { get; set; }
        public string TenLoaiNC { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhacCu> NhacCus { get; set; }
    }
}
