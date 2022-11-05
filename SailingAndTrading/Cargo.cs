using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SailingAndTrading
{
    public class Cargo
    {
        public string Name { get; set; }
        public int SingleSpace { get; set; }
        public int Number { get; set; }
        public int SinglePrice { get; set; }
        public int TotalPrice
        {
            get { return SinglePrice * Number; }
        }
        public int TotalSpace
        {
            get { return SingleSpace * Number; }
        }
        //此种商品的原产地，一种商品，离原产地越远，价格越高。
        public Island SourceIsland { get; set; }
        public Cargo(string name, int singleSpace, int number)
        {
            this.Name = name;
            this.SingleSpace = singleSpace;
            this.Number = number;
        }

        public Cargo(string name, int singleSpace)
        {
            this.Name = name;
            this.SingleSpace = singleSpace;
        }
    }
}
