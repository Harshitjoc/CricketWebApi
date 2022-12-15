using System.ComponentModel.DataAnnotations.Schema;

namespace Cricket.Data.Models
{
    public class Stadium : BaseEntity
    {
        public string Name { get; set; }
        public int CountryId { get; set; }
        public string Timezone { get; set; }

        public virtual ICollection<MatchDetail> MatchDetails { get; } = new List<MatchDetail>();
    }
}
