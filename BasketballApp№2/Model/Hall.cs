//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BasketballApp_2.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hall
    {
        public int HallID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Nullable<int> Capacity { get; set; }
        public string Phone { get; set; }
        public string Category { get; set; }
        public Nullable<int> ClubID { get; set; }
    
        public virtual Club Club { get; set; }
    }
}
