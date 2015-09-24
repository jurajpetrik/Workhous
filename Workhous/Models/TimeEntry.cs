using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Workhous.Models
{
    public class TimeEntry
    {
        public int ID { get; set; }
        public DateTime Day { get; set; }
        [Display(Name = "Amount of Hours")]
        [Range(0.5, 24, ErrorMessage = "The value must be greater than 0.5 and lower than 24")]
        public decimal NumOfHours { get; set; }
        public int ProjectID { get; set; }
        [ForeignKey("ProjectID")]
        public virtual Project Project { get; set; }
    }
}