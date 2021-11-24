using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetSTIVE.Services
{
    interface ILogin
    {
        void SaveAccessToSession(string email, string password);
        bool IsLogin();
        string getMailFromSession();
    }
}
