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
    
    public partial class ChantierHistorique
    {
        public int id { get; set; }
        public string id_agence { get; set; }
        public Nullable<int> id_CotisantNonAff { get; set; }
        public Nullable<int> N_OrdreCh { get; set; }
        public string N_Cotisant { get; set; }
        public string NatureTravauxCh { get; set; }
        public string MaitreOuvrageCh { get; set; }
        public string AdresseCh { get; set; }
        public Nullable<System.DateTime> DateDebutCh { get; set; }
        public string EtatDeControleCh { get; set; }
        public string N_PV_Ch { get; set; }
        public Nullable<int> CodeUserCh { get; set; }
        public string DelaiCh { get; set; }
        public string Wilaya { get; set; }
        public string CodeGeo { get; set; }
        public Nullable<System.DateTime> ModifierLe { get; set; }
        public string ModifierPar { get; set; }
        public string adresseChantierArabe { get; set; }
    }
}
