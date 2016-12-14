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

        List<UserRepository> userList = new List<UserRepository>();

        List<String> output = new List<string>();

        public void AddUser(UserRepository user)
        {
            userList.Add(user);
        }

        // test ----------------------- Hur få detta att fungera? Var anropa ifrån?
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
