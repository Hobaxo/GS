using System;
using System.Collections.Generic;
using Users.Data;

namespace Users.Web.ViewModels
{
    public class UserProjectsViewModel
    {
        public string UserId { get; set; } 
        public string ProjectId { get; set; }
        public DateTime StartDate { get; set; }
        public string TimeToStart { get; set; }
        public DateTime EndDate { get; set; }
        public string Credits { get; set; }
        public string Status { get; set; }

        public List<UserProject> ProjectsPerUser { get; set; }
    }
}