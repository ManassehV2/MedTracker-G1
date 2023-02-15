using MedAdvisor.Models;
using NUnit.Framework;

namespace MedAdvisor.API.Test.ControllerTests
{
    public class UserLoginRequestModelTest   
    {
        [Test]
        public void TestUserLoginRequestNameProperty()
        {
                // Arrange
                var userLogin = new UserLoginRequest();

                // Act
                var result = userLogin.Email;
                var result2 = userLogin.Password;


               // Assert
               Assert.AreEqual(string.Empty, result);
               Assert.AreEqual(string.Empty, result2);

            }
    }
}
