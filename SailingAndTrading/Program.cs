// See https://aka.ms/new-console-template for more information
using SailingAndTrading;
using System.Xml.Linq;



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
    //每步移动后 都检查船和岛屿的位置是否一致，来判断是否进入岛屿
    flag = ship.InIsland(ship, coordinationList);       //TODO: 这里有问题，ship对象的方法，参数再传一个ship，多此一举。
}
Console.Clear();
Console.WriteLine("欢迎来到侏罗纪");



//TODO: 下面的代码是教你怎么读取项目中的xml文件
//XDocument myxml = XDocument.Load(@"RawData\IslandRawData.xml");
//Console.WriteLine(myxml.Document.ToString()); 


