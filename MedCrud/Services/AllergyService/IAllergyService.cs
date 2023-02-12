using System;
using MedAdvisor.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MedAdvisor.Services.Okta.AllergyService
{
 public  interface IAllergyService
    {
        Task<List<Allergy>?> GetAllAllergies();
        Task<Allergy?> GetSingleAllergy(int id);
        Task<List<Allergy>> AddAllergy(Allergy allergy);
        Task<List<Allergy>?> UpdateAllergy(int id , Allergy request);
        Task<List<Allergy>?>  DeleteAllergy(int id);
    
    }


}

