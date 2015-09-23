using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Workhous.Models
{
    public class TimeEntry
    {
        public int ID { get; set; }
        public DateTime Day { get; set; }
        public int NumOfHours { get; set; }
        public int ProjectID { get; set; }
        [ForeignKey("ProjectID")]
        public virtual Project Project { get; set; }
    }
}