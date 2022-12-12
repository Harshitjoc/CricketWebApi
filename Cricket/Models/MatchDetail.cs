using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace Cricket.Models
{
    public class MatchDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int TeamId { get; set; }
        public int StadiumId { get; set;}
        public int SeriesId { get; set; }
        public int TossId { get; set;}
        public int UmpireRoleMapId { get; set; }
        [Range(11, 14,ErrorMessage = "Player must be in between 11-14.")]
        public int PlayerCount { get; set; }

    }
}
