﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Cricket.Models
{
    public class UmpireRole
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<UmpireRoleMap> UmpireRoleMaps { get; } = new List<UmpireRoleMap>();
    }
}
