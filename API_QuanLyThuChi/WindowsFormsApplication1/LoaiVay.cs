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
    
    public partial class LoaiVay
    {
        public LoaiVay()
        {
            this.Vay_ChoVay = new HashSet<Vay_ChoVay>();
        }
    
        public int id { get; set; }
        public string Loai { get; set; }
    
        public virtual ICollection<Vay_ChoVay> Vay_ChoVay { get; set; }
    }
}
