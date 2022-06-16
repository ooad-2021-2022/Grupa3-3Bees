using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SarajevoEvents.Models
{
    public class Feedback
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("RegistrovaniKorisnik")]
        public int KorisnikID { get; set; }
        public RegistrovaniKorisnik Korisnik { get; set; }
    }
}