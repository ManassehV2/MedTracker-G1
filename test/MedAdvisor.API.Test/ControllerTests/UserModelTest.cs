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
    public class UserModelTest
    {
        [Test]
        public void TestUserNameProperty()
        {
            // Arrange
            var user = new User();

            // Act
            var result = user.FirstName;
            var result2 = user.SecondName;
            var result3 = user.BirthDate;
            var result4 = user.Nationality;
            var result5 = user.PostalAddress;
            var result6 = user.TravelInsurance;
            var result7 = user.AlarmTelephone;
            var result8 = user.OtherInformation;


            // Assert
            Assert.AreEqual(string.Empty, result);
            Assert.AreEqual(string.Empty, result2);
            Assert.AreEqual(string.Empty, result3);
            Assert.AreEqual(string.Empty, result4);
            Assert.AreEqual(string.Empty, result5);
            Assert.AreEqual(string.Empty, result6);
            Assert.AreEqual(string.Empty, result7);
            Assert.AreEqual(string.Empty, result8);
        }
    }
}
