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
    
    public partial class FicheControleSupprime
    {
        public int Id { get; set; }
        public string Id_Agence { get; set; }
        public System.DateTime DateControle { get; set; }
        public string Adresse { get; set; }
        public System.DateTime DateConvocation { get; set; }
        public int NbreSalarieControle { get; set; }
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
        public string MotifDeControle { get; set; }
        public string N_Cotisant { get; set; }
        public Nullable<int> Id_CotisantNonAff { get; set; }
        public string ServiceDemandeur { get; set; }
    }
}
