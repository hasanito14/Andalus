using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BOL
{
    [Table("Role")]
    public partial class Role
    {
        public Role()
        {
            RoleId = Guid.NewGuid();
            CreatedDate = DateTime.Now;
        }
        [Key]
        public Guid RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleCode { get; set; }
        public string RoleDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual IEnumerable<User> Users { get; set; }
        public virtual IEnumerable<Player> Players { get; set; }
    }
}
