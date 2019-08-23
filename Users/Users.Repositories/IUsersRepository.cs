using System.Collections.Generic;
using System.Web.Mvc;
using Users.Data;

namespace Users.Repositories
{
    public interface IUsersRepository
    {
        IEnumerable<SelectListItem> RetrieveAllUsers();

        List<Project> RetrieveAllProjects();

        List<UserProject> RetrieveAllUserProjects();
    }
}
