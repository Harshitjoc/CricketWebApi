using System.ComponentModel.DataAnnotations.Schema;

namespace Cricket.Data.Models
{
    public class UmpireRole : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<UmpireRoleMap> UmpireRoleMaps { get; } = new List<UmpireRoleMap>();
    }
}
