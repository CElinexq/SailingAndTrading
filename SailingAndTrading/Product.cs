using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SailingAndTrading
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Space { get; set; }
        public int Weight { get; set; } 
        public int Price { get; set; }
        public int SourceIsland_Id { get; set; }
        public Island SourceIsland { get; set; }
    }
}
