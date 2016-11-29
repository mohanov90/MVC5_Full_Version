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
    
    public partial class FicheVisite
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FicheVisite()
        {
            this.ContacteInfoes = new HashSet<ContacteInfo>();
        }
    
        public string Id_Agence { get; set; }
        public int N_OrdreCh { get; set; }
        public string N_Cotisant { get; set; }
        public int Id_CotisantNonAff { get; set; }
        public System.DateTime DateVisite { get; set; }
        public string Adresse { get; set; }
        public Nullable<double> TauxAvancement { get; set; }
        public System.DateTime DateConvocation { get; set; }
        public int NbreSalarieControle { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Rais_Soc_Fr { get; set; }
        public string NomResp { get; set; }
        public string PrenomResp { get; set; }
        public string FonctionResp { get; set; }
        public string AffiliationCaco { get; set; }
        public string N_Teleph { get; set; }
        public Nullable<System.DateTime> ModifierLe { get; set; }
        public string ModifierPar { get; set; }
        public string CodeUser { get; set; }
        public string Etat { get; set; }
    
        public virtual Chantier Chantier { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContacteInfo> ContacteInfoes { get; set; }
    }
}
