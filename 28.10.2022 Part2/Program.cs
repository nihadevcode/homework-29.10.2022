using Service.Models;
using System;

namespace _28._10._2022_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your email:");
            string email = Console.ReadLine();

            Console.WriteLine("Please enter your password:");
            string password = Console.ReadLine();

            Console.WriteLine("Please enter your private number:");
            int roleId = int.Parse(Console.ReadLine());

            Account acc1 = new Account();
            Console.WriteLine(acc1.Login(email, password, roleId));
        }
    }
}
