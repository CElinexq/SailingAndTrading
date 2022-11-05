using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SailingAndTrading
{
    public class Coordination
    {
        public int XCoord { get; set; }
        public int YCoord { get; set; }
        public char Icon { get; set; }
        public Coordination(int x, int y, char c)
        {
            this.XCoord = x;
            this.YCoord = y;
            this.Icon = c;
        }
    }
}
