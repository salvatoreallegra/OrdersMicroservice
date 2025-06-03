using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; set; } // Unique ID (GUID preferred for microservices)
        public Guid CustomerId { get; set; } // Link to the customer placing the order
        public DateTime OrderDate { get; set; } // Timestamp of when the order was placed
        public decimal TotalAmount { get; set; } // Total cost of the order
        public string Status { get; set; } = "Pending"; // e.g., Pending, Paid, Shipped, Cancelled

        public List<OrderItem> Items { get; set; } = new(); // Navigation property for line items
    }
}
