using Bank_application.Entities;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Bank_application
{
    internal class Program
    {
        static void Main(string[] args)
        {  // Email
            Console.WriteLine("Emailinizi qeyd edin");
        mail:
            string email = Console.ReadLine();
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match matchE = regex.Match(email);
            if (matchE.Success)
            { 
            }
            else
            {
                Console.WriteLine("Zehmet olmasa duzgun email qeyd edin");
                goto mail;
            }


            //Password
            Console.WriteLine("Zehmet olmasa sifrenizi daxin edin:");
            password:
            string passsword = Console.ReadLine();
            Regex psswrd = new Regex("^(?=.*?[A-Z])(?=.*?[a-z]).{8,}$");
            Match matchP = psswrd.Match(passsword);

                if (passsword.Length >= 8 && matchP.Success)
                {
                Console.WriteLine("Email: " + email.Trim());
                    Console.WriteLine("Sifre: " + passsword.Trim());
                }
                else
                {
                    Console.WriteLine("Zehmet olmasa duzgun sifre qeyd edin.");
                    goto password;
                }
        }
        
    }
}