using MedAdvisor.Api.Controllers;
using MedAdvisor.DataAccess.MySql;
using MedAdvisor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MedAdvisor.Api.Tests
{
    public class AllergyControllerTests
    {
        private readonly MedAdvisorDbContext _dbContext;
        public AllergyControllerTests()
        {
            var options = new DbContextOptionsBuilder<MedAdvisorDbContext>()
            .UseInMemoryDatabase(databaseName: "MedAdvisorTestDb")
            .Options;
            _dbContext = new MedAdvisorDbContext(options);
            SeedData();
        }

        private void SeedData()
        {
            var allergies = new List<Allergy>
            {
                new Allergy { AllergyId = 1, AllergyName = "Peanuts", UserId = 1 },
                new Allergy { AllergyId = 2, AllergyName = "Lactose", UserId = 1 },
                new Allergy { AllergyId = 3, AllergyName = "Pollen", UserId = 2 },
            };
            _dbContext.Allergies.AddRange(allergies);
            _dbContext.SaveChanges();
        }

        [Fact]
        public async Task GetAllergies_ReturnsAllAllergies()
        {
            // Arrange
            var controller = new AllergyController(_dbContext);

            // Act
            var result = await controller.GetAllergys();

            // Assert
            var allergies = Assert.IsAssignableFrom<IEnumerable<Allergy>>(result.Value);
            Assert.Equal(3, allergies.Count());
        }

        [Fact]
        public async Task GetAllergy_WithValidId_ReturnsAllergy()
        {
            // Arrange
            var controller = new AllergyController(_dbContext);
            var id = 1;

            // Act
            var result = await controller.GetAllergy(id);

            // Assert
            var allergy = Assert.IsType<Allergy>(result.Value);
            Assert.Equal(id, allergy.AllergyId);
        }

        [Fact]
        public async Task GetAllergy_WithInvalidId_ReturnsNotFound()
        {
            // Arrange
            var controller = new AllergyController(_dbContext);
            var id = 4;

            // Act
            var result = await controller.GetAllergy(id);

            // Assert
            Assert.IsType<NotFoundResult>(result.Result);
        }

        [Fact]
        public async Task PostAllergy_WithValidAllergy_AddsAllergyToDatabase()
        {
            // Arrange
            var controller = new AllergyController(_dbContext);
            var newAllergy = new Allergy { AllergyId = 4, AllergyName = "Shellfish", UserId = 2 };

            // Act
            var result = await controller.PostAllergy(newAllergy);

            // Assert
            Assert.IsType<OkObjectResult>(result.Result);
            Assert.Equal(4, _dbContext.Allergies.Count());
        }

        [Fact]
        public async Task PutAllergy_WithValidId_UpdatesAllergy()
        {
            // Arrange
            var controller = new AllergyController(_dbContext);
            var id = 1;
            var updatedAllergy = new Allergy { AllergyId = 1, AllergyName = "Tree nuts", UserId = 1 };

            // Act
            var result = await controller.PutAllergy(id, updatedAllergy);
        }
    }
}