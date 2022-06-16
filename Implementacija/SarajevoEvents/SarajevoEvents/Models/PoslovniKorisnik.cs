using System.ComponentModel.DataAnnotations;

namespace SarajevoEvents.Models
{
    
    public class PoslovniKorisnik : Korisnik
    {
        public string nazivKorisnika { get; set; }

        public int brojNagradnihBodova { get; set; }

        public PoslovniKorisnik() { }
    }
}