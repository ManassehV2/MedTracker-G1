using Microsoft.AspNetCore.Http;

using MedAdvisor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using MedAdvisor.Services.Okta.AllergyService;

namespace MedAdvisor.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllergyController : ControllerBase
    {
        private readonly IAllergyService _allergyService;
        public AllergyController(IAllergyService allergyService)
        {
            _allergyService = allergyService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Allergy>>> GetAllAllergies()
        {

            return _allergyService.GetAllAllergies();
        }
        [HttpGet("{id}")]

        public async Task<ActionResult<Allergy>> GetSingleAllergy(int id)
        {
            return _allergyService.GetSingleAllergy(id);
      
        }
        [HttpPost]
        public async Task<ActionResult<List<Allergy>>> AddAllergy([FromBody]Allergy allergy)
        {
            var result = _allergyService.AddAllergy(allergy) ;
           
            return Ok(result);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<List<Allergy>>> UpdateAllergy(int id, Allergy request)
        {
          var result = _allergyService.UpdateAllergy(id, request) ;
       if(result is null)
            {
                return NotFound("Allergy not Found");
            }
       return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Allergy>>> DeleteAllergy(int id, Allergy request)
        {
            var result =_allergyService.DeleteAllergy(id);
            if (result is null) { return NotFound("Allergy Not Found "); }

            return Ok(result);
            
        }


    }
}
