//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class KhoanThu
    {
        public string MaKT { get; set; }
        public string MaThanhVien { get; set; }
        public System.DateTime Ngay { get; set; }
        public string LoaiKT { get; set; }
        public string KhoanThu1 { get; set; }
        public double SoTien { get; set; }
        public string GhiChu { get; set; }
    
        public virtual LoaiKhoanThu LoaiKhoanThu { get; set; }
        public virtual ThanhVien ThanhVien { get; set; }
    }
}
