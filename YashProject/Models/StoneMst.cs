//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YashProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class StoneMst
    {
        public Nullable<int> Style_Code { get; set; }
        public Nullable<int> StoneQlty_ID { get; set; }
        public int Stone_Gm { get; set; }
        public int Stone_Pcs { get; set; }
        public int Stone_Crt { get; set; }
        public int Stone_Rate { get; set; }
        public int Stone_Amt { get; set; }
    
        public virtual ItemMst ItemMst { get; set; }
        public virtual StoneQltyMst StoneQltyMst { get; set; }
    }
}
