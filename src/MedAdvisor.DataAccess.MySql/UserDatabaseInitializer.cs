using System.Collections.Generic;
using System.Data.Entity;

namespace MedAdvisor.DataAccess.Mysql
{
    public class UserDatabaseInitializer : DropCreateDatabaseIfModelChanges<MedTrackerContext>
    {
        protected override void Seed(MedTrackerContext context)
        {
            GetUser().ForEach(u => context.User.Add(u));
        }

        private static List<User> GetUser(()
        {
            var users = new List<User> {
                new User
                {
                    UserId = 1,
                    FirstName = "apphuset",
                    SecondName = "runar",
                    Email = "apphusetrunar@gmail.com",
                    JoinedDate = "12-12-2001",
                    BirthDate ="12-12-2020",
                    OrganDonor = true,
                    Gender = "Female",
                    SocialSecurityNumber = 11111,
                    Nationality = "Ethiopian",
                    Telephone = "0988473746",
                    PostalAddress = "Addis Ababa",
                    TravelInsurance = "",
                    PolicyNumber = "",
                    AlarmTelephone = "",
                    EmergencyContacts = "09098758445"
                }
            };

            return users;
        }
    }
}