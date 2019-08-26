using System.Linq;
using System.Web.Mvc;
using Users.Services;
using Users.Web.ViewModels;

namespace Users.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUsersService usersService;
        
        public UserController(IUsersService usersService)
        {
            this.usersService = usersService;
        }

        public ActionResult Index()
        {
            var users = new UsersViewModel
            {
                Users = this.usersService.RetrieveUsers().ToList(),
                UserProjects = this.usersService.RetrieveAllUserProjects(string.Empty)
            };

            return View(users);
        }

        [HttpGet]
        public ActionResult RetrieveUserProjects(string userId)
        {
            if (!string.IsNullOrWhiteSpace(userId))
            {
                var userProjects = this.usersService.RetrieveAllUserProjects(userId);
                return PartialView("_Projects", userProjects);
            }

            return null;
        }
    }
}
