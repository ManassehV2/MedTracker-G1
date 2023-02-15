using MedAdvisor.DataAccess.Mysql;
using MedAdvisor.Models;
using NUnit.Framework;


namespace MedAdvisor.API.Test.ControllerTests
{
    public class DocumentModelTest
    {
        [Test]
        public void TestDocumentNameProperty()
        {
            // Arrange
            var document = new Document();

            // Act
            var result = document.Title;
            var result2 = document.Description;

            // Assert
            Assert.AreEqual(string.Empty, result);
            Assert.AreEqual(string.Empty, result2);
        }
    }
}
