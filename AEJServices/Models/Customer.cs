using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AEJServices.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Company_Name { get; set; }
        public string Contact_Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}