using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_EF02
{
  public class Event
    {
        public int EventId { get; set; }
        public string Description { get; set; }
        public  DateTime Startdate { get; set; }
        public int MaxNumOfAttendances { get; set; }
            

    }
}
