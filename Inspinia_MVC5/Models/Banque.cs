//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inspinia_MVC5.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Banque
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Banque()
        {
            this.Agence_Banq = new HashSet<Agence_Banq>();
        }
    
        public string Code { get; set; }
        public string Abreviat { get; set; }
        public string Libelle_Fr { get; set; }
        public string Libelle_Ar { get; set; }
        public string C_Canal { get; set; }
        public string Id_Agence { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Agence_Banq> Agence_Banq { get; set; }
        public virtual Canal Canal { get; set; }
    }
}
