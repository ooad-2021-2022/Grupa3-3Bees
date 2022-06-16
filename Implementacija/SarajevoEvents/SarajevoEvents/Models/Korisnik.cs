using System.ComponentModel.DataAnnotations;

namespace SarajevoEvents.Models
{
    public abstract class Korisnik
    {
        [Key]
        public int ID { get; set; }

        public string email { get; set; }

        public string ime { get; set; }

        public string prezime { get; set; }

        public string userName { get; set; }

        public string brojTelefona { get; set; }

        public string lozinka { get; set; }

        public string ImePrezime
        {
            get
            {
                return  prezime + ", " + ime;
            }
        }

        public Korisnik() { }
    }
}