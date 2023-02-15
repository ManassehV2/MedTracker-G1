using MedAdvisor.Models;
using NUnit.Framework;

namespace MedAdvisor.API.Test.ControllerTests
{
    public class AllergyModelTest
    {
        [Test]
        public void TestAllergyNameProperty()
        {
            // Arrange
            var allergy = new Allergy();

            // Act
            var result = allergy.AllergyName;

            // Assert
            Assert.AreEqual(string.Empty, result);
        }
    }
}
