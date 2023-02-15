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
    public class VaccineModelTest
    {
        [Test]
        public void TestVaccineNameProperty()
        {
            // Arrange
            var vaccine = new Vaccine();

            // Act
            var result = vaccine.VaccineName;

            // Assert
            Assert.AreEqual(string.Empty, result);
        }
    }
}
