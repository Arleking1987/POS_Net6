using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace POS.Domain.Entities
{
    public partial class MenuRole
    {
        [Key]
        public int MenuRolId { get; set; }
        public int? RoleId { get; set; }
        public int? MenuId { get; set; }
        public int? State { get; set; }

        public virtual Menu? Menu { get; set; }
        public virtual Role? Role { get; set; }
    }
}
