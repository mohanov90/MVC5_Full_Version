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
    
    public partial class RapportVisiteRa
    {
        public System.DateTime DateRapport { get; set; }
        public string N_cotisant { get; set; }
        public int Id_CotisantNonAff { get; set; }
        public int N_ordreCh { get; set; }
        public string Id_Agence { get; set; }
        public string Agence { get; set; }
        public string AdresseAgence { get; set; }
        public string TelephoneAgence { get; set; }
        public Nullable<System.DateTime> ModifierLe { get; set; }
        public string ModifierPar { get; set; }
        public Nullable<int> N_Rapport { get; set; }
        public string CodeUser { get; set; }
        public string Adresse { get; set; }
        public string NomEntreprise { get; set; }
        public string NatureRepresentant { get; set; }
        public string NomRepresentant { get; set; }
        public string AdresseAgenceA { get; set; }
        public string AdresseChantierArabe { get; set; }
        public string NomSocArabe { get; set; }
        public string NomPrenomControleurAr { get; set; }
        public string agenceAr { get; set; }
        public string NatureRepresentantAr { get; set; }
        public string NomRepresentantAR { get; set; }
        public string Commentaire { get; set; }
        public string CommentaireAr { get; set; }
    
        public virtual Chantier Chantier { get; set; }
    }
}