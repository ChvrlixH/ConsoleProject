using Bank_application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_application.utilities
{
    internal interface Ibankservice
    {
        User UserLogin();
        User FindUser();
        void UserRegistration();
    }
}
