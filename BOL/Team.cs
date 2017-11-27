using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BOL
{
    [Table("Team")]
    public class Team
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
        public string PlyaerName1 { get; set; }
        public string PlyaerName2 { get; set; }
        public string PlyaerName3 { get; set; }
        public string PlyaerName4 { get; set; }
        public string PlyaerName5 { get; set; }
        public string PlyaerName6 { get; set; }
        public string PlyaerName7 { get; set; }

    }
}
