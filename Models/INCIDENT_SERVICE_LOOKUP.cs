//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewDemoProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class INCIDENT_SERVICE_LOOKUP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INCIDENT_SERVICE_LOOKUP()
        {
            this.INCIDENT_CATEGORY_LOOKUP = new HashSet<INCIDENT_CATEGORY_LOOKUP>();
        }
    
        public long incident_service_id { get; set; }
        public string name { get; set; }
        public Nullable<long> incident_business_id { get; set; }
    
        public virtual INCIDENT_BUSINESS_FUNCTION_LOOKUP INCIDENT_BUSINESS_FUNCTION_LOOKUP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INCIDENT_CATEGORY_LOOKUP> INCIDENT_CATEGORY_LOOKUP { get; set; }
    }
}
