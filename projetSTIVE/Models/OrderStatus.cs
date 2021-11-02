using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetSTIVE.Models
{
    public class OrderStatus
    {
        private int statusId;
        private string name;

        public int StatusId { get => statusId; }
        public string Name { get => name; set => name = value; }
    }
}
