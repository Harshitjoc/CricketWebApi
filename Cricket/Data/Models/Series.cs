using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cricket.Data.Models
{
    public class Series : BaseEntity
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Category { get; set; }

        public virtual ICollection<MatchDetail> MatchDetails { get; } = new List<MatchDetail>();
    }
}
