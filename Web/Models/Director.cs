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
    
    public partial class Director
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Director()
        {
            this.Director_Movie = new HashSet<Director_Movie>();
            this.Director_TVSeries = new HashSet<Director_TVSeries>();
        }
    
        public string DirectorID { get; set; }
        public string FullName { get; set; }
        public string Images { get; set; }
        public string BirthName { get; set; }
        public Nullable<System.DateTime> DateofBirth { get; set; }
        public string Height { get; set; }
        public string Nationality { get; set; }
        public string Picture { get; set; }
        public string Born { get; set; }
        public string About { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Director_Movie> Director_Movie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Director_TVSeries> Director_TVSeries { get; set; }
    }
}
