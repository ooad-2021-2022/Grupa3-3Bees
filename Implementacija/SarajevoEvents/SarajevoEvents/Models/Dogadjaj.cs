using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SarajevoEvents.Models
{
    public class Dogadjaj
    {

        [Key]
        public int ID { get; set; }

        public DateTime datumOdrzavanja { get; set; }

        public VrstaDogadjaja vrstaDogadjaja { get; set; }

        public bool potrebnaKarta { get; set; }

        public double cijenaKarte { get; set; }

        public bool potrebnaRezervacija { get; set; }

        public int brojNagradnihBodova { get; set; }

        [ForeignKey("PoslovniKorisnik")]
        public int IDPoslovniKorisnik { get; set; }

        public PoslovniKorisnik PoslovniKorisnik { get; set; }

        public Dogadjaj() { }
    }
}