using Bank_application.Entities;
using Bank_application.utilities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bank_application.Service
{
    internal class Userservice : Iuserservice

    {
        public void BankUserList()
        {
            foreach  (User user in Bank.Users)
            {
                Console.WriteLine(user);
            }
        }

        public void BlockUser()
        {
        block:
            Console.WriteLine("Zehmet olmasa emaili daxil edin");
            string email = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(email))
            {
                Console.WriteLine("Zehmet olmasa duzgun daxil edin");
                goto block;
            }
            foreach (User user in Bank.Users)
            {
                if (user.Email == email)
                {
                    user.IsBlocked = true;
                    return;
                }
            }
            Console.WriteLine("Bu emailde istifadeci tapilmadi");
        }

        public void ChangePassword()
        {
            newPassword:
            Console.WriteLine("Zehmet olmasa yeni sifreni daxil edin:");
            string newPassword = Console.ReadLine();
            Regex newPsswrd = new Regex("^(?=.*?[A-Z])(?=.*?[a-z]).{8,}$");
            Match matchP = newPsswrd.Match(newPassword);

            if (MenuService.currentUser.Password == newPassword)
            {
                Console.WriteLine("Sifreniz evvelki sifreniz ile eynidir. Emeliyyat ugursuz oldu");
                goto newPassword;
            }
            else if(newPassword == null)
            {
                Console.WriteLine("Duzgun sifre daxil edin");
                goto newPassword;
            }
            else if (newPassword.Length >= 8 && matchP.Success)
            {
                MenuService.currentUser.Password = newPassword;
                Console.WriteLine("Yeni sifre: " + newPassword.Trim());
                return;
            }
        }

        public double CheckBalance(User user)
        {
            return MenuService.currentUser.Balance;
        }

        public void LogOut(User user)
        {
            logout:
            string end = Console.ReadLine();
            bool logout = false;
            if (end == "0")
            {
                logout = true;
                Console.Clear();
            }
            else
            {
                logout = false;
                Console.WriteLine("Duzgun daxil edin:");
                goto logout;
            }
            return;
        }

        public void TopUpBalance()
        {
            topUp:
            Console.WriteLine("Elave edeceyiniz mebleg: ");
            bool result = int.TryParse(Console.ReadLine(), out int amount);
            if (result)
            {
                if (amount>0)
                {
                    MenuService.currentUser.Balance += amount;
                    return;
                }
                else
                {
                    Console.WriteLine("Duzgun deyer daxil edin");
                    goto topUp;
                }
            }
            else
            {
                Console.WriteLine("Zehmet olmasa reqemlerden istifade edin");
                goto topUp;
            }
        }
    }
}
