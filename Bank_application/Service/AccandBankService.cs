using Bank_application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bank_application.Service
{
    internal class AccandBankService : AccountService
    {  
        User[] _user;
        public User[] users => _user;

        public AccandBankService()
        {
            _user = new User[0];
        }

        public void CreateUser(string name, string surname, string email, string password, bool isAdmin)
        {
            User user = new User(name, surname, email, password,isAdmin);
        }



        public void Registration()
        {
                 
        }
    }
}
