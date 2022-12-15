using System.ComponentModel.DataAnnotations.Schema;

namespace Cricket.Data.Models
{
    public class PlayerRole : BaseEntity
    {
        public string Name { get; set; }
        public string ShortName { get; set; }

        public virtual ICollection<PlayerRoleMap> PlayerRoleMaps { get; } = new List<PlayerRoleMap>();
    }
}