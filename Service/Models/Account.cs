using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using static Service.Enums.Enums;

namespace Service.Models
{
    public class Account : IAccount
    {
        public string Login(string email, string password, int roleId)
        {
            if (email =="test@code.edu.az" && password == "test12345")

            {
                if (CheckRole(roleId))
                {
                    return "Login Successful";
                }
                else
                {
                    return "You don't have a permission for login";
                }
            }
            else
            {
                return "Email or Password is incorrect";
            }
        }

        public bool CheckRole(int roleId)
        {
            if (roleId == 999)
            {
                return true;
            }
                return false;
        }
    }
}
