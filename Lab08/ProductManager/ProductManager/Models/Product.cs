using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductManager.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}