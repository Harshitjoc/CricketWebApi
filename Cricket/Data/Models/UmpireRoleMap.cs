using System.ComponentModel.DataAnnotations.Schema;

namespace Cricket.Data.Models
{
    public class UmpireRoleMap : BaseEntity
    {
        public int UmpireId { get; set; }
        public int UmpireRoleId { get; set; }

        public virtual ICollection<MatchDetail> MatchDetails { get; } = new List<MatchDetail>();
    }
}
