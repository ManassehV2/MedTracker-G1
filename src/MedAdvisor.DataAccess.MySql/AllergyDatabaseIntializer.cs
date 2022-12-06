using System.Collections.Generic;
using System.Data.Entity;

namespace MedAdvisor.DataAccess.Mysql
{
    public class AllergyDatabaseInitializer : DropCreateDatabaseIfModelChanges<MedTrackerContext>
    {
        protected override void Seed(MedTrackerContext context)
        {
            GetAllergy().ForEach(a => context.Allergy.Add(a));
        }

        private static List<Allergy> GetAllergy(()
        {
            var allergies = new List<Allergy> {
                new Allergy
                {
                    AllergyId = 1,
                    AllergyName = "Dextrose"
                },
                 new Allergy
                {
                    AllergyId = 2,
                    AllergyName = "Finch Feathers"
                },
            };

            return allergies;
        }
    }
}