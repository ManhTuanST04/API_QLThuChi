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
    
    public partial class MucDichTietKiem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MucDichTietKiem()
        {
            this.TietKiems = new HashSet<TietKiem>();
        }
    
        public int id { get; set; }
        public string TenMucDich { get; set; }
        public Nullable<double> SoTienDuKien { get; set; }
        public Nullable<int> TrangThai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TietKiem> TietKiems { get; set; }
    }
}
