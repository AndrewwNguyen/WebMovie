//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cast_Movie
    {
        public string CastID { get; set; }
        public string IDMovie { get; set; }
        public string About { get; set; }
    
        public virtual Cast Cast { get; set; }
        public virtual Movie Movie { get; set; }
    }
}