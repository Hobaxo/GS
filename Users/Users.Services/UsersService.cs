using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using Users.Data;
using Users.Repositories;
using Users.Web.ViewModels;

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

        public IEnumerable<UserProjectsViewModel> RetrieveAllUserProjects()
        {
            var userProjects = this.usersRepository.RetrieveAllUserProjects();
            var projects = this.usersRepository.RetrieveAllProjects();
            var userProjectsViewModels =  Testa(userProjects, projects);

            
            return userProjectsViewModels;
        }

        public IEnumerable<SelectListItem> RetrieveAllUserProjects(string userId)
        {
            //var projects = this.usersRepository.RetrieveAllUserProjects(userId);
            return null;
        }

        private List<UserProjectsViewModel> Testa(List<UserProject> userProjects, List<Project> projects)
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
                            TimeToStart = CalculateTimeToStart(matchingProject.StartDate, project.AssignedDate),
                            EndDate = matchingProject.EndDate,
                            Credits = matchingProject.Credits.ToString(),
                            Status = project.IsActive ? "Active" : "Inactive"
                        });
                }
            }

            return presentationUserProjects;
        }

        private static string CalculateTimeToStart(DateTime startDate, DateTime assignedDate)
        {
            var days = (startDate - assignedDate).TotalDays;

            return days >= 0 ? days.ToString(CultureInfo.InvariantCulture) : "Started";
        }
    }
}
