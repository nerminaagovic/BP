//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GradFilmaEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rezervacija
    {
        public Rezervacija()
        {
            this.Karta = new HashSet<Karta>();
        }
    
        public int idRezervacije { get; set; }
        public int brojMjesta { get; set; }
        public decimal cijena { get; set; }
        public int specijalnaPonudaId { get; set; }
        public int projekcijaId { get; set; }
        public Nullable<int> uposlenikId { get; set; }
    
        public virtual ICollection<Karta> Karta { get; set; }
        public virtual Korisnik Korisnik { get; set; }
        public virtual Projekcija Projekcija { get; set; }
        public virtual SpecijalnePonude SpecijalnePonude { get; set; }
    }
}
