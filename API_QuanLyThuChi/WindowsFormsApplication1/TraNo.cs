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
    
    public partial class TraNo
    {
        public int id { get; set; }
        public int KhoanVay { get; set; }
        public Nullable<System.DateTime> NgayTra { get; set; }
        public Nullable<int> SoTien { get; set; }
    
        public virtual Vay_ChoVay Vay_ChoVay { get; set; }
    }
}
