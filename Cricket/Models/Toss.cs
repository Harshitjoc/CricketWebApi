using System.ComponentModel.DataAnnotations.Schema;

namespace Cricket.Models
{
    public class Toss
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Winner { get; set; }
        public string Decision { get; set; }

        public virtual ICollection<MatchDetail> MatchDetails { get; } = new List<MatchDetail>();
    }
}
