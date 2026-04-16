using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_EF02
{
    public class Organizer
    {
        
        public int OrganizerId { get; set; }
      
        public string Name { get; set; } = string.Empty;
        public string? CompanyName { get; set; }

        public bool IsVerified { get; set; }

        public OrganizerProfile? Profile { get; set; }
    }
}
