using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using static Service.Enums.Enums;

namespace Service.Models
{
    public class Account : IAccount
    {
        public static void Login()
        {
            Console.WriteLine("Please enter your email:");
            string Email = Console.ReadLine();
            Console.WriteLine("Please enter your password:");
            string Password = Console.ReadLine();

            if (Email =="test@code.edu.az" && Password == "test12345")

            {
                Console.WriteLine("Login Successful");
            }
            else
            {
                Console.WriteLine("Email or Password is incorrect");
            }
        }

        public static void CheckRole(int roleId)
        {
            Console.WriteLine("Please enter your role:");
            roleId = int.Parse(Console.ReadLine());

            if (roleId == (int)Roles.SuperAdmin)
            {
                Console.WriteLine("Login Successful");
            }
            else
            {
                Console.WriteLine("Role is incorrect");
            }
        }
    }
}
