using Bank_application.Entities;
using Bank_application.Service;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Bank_application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankService bank = new BankService();
            Userservice userService = new Userservice();
            int selection;
            do
            {
            start:
                Console.WriteLine("1. Registration");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Istifadecini axtar");
                Console.WriteLine("0. Cixis");
                bool result = int.TryParse(Console.ReadLine(), out selection);
                if (result)
                {
                    switch (selection)
                    {
                        case 1:
                            bank.UserRegistration();
                            break;
                        case 2:
                            bank.UserLogin();
                            break;
                        case 3:
                            bank.FindUser();
                        case 0:
                            break;
                        default:
                            Console.Clear();
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    goto start;
                }
            } while (selection != 0 && User.IsLogged == false);
           
            int selection2;
            do
            {
                if (MenuService.currentUser.IsAdmin==true)
            {

            } else
            {

            }
            start:
                Console.WriteLine("1. Balansivi goster");
                Console.WriteLine("2. Balansivi artir");
                Console.WriteLine("3. Sifreni deyis");
                Console.WriteLine("4. Bankdaki butun istifadeciler");
                Console.WriteLine("5. Bankdaki blok olunan istifadeciler");
                Console.WriteLine("0. Cixis");
                bool result2 = int.TryParse(Console.ReadLine(), out selection2);
                if (result)
                {
                    switch (selection2)
                    {
                        case 1:
                            userService.CheckBalance();
                            break;
                        case 2:
                            userService.TopUpBalance();
                            break;
                        case 3:
                            userService.ChangePassword();
                            Console.WriteLine(MenuService.currentUser.Password);
                            break;
                        case 4:
                            userService.BankUserList();
                            break;
                        case 5:
                            userService.BlockUser();
                            break;
                        case 0:
                            break;
                        default:
                            Console.Clear();
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    goto start;
                } while (selection2 != 0 && User.IsLogged == false) ;
            }
        
    }
}