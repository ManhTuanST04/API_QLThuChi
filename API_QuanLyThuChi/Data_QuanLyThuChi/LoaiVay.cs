//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data_QuanLyThuChi
{
    using System;
    using System.Collections.Generic;
    
    public partial class LoaiVay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiVay()
        {
            this.Vay_ChoVay = new HashSet<Vay_ChoVay>();
        }
    
        public int id { get; set; }
        public string Loai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vay_ChoVay> Vay_ChoVay { get; set; }
    }
}
