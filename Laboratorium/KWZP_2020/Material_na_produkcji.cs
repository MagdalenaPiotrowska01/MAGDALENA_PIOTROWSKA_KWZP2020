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
    
    public partial class Material_na_produkcji
    {
        public int ID_procesu_produkcyjnego { get; set; }
        public int ID_element { get; set; }
        public double Liczba { get; set; }
        public int ID_jednostka { get; set; }
        public Nullable<double> Odpad { get; set; }
    
        public virtual Magazyn_elementy Magazyn_elementy { get; set; }
        public virtual Magazyn_elementy_jednostki Magazyn_elementy_jednostki { get; set; }
        public virtual Proces_Produkcyjny Proces_Produkcyjny { get; set; }
    }
}