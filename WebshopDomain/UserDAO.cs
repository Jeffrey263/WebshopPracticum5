using PasswordGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopDomain
{
    //Deze klasse regelt alle CRUD statements rondom de klasse user.
    public class UserDAO
    {        
        //Haal alle users op
        public List<User> GetAllUsers()
        {
            using (Model1Container db = new Model1Container())
            {
                List<User> users = db.UserSet.ToList();
                return users;
            }
        }

        //Haal user op met specifiek ID
        public User GetUserById(Int32 id)
        {
            using (Model1Container db = new Model1Container())
            {
                User u = db.UserSet.Find(id);
                return u;
            }
        }

        //Haal user op met specifieke username
        public User GetUserByName(string username)
        {
            using (Model1Container db = new Model1Container())
            {
                User foundUser = db.UserSet.FirstOrDefault(u => u.name == username);
                return foundUser;
            }
        }

        //Sla een nieuwe user up
        public String SaveNewUser(string n)
        {
            //Check of de gebruikersnaam nog niet in gebruik is
            using (Model1Container db = new Model1Container())
            {
                User foundUser = db.UserSet.FirstOrDefault(u => u.name == n);
                bool occupied = false;
                if (foundUser != null)
                    occupied = true;

                //Als de gebruikersnaam niet in gebruk is maak een nieuwe gebruiker aan.
                if (!occupied)
                {
                    User u = new User
                    {
                        name = n,
                        balance = 200
                    };

                    //Voor het aanmaken van wachtwoorden heb ik de .NET standaard library gebruikt: github[https://github.com/prjseal/PasswordGenerator/] nuGet[https://www.nuget.org/packages/PasswordGenerator/]
                    var pwd = new Password(8);
                    var password = pwd.Next();
                    u.password = password;
                    db.UserSet.Add(u);
                    db.SaveChanges();

                    return $"U heeft succesvol een account aangemaakt. Dit is uw wachtwoord: {password}, Onthoud deze goed!";
                }
                //Geef de melding dat het gebruikersnaam al in gebruik is.
                else
                {
                    return $"Het gebruikersnaam \"{n}\" is al ingebruik, kies een andere naam aub.";
                }
            }
            
        }

        //Deze functie checkt of de gebruiker in het systeem staat.
        public bool CheckUserAuthentication(string username, string password)
        {
            //Check of username/password leeg zijn
            if (username == null || password == null)
                return false;

            //Check of username en password kloppen.
            using (Model1Container db = new Model1Container())
            {               
                User foundUser = db.UserSet.FirstOrDefault(u => u.name == username);

                if(foundUser == null)
                {
                    Console.WriteLine("[DAO] - user not found");
                    return false;
                }

                if (foundUser.password.Equals(password))
                    return true;
                else return false;
            }
        }
    }
}
