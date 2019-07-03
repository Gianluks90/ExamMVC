using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamMVC.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime CreationDate { get; set; }
        public decimal Price { get; set; }
        public string OrderCode { get; set; }
        public DateTime ShippingDate { get; set; }

        public Customer customer { get; set; }

        public Order()
        {

        }

        public Order(int id, DateTime creationDate, decimal price, string orderCode, DateTime shippingDate)
        {
            Id = id;
            CreationDate = creationDate;
            Price = price;
            OrderCode = orderCode;
            ShippingDate = shippingDate;
        }
    }
}
