using System.ComponentModel.DataAnnotations.Schema;

namespace Cricket.Models
{
    public class Team
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TeamPlayerMap> TeamPlayerMaps { get; } = new List<TeamPlayerMap>();
        public virtual ICollection<ScoreBoard> ScoreBoards { get; } = new List<ScoreBoard>();
    }
}