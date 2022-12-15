using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cricket.Data.Models
{
    public class Player : BaseEntity
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public int CountryId { get; set; }


        [ForeignKey(nameof(CountryId))]
        public  Country Country { get; set; }

        public virtual ICollection<TeamPlayerMap> TeamPlayerMaps { get; } = new List<TeamPlayerMap>();
        public virtual ICollection<PlayerRoleMap> PlayerRoleMaps { get; } = new List<PlayerRoleMap>();
        public virtual ICollection<BatsmanScoreBoard> BatsmanScoreBoards { get; } = new List<BatsmanScoreBoard>();
        public virtual ICollection<BowlerScoreBoard> BowlerScoreBoards { get; } = new List<BowlerScoreBoard>();
    }
}