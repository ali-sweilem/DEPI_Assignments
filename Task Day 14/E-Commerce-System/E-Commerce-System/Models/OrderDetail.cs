using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_System.Models
{
    internal class OrderDetail
    {
        public int orderId { get; set; }
        public int ProductId{ get; set; }
        public int Quantity { get; set; }
    }
}
