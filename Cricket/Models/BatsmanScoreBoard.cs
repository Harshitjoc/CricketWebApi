using System.ComponentModel.DataAnnotations.Schema;

namespace Cricket.Models
{
    public class BatsmanScoreBoard
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Scored { get; set; }
        public int PlayerId { get; set; }
        public int Sixes { get; set; }
        public int Fours { get; set; }

    }
}
