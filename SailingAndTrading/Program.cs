// See https://aka.ms/new-console-template for more information
using SailingAndTrading;




List<Coordination> coordinationList = new List<Coordination>()
{

    new Coordination(20,12,'0'),
    new Coordination(2,1,'0'),
    new Coordination(45,80,'0'),
    new Coordination(12,77,'0'),
    new Coordination(32,75,'0'),
    new Coordination(3,50,'0'),
    new Coordination(33,45,'0'),
    new Coordination(19,48,'0'),
    new Coordination(23,23,'0'),
    new Coordination(16,17,'0')
};
//新建一条船，放入船坐标
Ship ship = new Ship();
coordinationList.Add(ship.ShipCoord);
//显示初始船位置
Map.ShowMap(coordinationList);
//箭头移动改变船坐标位置
bool flag = true;
while (flag)
{
    ship.ShipMoving(Console.ReadKey());
    Console.Clear();
    Map.ShowMap(coordinationList);
    flag=InIsland(ship);
}
    Console.Clear();
    Console.WriteLine("欢迎来到侏罗纪");

//coordinationList.Any(x => x.XCoord == ship.ShipCoord.XCoord && x.YCoord == ship.ShipCoord.YCoord);


    //进入岛
bool InIsland(Ship ship)
{
    for(int i = 0; i < coordinationList.Count-1; i++)
    {
        if (ship.ShipCoord.XCoord == coordinationList[i].XCoord && ship.ShipCoord.YCoord == coordinationList[i].YCoord)
        {           
            return false;
        }        
    }
    return true;
}
