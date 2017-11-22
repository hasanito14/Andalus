using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    [Table("User")]
    public class User
    {
        public User()
        {
            UserId = Guid.NewGuid();
            CreatedDate = DateTime.Now;
        }
        [Key]
        public Guid UserId { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Password { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Email { get; set; }

        [NotMapped]
        public string ConfirmPassword { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid RoleId { get; set; }

        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }
    }
}
