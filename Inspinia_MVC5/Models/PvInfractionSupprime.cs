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
    
    public partial class PvInfractionSupprime
    {
        public int Id { get; set; }
        public string N_Cotisant { get; set; }
        public int Id_CotisantNonAff { get; set; }
        public int N_OrdreCh { get; set; }
        public System.DateTime DatePv { get; set; }
        public Nullable<int> N_ordre { get; set; }
        public string Id_Agence { get; set; }
        public Nullable<int> Totalement_ID { get; set; }
        public Nullable<int> IdSecond { get; set; }
        public Nullable<int> IdThird { get; set; }
        public Nullable<bool> DefautDeclarationActivite { get; set; }
        public string DefautPaimentCotisantion { get; set; }
        public Nullable<int> SalariersNonDeclaresSur { get; set; }
        public Nullable<int> SalarieSousDeclaresPour { get; set; }
        public string DefautTransmissionDAC { get; set; }
        public Nullable<bool> FaussesDeclarationSurPriodesEtEffectifsCI { get; set; }
        public string AccuseReceptionPar { get; set; }
        public string Qualite { get; set; }
        public Nullable<bool> RefusAccuserReception { get; set; }
        public string AdresseChantier { get; set; }
        public string NomPrenomControleur { get; set; }
        public string NomSociete { get; set; }
        public string AdresseSoc { get; set; }
        public string Agence { get; set; }
        public string AdresseAgence { get; set; }
        public string TelephoneAgence { get; set; }
        public Nullable<System.DateTime> ModifierLe { get; set; }
        public string ModifierPar { get; set; }
        public string CodeUtilisateur { get; set; }
    }
}
