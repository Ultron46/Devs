//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PublishedProject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PublishedProject()
        {
            this.ReleaseProjects = new HashSet<ReleaseProject>();
        }
    
        public int Publish_Id { get; set; }
        public int Build_Id { get; set; }
        public int E_Id { get; set; }
        public System.DateTime PublisheDate { get; set; }
    
        public virtual BuildProject BuildProject { get; set; }
        public virtual EndUser EndUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReleaseProject> ReleaseProjects { get; set; }
    }
}
