using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_application.Entities
{
    internal class User
    {
        public int Id;
        public string Name;
        public string Surname;
        public double Balance;
        public string Email;
        public string Password;
        public bool IsAdmin;     
        public bool IsBlocked;
        public bool IsLogged;

        public User(string name, string surname, string email, string password, bool isAdmin)
        {
            Name = name;
            Surname = surname;
            Balance = 0;
            Email = email;
            Password = password;
            IsAdmin = isAdmin;
            IsBlocked = false;
            IsLogged = false;
        }
     
    }
}
