using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Workhous.Models
{
    public class ProjectTimeEntry
    {
        public ProjectTimeEntry()
        {

        }
        public ProjectTimeEntry(string _project, TimeEntry _timeEntry)
        {
            this.ProjectName = _project;
            this.TimeEntry = _timeEntry;
        }
        [Display(Name = "Project Name")]
        public string ProjectName { get; set; }
        public TimeEntry TimeEntry { get; set; }
    }
}