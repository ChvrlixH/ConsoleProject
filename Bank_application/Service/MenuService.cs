using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bank_application.Service
{
    internal static class MenuService
    {
        static AccandBankService accountService = new AccandBankService();
        public static void Registration()
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
                Console.WriteLine($"Id: {id} Ad: {name.Trim()}  Soyad: {surname.Trim()}");

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
                Console.WriteLine("Email: " + email.Trim());
                Console.WriteLine("Sifre: " + password.Trim());
            }
            else
            {
                Console.WriteLine("Zehmet olmasa duzgun sifre daxil edin.");
                goto password;
            }

            bool isadmin;
            Console.WriteLine("Adminsiniz?   Y(Yes)/N(No)" );
            if ('Y' == Console.ReadLine().ToUpper)
            {
                isadmin = true;
            }
            else if ('N' == Console.ReadLine().ToUpper)
            {
                isadmin = false;
            }
            else if (Console.ReadLine() == null)
            {
                isadmin = false;
            }
            else
            {
                isadmin = false;
            }
            
            accountService.CreateUser(name, surname, email, password,isAdmin); //isadminde problem var
        }
    }
}
