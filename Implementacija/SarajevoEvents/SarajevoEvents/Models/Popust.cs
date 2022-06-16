using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SarajevoEvents.Models
{
    public class Popust
    {

        [Key]
        public int ID { get; set; }

        [ForeignKey("RegistrovaniKorisnik")]
        public int IDRegistrovaniKorisnik { get; set; }

        public RegistrovaniKorisnik RegistrovaniKorisnik { get; set; }

        public string skupljeniBodovi { get; set; }

        public double vrijednostPopusta { get; set; }

        public Popust() { }
    }
}