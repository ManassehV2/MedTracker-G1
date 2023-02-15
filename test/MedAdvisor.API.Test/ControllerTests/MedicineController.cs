/**using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using System.Collections.Generic;
using MedAdvisor.DataAccess.MySql;
using MedAdvisor.Models;
using MedAdvisor.Api.Controllers;

namespace MedAdvisor.API.Test.ControllerTests
{
    public class MedicineControllerTests
    {
        [Fact]
        public void AnimalController_ListsAnimalsFromDatabase()
        {
            DbContextOptionsBuilder<MedAdvisorDbContext> optionsBuilder = new();
            optionsBuilder.UseInMemoryDatabase(MethodBase.GetCurrentMethod().Name);

            using (MedAdvisorDbContext ctx = new(optionsBuilder.Options))
            {
                ctx.Add(new Allergy { AllergyId = 1, AllergyName = "Allergy1" });
                ctx.SaveChanges();
            }

            IActionResult result;
            using (MedAdvisorDbContext ctx = new(optionsBuilder.Options))
            {
                result = new AllergyController(ctx).List();
            }

            var okResult = Assert.IsType<OkObjectResult>(result);
            var allergies = Assert.IsType<List<Allergy>>(okResult.Value);
            var allergy = Assert.Single(allergies);
            Assert.NotNull(allergy);
            Assert.Equal(1, allergy.AllergyId);
            Assert.Equal("Allergy1", allergy.AllergyName);

        }

        [Fact]
        public void AnimalController_GetsAnimalFromDatabase()
        {
            DbContextOptionsBuilder<MedAdvisorDbContext> optionsBuilder = new();
            optionsBuilder.UseInMemoryDatabase(MethodBase.GetCurrentMethod().Name);

            using (MedAdvisorDbContext ctx = new(optionsBuilder.Options))
            {
                ctx.Add(new Allergy { AllergyId = 1, AllergyName = "Allergy1" });
                ctx.SaveChanges();
            }

            IActionResult result;
            using (MedAdvisorDbContext ctx = new(optionsBuilder.Options))
            {
                result = (IActionResult)new AllergyController(ctx).GetAllergy(1);
            }

            var okResult = Assert.IsType<OkObjectResult>(result);
            var allergy = Assert.IsType<Allergy>(okResult.Value);
            Assert.NotNull(allergy);
            Assert.Equal(1, allergy.AllergyId);
            Assert.Equal("Allergy1", allergy.AllergyName);

        }
    }
}*/