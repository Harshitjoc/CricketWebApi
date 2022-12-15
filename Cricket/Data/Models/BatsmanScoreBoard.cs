using System.ComponentModel.DataAnnotations.Schema;

namespace Cricket.Data.Models
{
    public class BatsmanScoreBoard : BaseEntity
    {
        public int PlayerId { get; set; }
        public int Runs { get; set; }
        public int Balls { get; set; }
        public int Sixes { get; set; }
        public int Fours { get; set; }
        public string status { get; set; }

        public virtual ICollection<MatchDetail> MatchDetails { get; } = new List<MatchDetail>();
    }
}
