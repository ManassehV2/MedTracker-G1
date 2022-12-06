using System.Collections.Generic;
using System.Data.Entity;

namespace MedAdvisor.DataAccess.Mysql
{
    public class MedicineDatabaseInitializer : DropCreateDatabaseIfModelChanges<MedTrackerContext>
    {
        protected override void Seed(MedTrackerContext context)
        {
            GetMedicine().ForEach(m => context.Medicine.Add(m));
        }

        private static List<Medicine> GetMedicine(()
        {
            var medicines = new List<Medicine> {
                new Medicine
                {
                    MedicineId = 1,
                    MedicineName = "Dextrose"
                },
                 new Medicine
                {
                    MedicineId = 2,
                    MedicineName = "Finch Feathers"
                },
            };

            return medicines;
        }
    }
}