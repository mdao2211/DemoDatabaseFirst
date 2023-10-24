using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDatabaseFirst.Model
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice {  get; set; }
        public short UnitsInStock {  get; set; }
        public int CategoryId {  get; set; }
        public virtual Category Category { get; set; }
    }
}
