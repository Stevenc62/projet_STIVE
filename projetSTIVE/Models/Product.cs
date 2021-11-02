using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetSTIVE.Models
{
    public class Product
    {
        private int productId;
        private string name;
        private string description;
        private decimal price;
        private string image;
        private DateTime creationDate;
        private int quantity;
        private Supplier supplier;
        private ProductCategory category;
        private ProductBrand brand;

        public int ProductId { get => productId; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public decimal Price { get => price; set => price = value; }
        public string Image { get => image; set => image = value; }
        public DateTime CreationDate { get => creationDate; set => creationDate = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public Supplier Supplier { get => supplier; set => supplier = value; }
        public ProductCategory Category { get => category; set => category = value; }
        public ProductBrand Brand { get => brand; set => brand = value; }
    }
}
