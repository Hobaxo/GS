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

        // GET: User
        public ActionResult Index()
        {
            var users = new UsersViewModel
            {
                Users = this.usersService.RetrieveUsers().ToList(),
                UserProjects = this.usersService.RetrieveAllUserProjects()
            };

            return View(users);
        }

        [HttpGet]
        public ActionResult RetrieveUserProjects(string userId)
        {
            if (!string.IsNullOrWhiteSpace(userId))
            {
                var userProjects = this.usersService.RetrieveAllUserProjects().Where(user => user.UserId == userId);
                return Json(userProjects, JsonRequestBehavior.AllowGet);
            }

            return Json(null, JsonRequestBehavior.AllowGet);
        }
    }
}
