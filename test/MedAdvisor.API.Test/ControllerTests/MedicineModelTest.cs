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
    public class MedicineModelTest
    {
        [Test]
        public void TestMedicineNameProperty()
        {
            // Arrange
            var medicine = new Medicine();

            // Act
            var result = medicine.MedicineName;

            // Assert
            Assert.AreEqual(string.Empty, result);
        }
    }
}
