//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kkd_specopg_ADO
{
    using System;
    using System.Collections.Generic;
    
    public partial class kunder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public kunder()
        {
            this.arrangementer = new HashSet<arrangementer>();
        }
    
        public int id { get; set; }
        public string navn { get; set; }
        public Nullable<int> rabat { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<arrangementer> arrangementer { get; set; }
    }
}
