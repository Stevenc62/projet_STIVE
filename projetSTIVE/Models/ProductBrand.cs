using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetSTIVE.Models
{
    public class ProductBrand
    {
        private int brandId;
        private string name;
        private string description;
        private static List<ProductBrand> brands = new List<ProductBrand>();
        private static string request;
        private static MySqlConnection connection;
        private static MySqlCommand command;
        private static MySqlDataReader reader;

        public int BrandId { get => brandId; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
    }
}
