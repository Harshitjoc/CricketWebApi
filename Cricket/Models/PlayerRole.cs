using System.ComponentModel.DataAnnotations.Schema;

namespace Cricket.Models
{
    public class PlayerRole
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

        public virtual ICollection<TeamA> TeamAs { get; } = new List<TeamA>();
        public virtual ICollection<TeamB> TeamBs { get; } = new List<TeamB>();
    }
}
