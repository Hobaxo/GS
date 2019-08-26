using System.Collections.Generic;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Users.Services;
using Users.Web.Controllers;
using Moq;
using Users.Web.ViewModels;

namespace Users.Web.Tests.Controllers
{
    [TestClass]
    public class UserControllerTest
    {
        private Mock<IUsersService> usersService;
        private const string UserId = "1";

        [TestInitialize]
        public void Initialize()
        {
            this.usersService = new Mock<IUsersService>();
            this.usersService.Setup(controller => controller.RetrieveUsers()).Returns(new List<SelectListItem>());
            this.usersService.Setup(controller => controller.RetrieveAllUserProjects(UserId)).Returns(new List<UserProjectsViewModel>());
        }

        [TestMethod]
        public void ShallRetrieveView_ResultIsNotNull()
        {
            // Arrange
            UserController controller = new UserController(this.usersService.Object);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        //Here I would continue testing out all the controller APIs
    }
}
