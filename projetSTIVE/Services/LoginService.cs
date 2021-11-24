using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetSTIVE.Services
{
    public class LoginService : ILogin

    {
        private IHttpContextAccessor _httpContext;
        public LoginService(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
        }

        public void SaveAccessToSession(string email, string password)
        {
            _httpContext.HttpContext.Session.SetString("email", email);
            _httpContext.HttpContext.Session.SetString("password", password);
        }

        public bool IsLogin()
        {
            return _httpContext.HttpContext.Session.GetString("email") != null && _httpContext.HttpContext.Session.GetString("password") != null;
        }
        public string getMailFromSession()
        {
            return _httpContext.HttpContext.Session.GetString("email");
        }
    }
}
