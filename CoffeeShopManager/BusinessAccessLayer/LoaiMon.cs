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
    
    public partial class LoaiMon
    {
        public LoaiMon()
        {
            this.Mons = new HashSet<Mon>();
        }
    
        public string MaLoaiMon { get; set; }
        public string TenLoaiMon { get; set; }
    
        public virtual ICollection<Mon> Mons { get; set; }
    }
}
