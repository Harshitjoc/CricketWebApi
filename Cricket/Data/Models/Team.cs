using System.ComponentModel.DataAnnotations.Schema;

namespace Cricket.Data.Models
{
    public class Team : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<TeamPlayerMap> TeamPlayerMaps { get; } = new List<TeamPlayerMap>();
        public virtual ICollection<ScoreBoard> ScoreBoards { get; } = new List<ScoreBoard>();
    }
}