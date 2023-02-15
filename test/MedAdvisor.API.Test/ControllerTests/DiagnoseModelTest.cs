using MedAdvisor.DataAccess.Mysql;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedAdvisor.API.Test.ControllerTests
{
    public class DiagnoseModelTest
    {
        [Test]
        public void TestDiagnoseNameProperty()
        {
            // Arrange
            var diagnose = new Diagnose();

            // Act
            var result = diagnose.DiagnoseName;

            // Assert
            Assert.AreEqual(string.Empty, result);
        }
    }
}
