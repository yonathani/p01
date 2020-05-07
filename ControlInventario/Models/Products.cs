using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControlInventario.Models
{
    public class Products
    {
        public int Id { get; set; }
        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int Supplir { get; set; }
        [ForeignKey("Supplir")]
        public virtual Supplier Supplier { get; set; }
    }
}
