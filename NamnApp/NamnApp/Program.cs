using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace NamnApp
{
    class Program //OBS!!!!!!!! Detta är fel branch!!!!!!!!!!!!!!!! Se den som heter Test1!
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Firstname: ");
            string first = Console.ReadLine();
            Console.WriteLine("Lastname: ");
            string last = Console.ReadLine();

            UserRepository user = new UserRepository(first, last);
        }
    }
}
