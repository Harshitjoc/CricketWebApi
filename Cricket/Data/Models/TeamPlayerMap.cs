using System.ComponentModel.DataAnnotations.Schema;
using System.Data;


namespace Cricket.Data.Models
{
    public class TeamPlayerMap : BaseEntity
    {
        public int TeamId { get; set; }
        public int PlayerId { get; set; }


    }
}
