using Bank_application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_application.utilities
{
    internal interface Iuserservice
    {
        double CheckBalance(User user);
        void TopUpBalance();
        
        void ChangePassword();
        
        void BankUserList();
        void BlockUser();
        void LogOut(User user);

    }
}
