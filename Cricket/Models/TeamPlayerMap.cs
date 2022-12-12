using System.ComponentModel.DataAnnotations.Schema;


namespace Cricket.Models
{
    public class TeamPlayerMap
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int TeamId { get; set; }
        public int PlayerId { get; set; }
        public bool Counter { get; set; }
    }
}
