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
    
    public partial class TietKiem
    {
        public int id { get; set; }
        public System.DateTime Ngay { get; set; }
        public int SoTien { get; set; }
        public string ThanhVien { get; set; }
        public Nullable<int> MucDich { get; set; }
    
        public virtual MucDichTietKiem MucDichTietKiem { get; set; }
        public virtual ThanhVien ThanhVien1 { get; set; }
    }
}
