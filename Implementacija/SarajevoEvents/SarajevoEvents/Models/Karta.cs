using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SarajevoEvents.Models
{
    public class Karta
    {

        [Key]
        public int ID { get; set; }

        [ForeignKey("Dogadjaj")]
        public int IDDogadjaj { get; set; }

        public Dogadjaj dogadjaj { get; set; }
        
        [ForeignKey("RegistrovaniKorisnik")]
        public int? IDRegistrovaniKorisnik { get; set; }
        public RegistrovaniKorisnik? RegistrovaniKorisnik { get; set; }

        [ForeignKey("Placanje")]
        public int IDPlacanje { get; set; }

        public Placanje placanje { get; set; }

        public double cijena { get; set; }

        public Karta() { }
    }
}