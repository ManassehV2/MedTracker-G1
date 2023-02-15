using MedAdvisor.DataAccess.Mysql;
using MedAdvisor.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedAdvisor.API.Test.ControllerTests
{
    public class ResetPasswordModelTest
    {
        [Test]
        public void TestResetPasswordNameProperty()
        {
            // Arrange
            var reset = new ResetPasswordRequest();

            // Act
            var result = reset.Token;
            var result2 = reset.Password;
            var result3= reset.ConfirmPassword;


            // Assert
            Assert.AreEqual(string.Empty, result);
            Assert.AreEqual(string.Empty, result2);
            Assert.AreEqual(string.Empty, result3);

        }
    }
}
