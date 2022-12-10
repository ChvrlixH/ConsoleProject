using Bank_application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_application.Service
{
    internal interface AccountService
    {
        User[] users { get; }
        void CreateUser(string name, string surname, string email, string password, bool isAdmin);
        void Registration();

    }
}
