using System.ComponentModel.DataAnnotations.Schema;

namespace Cricket.Models
{
    public class Country
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Player> Players { get; } = new List<Player>();

        public virtual ICollection<Stadium> Stadiums { get; } = new List<Stadium>();

        public virtual ICollection<Umpire> Umpires { get; } = new List<Umpire>();
    }
}
