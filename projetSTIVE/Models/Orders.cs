using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetSTIVE.Models
{
    public class Orders
    {
        private int ordersId;
        private decimal price;
        private DateTime orderDate;
        private int quantity;
        private OrderStatus orderStatus;
        private WebUser user;

        public int OrdersId { get => ordersId; }
        public decimal Price { get => price; set => price = value; }
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public OrderStatus OrderStatus { get => orderStatus; set => orderStatus = value; }
        public WebUser User { get => user; set => user = value; }
    }
}
