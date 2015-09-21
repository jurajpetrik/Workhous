using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Workhous.Models
{
    public class Project
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double PricePerHour { get; set; }
        public virtual ICollection<TimeEntry> TimeEntries { get; set; }
    }
}