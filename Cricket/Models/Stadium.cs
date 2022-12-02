using System.ComponentModel.DataAnnotations.Schema;

namespace Cricket.Models
{
    public class Stadium
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public string Timezone { get; set; }

        public virtual ICollection<MatchDetail> MatchDetails { get; } = new List<MatchDetail>();
    }
}
