using System.ComponentModel.DataAnnotations.Schema;

namespace Cricket.Models
{
    public class PlayerRole
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

        public virtual ICollection<PlayerRoleMap> PlayerRoleMaps { get; } = new List<PlayerRoleMap>();
    }
}