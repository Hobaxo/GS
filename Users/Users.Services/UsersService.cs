using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Users.Data;
using Users.Repositories;
using Users.Web.ViewModels;
using Utilities;

namespace Users.Services
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository usersRepository;
        
        public UsersService(IUsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        public IEnumerable<SelectListItem> RetrieveUsers()
        {
            return this.usersRepository.RetrieveAllUsers();
        }

        public IEnumerable<UserProjectsViewModel> RetrieveAllUserProjects(string userId)
        {
            var userProjects = string.IsNullOrEmpty(userId) ? this.usersRepository.RetrieveAllUserProjects() : this.usersRepository.RetrieveUserProjects(userId);
            var projects = this.usersRepository.RetrieveAllProjects();
            var userProjectsViewModels =  CreateUserProjectObjects(userProjects, projects);
            
            return userProjectsViewModels;
        }

        private List<UserProjectsViewModel> CreateUserProjectObjects(List<UserProject> userProjects, List<Project> projects)
        {
            List<UserProjectsViewModel> presentationUserProjects = new List<UserProjectsViewModel>();

            foreach (var project in userProjects)
            {
                var matchingProject = projects.FirstOrDefault(p => p.Id == project.ProjectId);

                if (matchingProject != null)
                {
                    presentationUserProjects.Add(
                        new UserProjectsViewModel()
                        {
                            UserId = project.UserId.ToString(),
                            ProjectId = project.ProjectId.ToString(),
                            StartDate = matchingProject.StartDate,
                            TimeToStart = Calculations.CalculateTimeToStart(matchingProject.StartDate, project.AssignedDate),
                            EndDate = matchingProject.EndDate,
                            Credits = matchingProject.Credits.ToString(),
                            Status = project.IsActive ? "Active" : "Inactive"
                        });
                }
            }

            return presentationUserProjects;
        }
    }
}
