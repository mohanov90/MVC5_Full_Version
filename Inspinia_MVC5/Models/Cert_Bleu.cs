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
    
    public partial class Cert_Bleu
    {
        public string Numero { get; set; }
        public string N_Annee { get; set; }
        public string N_Salarie { get; set; }
        public string N_Employeur { get; set; }
        public int N_Decompte { get; set; }
        public Nullable<System.DateTime> Date_Recep { get; set; }
        public Nullable<System.DateTime> Date_Deb_Eff { get; set; }
        public Nullable<System.DateTime> Date_Fin_Eff { get; set; }
        public int Nb_Jours_Eff { get; set; }
        public decimal Salaire_Eff { get; set; }
        public int Nb_Jours_Mal { get; set; }
        public decimal Salaire_Mal { get; set; }
        public int Nb_Jours_At { get; set; }
        public decimal Salaire_At { get; set; }
        public int Nb_Jours_Mat { get; set; }
        public decimal Salaire_Mat { get; set; }
        public Nullable<System.DateTime> Date_Depart { get; set; }
        public Nullable<System.DateTime> Date_Debauchage { get; set; }
        public string Etat { get; set; }
        public string Type_Eff { get; set; }
        public string Code_Saisie { get; set; }
        public string Observ { get; set; }
        public string Code_Valide { get; set; }
        public string Id_Agence { get; set; }
    }
}
