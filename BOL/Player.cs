using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public Guid TeamId { get; set; }
        public string Postion { get; set; }
        public int Goals { get; set; }
        public int Saves { get; set; }
        public int Assists { get; set; }
        public bool ApprovalFromParents { get; set; }
        public int Payment { get; set; }
        public int Points { get; set; }
        public bool CommunityProject { get; set; }
        public double NotificationsVersion { get; set; }
        public DateTime LastNotificationsDate { get; set; }

        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }

        [ForeignKey("TeamId")]
        public virtual Team Team { get; set; }


    }
}
