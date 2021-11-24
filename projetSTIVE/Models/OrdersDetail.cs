using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetSTIVE.Models
{
    public class OrdersDetail
    {
        private Product product;
        private Orders order;
        private decimal price;
        private int quantity;

        public Product Product { get => product; }
        public Orders Order { get => order; set => order = value; }
        public decimal Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
