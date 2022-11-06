using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SailingAndTrading
{
    public class Island
    {
        public int Id { get; set; }
        public Coordination Coordination { get; set; }
        public string Name { get; set; }
        public List<Product> CurrentSellingProduct { get; set; }
        public string Information { get; set; }
        public List<Product> AllSellingProduct { get; set; }
    }
}
