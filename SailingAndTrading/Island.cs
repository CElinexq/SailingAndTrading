using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SailingAndTrading
{
    public class Island
    {
        public Coordination Coordination { get; set; }
        public string Name { get; set; }
        public List<Cargo> SellingCargos { get; set; }

        
    }
}
