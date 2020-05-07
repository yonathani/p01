using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControlInventario.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public int SupplierCode { get; set; }
        public string SupplerName { get; set; }
        public string Email { get; set; }
        public int Ponhe { get; set; }
        public int Adrees { get; set; }
    }
}