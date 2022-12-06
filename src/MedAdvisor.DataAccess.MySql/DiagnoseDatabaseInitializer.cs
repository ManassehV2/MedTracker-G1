using System.Collections.Generic;
using System.Data.Entity;

namespace MedAdvisor.DataAccess.Mysql
{
    public class DiagnoseDatabaseInitializer : DropCreateDatabaseIfModelChanges<MedTrackerContext>
    {
        protected override void Seed(MedTrackerContext context)
        {
            GetDiagnose().ForEach(d => context.Diagnose.Add(d));
        }

        private static List<Diagnose> GetDiagnose(()
        {
            var diagnoses = new List<Diagnose> {
                new Diagnose
                {
                    DiagnoseId = 1,
                    DiagnoseName = "Dextrose"
                },
                 new Diagnose
                {
                    DiagnoseId = 2,
                    DiagnoseName = "Finch Feathers"
                },
            };

            return diagnoses;
        }
    }
}