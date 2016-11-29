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
    
    public partial class PvHistorique
    {
        public int Id { get; set; }
        public int Id_CotisantNonAff { get; set; }
        public int N_OrdreCh { get; set; }
        public Nullable<int> N_Ordre { get; set; }
        public string CodeUtilisateur { get; set; }
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
        public string Adresseagence { get; set; }
        public string Telephoneagence { get; set; }
        public Nullable<System.DateTime> ModifierLe { get; set; }
        public string ModifierPar { get; set; }
        public string DatePV { get; set; }
        public string N_Cotisant { get; set; }
        public string AdresseAgenceA { get; set; }
        public string AdresseChantierArabe { get; set; }
        public string NomSocArabe { get; set; }
        public string NomPrenomControleurAr { get; set; }
        public string AdresseSociA { get; set; }
        public string AccuseReceptionParAr { get; set; }
        public string Qualitear { get; set; }
        public string agencear { get; set; }
    
        public virtual Infraction Infraction { get; set; }
        public virtual Partiellement Partiellement { get; set; }
        public virtual Totalement Totalement { get; set; }
    }
}
