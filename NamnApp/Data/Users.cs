using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Users
    {
        // I vanliga fall när jag skapar en instans av en datatyp så skulle jag skrivit nåt i stil med:
        // public int MyInt {get;set;}
        // och sen skapat en constructor. Det verkar inte fungera här nedan?!? Gör man inte så när man skapar en lista kanske?
        public List<UserRepository> userList = new List<UserRepository>();

        // Är det här rätt ställe att skapa ett DA-objekt? Skulle kunna skapa det i Program också, men vill ju separera UI:n
        // från klassen där jag skriver data till min textfil.
        public DA daobj = new DA();

        public void AddUser(UserRepository user)
        {
            userList.Add(user);
        }

        // Här vill jag skapa kommaseparerad output med hjälp av metoden UserOutput() som finns i DA-klassen. Dock verkar det
        // inte fungera. Får röda "vågor" nedan.
        daobj.UserOutput(userList);


        // test för att se att allt lagras rätt i userList
        public void PrintUserlist()
        {
            foreach (var user in userList)
            {
                Console.WriteLine(user.FirstName);
                Console.WriteLine(user.LastName);
            }
        }
    }
}
