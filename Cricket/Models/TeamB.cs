using System.ComponentModel.DataAnnotations.Schema;

namespace Cricket.Models
{
    public class TeamB
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int PlayerId { get; set; }
        public int PlayerRoleId { get; set; }

        public virtual ICollection<MatchDetail> MatchDetails { get; } = new List<MatchDetail>();
    }
}
