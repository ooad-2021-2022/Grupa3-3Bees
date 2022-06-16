using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SarajevoEvents.Models
{
    public class Placanje
    {

        [Key]
        public int ID { get; set; }

        public string nazivSistema { get; set; }

        public string korisnik { get; set; }

        public double cijenaZaPlatiti { get; set; }

        [ForeignKey("Popust")]

        public int IDPopust { get; set; }

        public Popust popust { get; set; }

        public double vrijednostPopusta { get; set; }

        public Placanje() { }
    }
}