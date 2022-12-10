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

        public User(double balance, string email, string password)
        {
            Balance = balance;
            Email = email;
            Password = password;
            FullName(" ", " ", ' ');
        }
        public void FullName(string name, string surname, int id)
        {
            Name = name;
            Surname = surname;
            Id = id;
        fullname:
            Console.WriteLine("Zehmet olmasa adinizi qeyd edin:");
            name = Console.ReadLine();
            Console.WriteLine("Zehmet olmasa soyadinizi qeyd edin:");
            surname = Console.ReadLine();

            if (name.Length >= 3 && surname.Length >= 3)
            {
                Random ID = new Random();
                Console.WriteLine($"Id: {ID.Next(10000, 50000)} Ad: {name.Trim()}  Soyad: {surname.Trim()}");

            }
            else
            {
                Console.WriteLine("Zehmet olmasa duzgun deyer daxil edin.");
                goto fullname;
            }
        }
    }
}
