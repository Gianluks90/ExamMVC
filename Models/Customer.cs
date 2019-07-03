using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamMVC.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public List<Order> Orders { get; set; }

        public Customer()
        {

        }

        public Customer(int id, string firstname, string lastname, string email, string address, string phone)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Address = address;
            Phone = phone;
        }
    }
}
