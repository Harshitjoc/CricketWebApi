using System.ComponentModel.DataAnnotations.Schema;

namespace Cricket.Models
{
    public class MatchDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? TeamAId { get; set; }
        public int? TeamBId { get; set; }
        public int StadiumId { get; set;}
        public int SeriesId { get; set; }
        public int TossId { get; set;}
        public int? UmpireRoleId { get; set; }
    }
}
