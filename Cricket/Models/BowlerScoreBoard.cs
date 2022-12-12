using System.ComponentModel.DataAnnotations.Schema;

namespace Cricket.Models
{
    public class BowlerScoreBoard
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Wickets { get; set; }
        public int Overs { get; set; }
        public int PlayerId { get; set; }
    }
}
