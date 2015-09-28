using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Workhous.Models
{
    public class Project
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [Display(Name = "Hourly rate")]
        public decimal PricePerHour { get; set; }
        public virtual ICollection<TimeEntry> TimeEntries { get; set; }
    }

    public class ProjectViewModel
    {
        public ProjectViewModel() { }
        public ProjectViewModel(Project _project) { this.Project = _project; }
        public Project Project { get; set; }
        public DateTime Month { get; set; }
        public string DateString { get; set; }
        public decimal TotalHours { get; set; }
    }
}