using System.Collections.Generic;
using System.Web.Mvc;

namespace Users.Web.ViewModels
{
    public class UsersViewModel
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IEnumerable<SelectListItem> Users { get; set; }

        public IEnumerable<UserProjectsViewModel> UserProjects { get; set; }
    }
}