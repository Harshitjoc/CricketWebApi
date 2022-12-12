using System.ComponentModel.DataAnnotations.Schema;

namespace Cricket.Models
{
    public class PlayerRoleMap
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int PlayerRoleId { get; set; }

    }
}
