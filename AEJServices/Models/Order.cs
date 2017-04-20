using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AEJServices.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int Employee_Id { get; set; }
        public int Product_Id { get; set; }
        public int PO_Number { get; set; }
        public int Quantity { get; set; }

        public virtual Employee Employee { get; set;}
        public virtual Customer Customer { get; set; }
    }
}