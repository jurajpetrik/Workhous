using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Workhous.Models
{
    public class TimeEntry
    {
        public int ID { get; set; }
        public DateTime from { get; set; }
        public DateTime until { get; set; }
        public virtual Project Project { get; set; }
    }
}