//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class CaLamViec
    {
        public CaLamViec()
        {
            this.PhanCongs = new HashSet<PhanCong>();
        }
    
        public string MaCa { get; set; }
        public string TenCa { get; set; }
        public Nullable<System.TimeSpan> GioBatDau { get; set; }
        public Nullable<System.TimeSpan> GioKetThuc { get; set; }
        public Nullable<double> MucLuong { get; set; }
    
        public virtual ICollection<PhanCong> PhanCongs { get; set; }
    }
}
