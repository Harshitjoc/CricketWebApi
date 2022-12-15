using System.ComponentModel.DataAnnotations.Schema;

namespace Cricket.Data.Models
{
    public class BowlerScoreBoard : BaseEntity
    {
        public int PlayerId { get; set; }
        public int Wickets { get; set; }
        public int Overs { get; set; }
        public int Runs { get; set; }
        public int WideBalls { get; set; }
        public int NoBalls { get; set; }

        public virtual ICollection<MatchDetail> MatchDetails { get; } = new List<MatchDetail>();
    }
}
