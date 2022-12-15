using System.ComponentModel.DataAnnotations.Schema;

namespace Cricket.Data.Models
{
    public class PlayerRoleMap : BaseEntity
    {
        public int PlayerId { get; set; }
        public int PlayerRoleId { get; set; }

    }
}
