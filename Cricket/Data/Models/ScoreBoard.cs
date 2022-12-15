using System.ComponentModel.DataAnnotations.Schema;

namespace Cricket.Data.Models
{
    public class ScoreBoard : BaseEntity
    {
        public int TeamId { get; set; }
        public int Scored { get; set; }
    }
}
