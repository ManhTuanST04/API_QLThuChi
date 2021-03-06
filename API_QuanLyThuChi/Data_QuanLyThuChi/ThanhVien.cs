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
    
    public partial class ThanhVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThanhVien()
        {
            this.CongViecs = new HashSet<CongViec>();
            this.KhoanChis = new HashSet<KhoanChi>();
            this.KhoanThus = new HashSet<KhoanThu>();
            this.TietKiems = new HashSet<TietKiem>();
            this.TrangThais = new HashSet<TrangThai>();
            this.Vay_ChoVay = new HashSet<Vay_ChoVay>();
        }
    
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string TenTV { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaVi { get; set; }
        public string CauHoiBM { get; set; }
        public string CauTraLoi { get; set; }
        public byte[] Anh { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public Nullable<int> Quyen { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CongViec> CongViecs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhoanChi> KhoanChis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhoanThu> KhoanThus { get; set; }
        public virtual Quyen Quyen1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TietKiem> TietKiems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrangThai> TrangThais { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vay_ChoVay> Vay_ChoVay { get; set; }
    }
}
