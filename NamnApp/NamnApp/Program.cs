﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace NamnApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Firstname: ");
            string first = Console.ReadLine();
            Console.WriteLine("Lastname: ");
            string last = Console.ReadLine();


            UserRepository user = new UserRepository(first, last);
            //userList.Add(user);

            // Test
            //foreach (var u in userList)
            //{
            //    Console.WriteLine($"Firstname: {u.FirstName}");
            //    Console.WriteLine($"Lastname: {u.LastName}");
            //}

        }
    }
}
