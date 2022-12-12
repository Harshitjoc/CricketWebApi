using System.ComponentModel.DataAnnotations.Schema;

namespace Cricket.Models
{
    public class ScoreBoard
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int TeamId { get; set; }
        public int Scored { get; set; }
    }
}
