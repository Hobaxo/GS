using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Users.Services;
using Users.Web.Controllers;

namespace Users.Web.Tests.Controllers
{
    [TestClass]
    public class UserControllerTest
    {
        //This should be DI'ed and mocked up for unit testing purposes
        private readonly IUsersService usersService;

        [TestMethod]
        public void Index()
        {
            // Arrange
            UserController controller = new UserController(usersService);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        //Here I would test out all the controller APIs
    }
}
