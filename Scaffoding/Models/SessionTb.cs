//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Scaffoding.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SessionTb
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SessionTb()
        {
            this.SessionAttendances = new HashSet<SessionAttendance>();
        }
    
        public int uuid { get; set; }
        public string sessionName { get; set; }
        public string location { get; set; }
        public string timing { get; set; }
        public Nullable<int> capacity { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SessionAttendance> SessionAttendances { get; set; }
    }
}
