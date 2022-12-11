using Bank_application.Entities;
using Bank_application.utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bank_application.Service
{
    internal class BankService : Ibankservice

    {
        public BankService()
        {
            User _user;
        }
        public  void UserRegistration()
        {
        fullname:
            Console.WriteLine("Zehmet olmasa adinizi qeyd edin:");
            string name = Console.ReadLine();
            Console.WriteLine("Zehmet olmasa soyadinizi qeyd edin:");
            string surname = Console.ReadLine();
            int id;
            if (name.Length >= 3 && surname.Length >= 3)
            {
                Random ID = new Random();
                id = ID.Next(10000, 50000);

            }
            else
            {
                Console.WriteLine("Zehmet olmasa duzgun deyer daxil edin.");
                goto fullname;
            }
        //Email
        mail:
            Console.WriteLine("Emailinizi daxil edin");
            string email = Console.ReadLine();
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match matchE = regex.Match(email);
            if (matchE.Success)
            {
            }
            else
            {
                Console.WriteLine("Zehmet olmasa duzgun email daxil edin");
                goto mail;
            }


            //Password
            Console.WriteLine("Zehmet olmasa sifrenizi daxil edin:");
        password:
            string password = Console.ReadLine();
            Regex psswrd = new Regex("^(?=.*?[A-Z])(?=.*?[a-z]).{8,}$");
            Match matchP = psswrd.Match(password);

            if (password.Length >= 8 && matchP.Success)
            {
                
            }
            else
            {
                Console.WriteLine("Zehmet olmasa duzgun sifre daxil edin.");
                goto password;
            }

            bool isadmin;
        isadmin:
            Console.WriteLine("Adminsiniz?   Y(Yes)/N(No)");
            string result = Console.ReadLine().ToUpper();
            switch (result)
            {
                case "Y":
                    isadmin = true;
                    break;
                case "N":
                    isadmin = false;
                    break;
                default:
                    Console.WriteLine("Zehmet olmasa ekranda gosterilen simvollardan birini daxil edin");
                    goto isadmin;
            }

            User user = new User(name, surname, email, password, isadmin); //isadminde problem var
            Console.WriteLine("Istifadeci ugurla elave olundu");
            Console.WriteLine($"Id: {id} Ad: {name.Trim()}  Soyad: {surname.Trim()} Email {email.Trim()}");

        }

        public User FindUser()
        {
            Console.WriteLine("Email daxil et");
            string email = Console.ReadLine();
            foreach (User user in Bank.Users)
            {
                if (user.Email == email)
                {
                    Console.WriteLine(user);
                    return user;
                }
            }
            return null;
        }

        public User UserLogin()
        {
            Console.WriteLine("Emailinizi daxil edin:");
            string mail = Console.ReadLine();
            Console.WriteLine("Sifrenizi daxil edin:");
            string psswrd = Console.ReadLine();
            foreach (User user in Bank.Users)
            { 
                if (user.Email == mail && user.Password == psswrd)
                {
                    if (user.IsBlocked==true)
                    {
                        Console.WriteLine("Siz blokdasiz");
                    } else
                    {
                    User.IsLogged = true;
                    Console.WriteLine("Ugurlu");
                    MenuService.currentUser = user;
                    return user;

                    }
                }
            }
            User.IsLogged = false;
            Console.WriteLine("Ugursuz");
            return null;
        }

    }

}

