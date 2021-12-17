using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projetSTIVE.Tools;

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
        private static string request;
        private static MySqlConnection connection;
        private static MySqlCommand command;
        private static MySqlDataReader  reader;

        public int Supplier_id { get => supplierId; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public int Zipcode { get => zipcode; set => zipcode = value; }
        public string City { get => city; set => city = value; }
        public string Email { get => email; set => email = value; }

        public bool Save()
        {
            request = "INSERT INTO supplier (name, address, zipcode, city, email) values (@name, @address, @zipcode, @city, @email);";
            connection = Db.Connection;
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("@name", Name));
            command.Parameters.Add(new MySqlParameter("@address", Address));
            command.Parameters.Add(new MySqlParameter("@zipcode", Zipcode));
            command.Parameters.Add(new MySqlParameter("@city", City));
            command.Parameters.Add(new MySqlParameter("@Email", Email));
            connection.Open();
            int nbRow = command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            return nbRow == 1;
        }


    }
}
