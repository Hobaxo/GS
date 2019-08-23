using System.Collections.Generic;
using System.Web.Mvc;
using Users.Web.ViewModels;

namespace Users.Services
{
    public interface IUsersService
    {
        IEnumerable<SelectListItem> RetrieveUsers();

        IEnumerable<UserProjectsViewModel> RetrieveAllUserProjects();

        IEnumerable<SelectListItem> RetrieveAllUserProjects(string userId);
    }
}
