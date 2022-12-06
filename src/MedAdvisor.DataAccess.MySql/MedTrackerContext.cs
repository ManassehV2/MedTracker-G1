using System.Data.Entity;
namespace MedAdvisor.DataAccess.Mysql
{
    public class MedTrackerContext : DbContext
    {
        public MedTrackerContext() : base("MedAdvisor.DataAccess.Mysql")
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Allergy> Allergies { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Vaccine> Vaccines { get; set; }
        public DbSet<Diagnose> Diagnoses { get; set; }
        public DbSet<Document> Documents { get; set; }  
    }
}