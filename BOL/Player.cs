using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    [Table("Player")]
    public partial class Player
    {
        public Player()
        {
            PalyerId = Guid.NewGuid();
        }

        [Key]
        public Guid PalyerId { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string FirstName { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string LastName { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string JerseyName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Email { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Password { get; set; }

        [NotMapped]
        public string ConfirmPassword { get; set; }
        public string Gender { get; set; }
        public string Street1 { get; set; }
        public string Street22 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public Int16 Phone { get; set; }
        public Guid RoleId { get; set; }

        public virtual Role Role { get; set; }

    }
}
