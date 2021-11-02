using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetSTIVE.Models
{
    public class CustomerAddress
    {
        private int addressId;
        private string city;
        private string address;
        private int zipcode;
        private string firstname;
        private string lastname;
        private WebUser User;

        public int AddressId { get => addressId; }
        public string City { get => city; set => city = value; }
        public string Address { get => address; set => address = value; }
        public int Zipcode { get => zipcode; set => zipcode = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public WebUser User1 { get => User; set => User = value; }
    }
}
