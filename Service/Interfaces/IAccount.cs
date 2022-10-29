using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    public interface IAccount
    {
        string Login(string email, string password, int roleId);
        bool CheckRole(int roleId);

    }
}
