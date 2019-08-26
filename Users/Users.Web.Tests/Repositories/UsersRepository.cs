using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Unity;
using Users.Repositories;
using Users.Services;

namespace Users.Web.Tests.Repositories
{
    [TestClass]
    public class UsersRepository
    {
        private const string User = "Herberth Urena";

        [TestMethod]
        public void ShallRetrieveAtLeastOneUser_CollectionNotEmpty()
        {
            // Arrange
            Mock<IUsersRepository> usersRepository = new Mock<IUsersRepository>();
            usersRepository.Setup(x => x.RetrieveAllUsers()).Returns(new List<SelectListItem>() {this.CreateUser()});

            // Act
            var users = usersRepository.Object.RetrieveAllUsers();

            // Assert
            Assert.IsTrue(users.Any());
        }

        private SelectListItem CreateUser()
        {
            return new SelectListItem{ Value = "1", Text = User};
        }

        //Here I would continue testing out all the repo APIs
    }
}
