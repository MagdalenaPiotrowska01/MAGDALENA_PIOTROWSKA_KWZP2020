//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KWZP_2020
{
    using System;
    using System.Collections.Generic;
    
    public partial class Faktury_zewnetrzne
    {
        public int ID { get; set; }
        public float Nr_faktury { get; set; }
        public Nullable<int> ID_Grupy { get; set; }
        public string Nazwa_firmy { get; set; }
        public float cena_netto { get; set; }
        public float cena_brutto { get; set; }
        public float podatek { get; set; }
    
        public virtual Grupa Grupa { get; set; }
    }
}