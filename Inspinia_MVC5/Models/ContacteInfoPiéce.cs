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
    
    public partial class ContacteInfoPiéce
    {
        public string Id_Agence { get; set; }
        public int Id_CotisantNonAff { get; set; }
        public string N_Cotisant { get; set; }
        public System.DateTime DateControle { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string LieuNaiss { get; set; }
        public string Fonction { get; set; }
        public Nullable<int> Salaire { get; set; }
        public string Obeservation { get; set; }
        public int ID { get; set; }
        public string Etat { get; set; }
        public string nationalite { get; set; }
        public string DateNaiss { get; set; }
        public string DateRecrute { get; set; }
        public string Source { get; set; }
    
        public virtual FicheControleP FicheControleP { get; set; }
    }
}
