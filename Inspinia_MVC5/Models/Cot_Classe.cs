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
    
    public partial class Cot_Classe
    {
        public string N_Cotisant { get; set; }
        public string C_Classe { get; set; }
        public string C_Periode { get; set; }
        public string Id_Agence { get; set; }
    
        public virtual Classe Classe { get; set; }
        public virtual Cotisant Cotisant { get; set; }
        public virtual Periode Periode { get; set; }
    }
}
