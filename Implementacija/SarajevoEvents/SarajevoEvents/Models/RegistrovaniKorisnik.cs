using System.ComponentModel.DataAnnotations;

namespace SarajevoEvents.Models
{
    public class RegistrovaniKorisnik : Korisnik
    {
        public string nazivKorisnika { get; set; }

        public RegistrovaniKorisnik() { }
    }
}