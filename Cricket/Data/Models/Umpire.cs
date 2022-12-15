using System.ComponentModel.DataAnnotations.Schema;

namespace Cricket.Data.Models
{
    public class Umpire : BaseEntity
    {
        public string Name { get; set; }
        public int CountryId { get; set; }

        public virtual ICollection<UmpireRoleMap> UmpireRoleMaps { get; } = new List<UmpireRoleMap>();
    }
}
