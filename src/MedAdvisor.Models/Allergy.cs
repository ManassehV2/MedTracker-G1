using System.Data.Entity;
namespace MedAdvisor.DataAccess.Mysql
{
    public class Allergy
    {
        public int UserId { get; set; }
        public int AllergyId { get; set; }
        public string AllergyName { get; set; }
    }
}