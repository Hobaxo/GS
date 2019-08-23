using System.Linq;
using System.Web.Mvc;
using Users.Data;

namespace Users.Web.Controllers
{
    /*
    public class User : Controller
    {
        //private 
        public ActionResult Index()
        {
            // var test = new 
            return View();
        }

        public ActionResult About()
        {
            using (var db = new UsersDbContext()) {

                var query = from b in db.Users
                    orderby b.Id select b;

                foreach (var item in query) {
                    ViewBag.Message += item.FirstName +" "+ item.LastName;
                }
            }
            //ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
    */
}