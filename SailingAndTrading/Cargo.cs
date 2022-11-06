using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SailingAndTrading
{
    public class Cargo
    {
        public int Id { get; set; }
        public int Product_Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
