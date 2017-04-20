using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AEJServices.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int PTO { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}