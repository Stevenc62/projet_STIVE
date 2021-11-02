using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetSTIVE.Models
{
    public class ProductCategory
    {
        private int categoryId;
        private string name;
        private string description;
        private static List<ProductCategory> categories = new List<ProductCategory>();
        private static string request;
        private static MySqlConnection connection;
        private static MySqlCommand command;
        private static MySqlDataReader reader;

        public int Category_id { get => categoryId; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
    }
}
