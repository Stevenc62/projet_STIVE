using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetSTIVE.Models
{
    public class Discount
    {
        private int discountId;
        private string name;
        private decimal discountPercent;
        private bool active;
        private Product product;

        public int DiscountId { get => discountId; }
        public string Name { get => name; set => name = value; }
        public decimal DiscountPercent { get => discountPercent; set => discountPercent = value; }
        public bool Active { get => active; set => active = value; }
        public Product Product { get => product; set => product = value; }
    }
}
