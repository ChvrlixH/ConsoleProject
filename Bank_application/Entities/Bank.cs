using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Bank_application.Entities
{
    internal class Bank
    {
        public int Id;
        public static User[] Users;
        static Bank()
        {
             Users = new User[0];
        }
    }
  
}
