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
    
    public partial class Mandat
    {
        public System.DateTime C_Session { get; set; }
        public int Numero { get; set; }
        public string N_Annee { get; set; }
        public int N_Dec { get; set; }
        public string N_Salarie { get; set; }
        public string N_Employeur { get; set; }
        public Nullable<decimal> Net { get; set; }
        public string Etat { get; set; }
        public Nullable<System.DateTime> Date_Paiement { get; set; }
        public string Id_Agence { get; set; }
    
        public virtual Annee_CP Annee_CP { get; set; }
        public virtual Salarie Salarie { get; set; }
        public virtual Session Session { get; set; }
    }
}
