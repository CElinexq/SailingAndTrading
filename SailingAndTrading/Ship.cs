using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SailingAndTrading
{
    internal class Ship
    {
        //船只耐久度
        public int Hp { get; set; }
        public int HpMax { get; set; }
        //船员数量
        public int CrewCount { get; set; }
        public int CrewCountMax { get; set; }
        //货舱容积
        public int CargoSpace { get; set; }
        public int CargoSpaceMax { get; set; }
        //所持有金钱
        public int Money { get; set; }
        //食物
        public int Food { get; set; }
        //货物列表
        public List<Cargo> CargoList { get; set; }= new List<Cargo>();

        public Coordination ShipCoord { get; set; } = new Coordination(19, 49, '$');
        public void ShipMoving(ConsoleKeyInfo cki)
        {           
            if (cki.Key == ConsoleKey.UpArrow)
            {
                ShipCoord.XCoord=ShipCoord.XCoord - 1;
            }
            else if (cki.Key == ConsoleKey.DownArrow)
            {
                ShipCoord.XCoord = ShipCoord.XCoord + 1;
            }
            else if(cki.Key == ConsoleKey.LeftArrow)
            {
                ShipCoord.YCoord = ShipCoord.YCoord - 1;
            }
            else if(cki.Key == ConsoleKey.RightArrow)
            {
                ShipCoord.YCoord = ShipCoord.YCoord + 1;
            }
            else
            {
                Map.Message = "请输入方向键";
            }
        }
    }
}
