using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class UserRepository
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public UserRepository(string firstname, string lastname)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
        }

        public void PrintNames()
        {
            Console.WriteLine($"Firstname: {FirstName}");
            Console.WriteLine($"Lastname: {LastName}");
        }

        // Tanken här är att skapa kommaseparerad output som ska skrivas till en textfil
        public string UserOutput()
        {
            string UserComma = $"{FirstName},{LastName}";
            return UserComma;
        }
    }
}
