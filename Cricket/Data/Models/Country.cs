using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cricket.Data.Models
{
    [Index(nameof(Name), IsUnique = true)]
    public class Country : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Player> Players { get; } = new List<Player>();

        public virtual ICollection<Stadium> Stadiums { get; } = new List<Stadium>();

        public virtual ICollection<Umpire> Umpires { get; } = new List<Umpire>();
    }
}
