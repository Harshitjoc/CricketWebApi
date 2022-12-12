using System.ComponentModel.DataAnnotations.Schema;

namespace Cricket.Models
{
    public class UmpireRoleMap
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int UmpireId { get; set; }
        public int UmpireRoleId { get; set; }

        public virtual ICollection<MatchDetail> MatchDetails { get; } = new List<MatchDetail>();
    }
}
