using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace Cricket.Data.Models
{
    public class MatchDetail : BaseEntity
    {
        public int TeamAId { get; set; }
        public int TeamBId { get; set; }
        public int StadiumId { get; set; }
        public int SeriesId { get; set; }
        public int MatchNo { get; set; }
        public int UmpireRoleMapId { get; set; }
        public string MatchReferee { get; set; }
        public int BatsmanScoreBoardId { get; set; }
        public int BowlerScoreBoardId { get; set; }
        public string Toss { get; set; }


        [ForeignKey(nameof(UmpireRoleMapId))]
        public virtual UmpireRoleMap UmpireRoleMap { get; set; }

        [ForeignKey(nameof(BatsmanScoreBoardId))]
        public virtual BatsmanScoreBoard BatsmanScoreBoard { get; set; }

        [ForeignKey(nameof(BowlerScoreBoardId))]
        public virtual BowlerScoreBoard BowlerScoreBoard { get; set; }

        [ForeignKey(nameof(StadiumId))]
        public virtual Stadium Stadium { get; set; }

        [ForeignKey(nameof(SeriesId))]
        public virtual Series Series { get; set; }

        [ForeignKey(nameof(TeamAId))]
        public virtual Team TeamA { get; set; }

        [ForeignKey(nameof(TeamBId))]
        public virtual Team TeamB { get; set; }

    }
}
