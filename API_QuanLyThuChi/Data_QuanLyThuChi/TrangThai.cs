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
    
    public partial class TrangThai
    {
        public int MaTT { get; set; }
        public string ThanhVien { get; set; }
        public Nullable<System.DateTime> Ngay { get; set; }
        public Nullable<int> CamXuc { get; set; }
        public string TrangThai1 { get; set; }
        public byte[] Anh { get; set; }
        public Nullable<System.TimeSpan> Gio { get; set; }
    
        public virtual LoaiCamXuc LoaiCamXuc { get; set; }
        public virtual ThanhVien ThanhVien1 { get; set; }
    }
}