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
        int _id;
        static Random random;
        public static bool IsLogged;

        public User(string name, string surname, string email, string password, bool isAdmin)
        {
            Name = name;
            _id = random.Next(10000,50000);
            Surname = surname;
            Balance = 0;
            Email = email;
            Password = password;
            IsAdmin = isAdmin;
            IsBlocked = false;
            Array.Resize(ref Bank.Users, Bank.Users.Length + 1);
            Bank.Users[Bank.Users.Length - 1] = this;
        }
        static User()
        {
            IsLogged = false;
            random = new Random();
        }
        public override string ToString()
        {
            return $"Ad: {Name} Soyad: {Surname} Email: {Email}";
        }
    }
}
