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
    
    public partial class PhanCong
    {
        public PhanCong()
        {
            this.ChamCongs = new HashSet<ChamCong>();
        }
    
        public string MaNV { get; set; }
        public string MaCa { get; set; }
        public string MaKV { get; set; }
    
        public virtual CaLamViec CaLamViec { get; set; }
        public virtual ICollection<ChamCong> ChamCongs { get; set; }
        public virtual KhuVuc KhuVuc { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
