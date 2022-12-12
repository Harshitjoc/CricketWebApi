using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cricket.Models
{
    public class Player
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public int CountryId { get; set; }

        public virtual ICollection<TeamPlayerMap> TeamPlayerMaps { get; } = new List<TeamPlayerMap>();
        public virtual ICollection<PlayerRoleMap> PlayerRoleMaps { get; } = new List<PlayerRoleMap>();
        public virtual ICollection<BatsmanScoreBoard> BatsmanScoreBoards { get; } = new List<BatsmanScoreBoard>();
        public virtual ICollection<BowlerScoreBoard> BowlerScoreBoards { get; } = new List<BowlerScoreBoard>();
    }
}