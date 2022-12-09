
namespace MedAdvisor.DataAccess.Mysql
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string JoinedDate { get; set; }
        public enum Gender
        {
            Female, Male
        }
        public string BirthDate { get; set; }
        public bool OrganDonor { get; set; }
        public int SocialSecurityNumber { get; set; }
        public string Nationality { get; set; }
        public int Telephone { get; set; }
        public string PostalAddress { get; set; }
        public string TravelInsurance { get; set; }
        public int PostalNumber { get; set; }
        public string AlarmTelephone { get; set; }
        public int EmergencyContacts { get; set; }
        public string Other { get; set; }



    }
}