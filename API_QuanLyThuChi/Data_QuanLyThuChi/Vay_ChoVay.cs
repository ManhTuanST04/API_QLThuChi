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
    
    public partial class Vay_ChoVay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vay_ChoVay()
        {
            this.TraNoes = new HashSet<TraNo>();
        }
    
        public int id { get; set; }
        public Nullable<System.DateTime> NgayVay { get; set; }
        public Nullable<int> SoTien { get; set; }
        public string ThanhVien { get; set; }
        public Nullable<int> Loai { get; set; }
        public string NguoiVay { get; set; }
    
        public virtual LoaiVay LoaiVay { get; set; }
        public virtual NguoiVay NguoiVay1 { get; set; }
        public virtual ThanhVien ThanhVien1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TraNo> TraNoes { get; set; }
    }
}
