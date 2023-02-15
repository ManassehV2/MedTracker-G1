/**using MedAdvisor.Api.Controllers;
using MedAdvisor.DataAccess.MySql;
using MedAdvisor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace MedAdvisor.Api.Tests
{
    [TestFixture]
    public class AllergyControllerTests
    {
        private MedAdvisorDbContext _dbContext;
        private MedicineController _controller;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<MedAdvisorDbContext>()
                .UseInMemoryDatabase(databaseName: "test")
                .Options;

            _dbContext = new MedAdvisorDbContext(options);
            _controller = new AllergyController(_dbContext);
        }

        [TearDown]
        public void TearDown()
        {
            _dbContext.Dispose();
        }

        [Test]
        public async Task GetAllergys_ReturnsEmptyList_WhenNoAllergiesExist()
        {
            // Arrange
            _dbContext.Allergies.RemoveRange(await _dbContext.Allergies.ToListAsync());
            await _dbContext.SaveChangesAsync();

            // Act
            var result = await _controller.GetAllergys();

            // Assert
            Assert.IsEmpty(result.Value);
        }

        [Test]
        public async Task GetAllergys_ReturnsAllAllergies_WhenAllergiesExist()
        {
            // Arrange
            var allergies = new List<Allergy>
            {
                new Allergy { AllergyId = 1, UserId = 1, AllergyName = "Peanuts" },
                new Allergy { AllergyId = 2, UserId = 1, AllergyName = "Shellfish" },
                new Allergy { AllergyId = 3, UserId = 2, AllergyName = "Pollen" }
            };
            await _dbContext.Allergies.AddRangeAsync(allergies);
            await _dbContext.SaveChangesAsync();

            // Act
            var result = await _controller.GetAllergys();

            // Assert
            Assert.AreEqual(allergies.Count, result.Value.Count);
        }

        [Test]
        public async Task GetAllergy_ReturnsNotFound_WhenAllergyDoesNotExist()
        {
            // Arrange
            var id = 1;
            _dbContext.Allergies.RemoveRange(await _dbContext.Allergies.ToListAsync());
            await _dbContext.SaveChangesAsync();

            // Act
            var result = await _controller.GetAllergy(id);

            // Assert
            Assert.IsInstanceOf<NotFoundResult>(result.Result);
        }

        [Test]
        public async Task GetAllergy_ReturnsAllergy_WhenAllergyExists()
        {
            // Arrange
            var allergy = new Allergy { AllergyId = 1, UserId = 1, AllergyName = "Peanuts" };
            await _dbContext.Allergies.AddAsync(allergy);
            await _dbContext.SaveChangesAsync();

            // Act
            var result = await _controller.GetAllergy(allergy.AllergyId);

            // Assert
            Assert.AreEqual(allergy, result.Value);
        }

        // Tests for PostAllergy, PutAllergy and DeleteAllergy methods can also be written using a similar approach.
    }
}
*/