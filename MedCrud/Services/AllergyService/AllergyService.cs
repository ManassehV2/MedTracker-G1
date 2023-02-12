using MedAdvisor.Models;
using Microsoft.EntityFrameworkCore;
using MedAdvisor.DataAccess.MySql;

namespace MedAdvisor.Services.Okta.AllergyService
{
    public class AllergyService : IAllergyService
    {
        private readonly MedAdvisorDbContext _context = null;
        public AllergyService(MedAdvisorDbContext context)
        {
            _context = context; 
        }
        public async Task<List<Allergy>> AddAllergy(Allergy allergy)
        {
            _context.Allergies.Add(allergy);
            await _context.SaveChangesAsync();

            return await _context.Allergies.ToListAsync();
        }

        public async Task<List<Allergy>> DeleteAllergy(int id)
        {
            var allergy = await _context.Allergies.FindAsync(id);
            if (allergy == null) {
                return null;
            }
            _context.Allergies.Remove(allergy);
            await _context.SaveChangesAsync();
            return await _context.Allergies.ToListAsync();

        }

        public async Task<List<Allergy>> GetAllAllergies()
        {
            var allergies = await _context.Allergies.ToListAsync();
            return allergies;
        }

        public async Task<Allergy> GetSingleAllergy(int id)
        {
            var allergy = await _context.Allergies.FindAsync(id);
            if (allergy == null)
            {
                return null;
            }
            return allergy;
        }

        public async Task<List<Allergy>> UpdateAllergy(int id, Allergy request)
        {
            var allergy = await _context.Allergies.FindAsync(id);
            if (allergy is null)
            {
                return null;
            }
            allergy.UserId = request.UserId;
            allergy.AllergyId=request.AllergyId;
            allergy.AllergyName = request.AllergyName;

            await _context.SaveChangesAsync();
            return await _context.Allergies.ToListAsync();
        }
    }
}
