using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BOL
{
    [Table("Team")]
    public partial class Team
    {
        public Team()
        {
            TeamId = Guid.NewGuid();
        }
        [Key]
        public Guid TeamId { get; set; }
        public string Name { get; set; }
        public string CaptainName { get; set; }
        public int Points { get; set; }
        public int wins { get; set; }
        public string PlayerName1 { get; set; }
        public string PlayerName2 { get; set; }
        public string PlayerName3 { get; set; }
        public string PlayerName4 { get; set; }
        public string PlayerName5 { get; set; }
        public string PlayerName6 { get; set; }
        public string PlayerName7 { get; set; }

    }
}
