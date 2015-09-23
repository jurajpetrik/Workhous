using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Workhous.Models
{
    public class ProjectTimeEntry
    {
        public ProjectTimeEntry()
        {

        }
        public ProjectTimeEntry(Project _project, TimeEntry _timeEntry)
        {
            this.Project = _project;
            this.TimeEntry = _timeEntry;
        }
        public Project Project { get; set; }
        public TimeEntry TimeEntry { get; set; }
    }
}