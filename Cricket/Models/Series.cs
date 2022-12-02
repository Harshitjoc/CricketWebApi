using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cricket.Models
{
    public class Series
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Category { get; set; }

        public virtual ICollection<MatchDetail> MatchDetails { get; } = new List<MatchDetail>();
    }
}
