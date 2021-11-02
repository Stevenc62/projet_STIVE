using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetSTIVE.Models
{
    public class Supplier
    {
        private int supplierId;
        private string name;
        private string address;
        private int zipcode;
        private string city;
        private string email;
        private static List<Supplier> Suppliers = new List<Supplier>();
        private static string request;
        private static MySqlConnection connection;
        private static MySqlCommand command;
        private static MySqlDataReader reader;

        public int Supplier_id { get => supplierId; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public int Zipcode { get => zipcode; set => zipcode = value; }
        public string City { get => city; set => city = value; }
        public string Email { get => email; set => email = value; }

        public Supplier()
        {

        }


    }
}
