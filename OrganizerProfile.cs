using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_EF02
{
    public class OrganizerProfile
    {
       
        [Key]
        [ForeignKey(nameof(Organizer))]
        public int OrganizerId { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string? Biography { get; set; }

        [MaxLength(500)]
        public string? WebsiteUrl { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string? LogoUrl { get; set; }

        public Organizer Organizer { get; set; } = null!;
    }
}
