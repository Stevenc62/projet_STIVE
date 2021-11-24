using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetSTIVE.Models
{
    public class WebUser
    {
        private int userId;
        private string email;
        private string phone;
        private string password;
        private string firstname;
        private string lastname;
        private Role role;

        public int UserId { get => userId; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Password { get => password; set => password = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public Role Role { get => role; set => role = value; }
    }
}
