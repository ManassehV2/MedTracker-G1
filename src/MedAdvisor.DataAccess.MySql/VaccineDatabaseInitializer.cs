using System.Collections.Generic;
using System.Data.Entity;

namespace MedAdvisor.DataAccess.Mysql
{
    public class VaccineDatabaseInitializer : DropCreateDatabaseIfModelChanges<MedTrackerContext>
    {
        protected override void Seed(MedTrackerContext context)
        {
            GetVaccine().ForEach(v => context.Vaccine.Add(v));
        }

        private static List<Vaccine> GetVaccine(()
        {
            var vaccines = new List<Vaccine> {
                new Vaccine
                {
                    VaccineId = 1,
                    VaccineName = "Dextrose"
                },
                 new Vaccine
                {
                    VaccineId = 2,
                    VaccineName = "Finch Feathers"
                },
            };

            return vaccines;
        }
    }
}