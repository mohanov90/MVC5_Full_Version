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
    
    public partial class Affiliation
    {
        public decimal Numero { get; set; }
        public string N_Cotisant { get; set; }
        public string Rais_Soc_Fr { get; set; }
        public string Adresse_Fr { get; set; }
        public int Effectif { get; set; }
        public System.DateTime D_Depot_Dos { get; set; }
        public System.DateTime Date_Delivre { get; set; }
        public string Code_User { get; set; }
        public string Id_Agence { get; set; }
    
        public virtual Cotisant Cotisant { get; set; }
    }
}
