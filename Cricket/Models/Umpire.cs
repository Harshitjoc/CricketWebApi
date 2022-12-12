﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Cricket.Models
{
    public class Umpire
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }

        public virtual ICollection<UmpireRoleMap> UmpireRoleMaps  { get; } = new List<UmpireRoleMap>();
    }
}
