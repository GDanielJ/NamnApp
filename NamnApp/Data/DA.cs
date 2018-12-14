using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Data
{
    public class DA
    {
        string filePath = @"C:\Demo\Test.txt";

        List<String> output = new List<string>();

        // Tanken här är att skapa kommaseparerad output som ska skrivas till en textfil
        public void UserOutput(List<UserRepository> uList)
        {
            foreach (UserRepository u in uList)
            {
                string UserComma = $"{u.FirstName},{u.LastName}";
                output.Add(UserComma);
                //Console.WriteLine($"UserOutput Metod: {UserComma}"); //Test
            }
        }
    }
}
