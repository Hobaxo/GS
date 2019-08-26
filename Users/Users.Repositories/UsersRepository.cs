using System.Collections.Generic;
using System.Linq;
using Users.Data;
using System.Web.Mvc;

namespace Users.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        public IEnumerable<SelectListItem> RetrieveAllUsers()
        {
            using (var context = new UsersDbContext())
            {
                List<SelectListItem> users = context.Users.AsNoTracking()
                    .OrderBy(n => n.Id)
                    .Select(n =>
                        new SelectListItem
                        {
                            Value = n.Id.ToString(),
                            Text = n.FirstName + " " + n.LastName
                        }).ToList();

                var defaultTip = new SelectListItem()
                {
                    Value = null,
                    Text = "--"
                };
                users.Insert(0, defaultTip);

                return new SelectList(users, "Value", "Text");
            }
        }

        public List<Project> RetrieveAllProjects()
        {
            using (var context = new UsersDbContext())
            {
                var projects = from project in context.Projects
                    orderby project.Id
                    select project;

                return projects.ToList();
            }
        }

        public List<UserProject> RetrieveAllUserProjects()
        {
            using (var context = new UsersDbContext())
            {
                var userProjects = from userProject in context.UserProjects
                    orderby userProject.UserId
                    select userProject;

                return userProjects.ToList();
            }
        }

        public List<UserProject> RetrieveUserProjects(string userId)
        {
            using (var context = new UsersDbContext())
            {
                var userProjects = from userProject in context.UserProjects
                    where userProject.UserId.ToString() == userId
                    orderby userProject.UserId
                    select userProject;

                return userProjects.ToList();
            }
        }
    }
}
