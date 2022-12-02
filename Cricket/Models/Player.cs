using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cricket.Models
{
    public class Player
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public int Age { get; set; }

        public int CountryId { get; set; }

        public virtual ICollection<TeamA> TeamAs { get; } = new List<TeamA>();
        public virtual ICollection<TeamB> TeamBs { get; } = new List<TeamB>();


    }
}