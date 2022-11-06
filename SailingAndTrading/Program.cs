// See https://aka.ms/new-console-template for more information
using SailingAndTrading;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;


Stopwatch sw = Stopwatch.StartNew();
//从XML文档，Service类中获取 15个岛屿坐标
List<Coordination> coordinationList=Service.GetIslandCoordInfo();

//新建一条船，放入船坐标
Ship ship = new Ship();
coordinationList.Add(ship.ShipCoord);
//显示 船只初始 位置
Map.ShowMap(coordinationList);
//移动箭头 改变 船坐标 位置
bool flag = true;
while (flag)
{
    ship.ShipMoving(Console.ReadKey());
    ConsoleClear();
    Map.ShowMap(coordinationList);
    /*每步移动后 都检查船只和岛屿的位置是否一致，来判断是否已经进入某个岛屿,
     *如果位置重合，flag为false 跳出移动循环，进入新的界面
    */
    flag = ship.InIsland(Service.GetIslandsInfo()); 
}
ConsoleClear();
Console.WriteLine("欢迎来到侏罗纪");

//进入岛屿后，显示岛屿信息





//TODO: 下面的代码是教你怎么读取项目中的xml文件
//XDocument myxml = XDocument.Load(@"RawData\IslandRawData.xml");
//Console.WriteLine(myxml.Document.ToString()); 
void ConsoleClear()
{
    sw.Restart();
    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < 80; i++)
    {
        sb.AppendLine(new string(' ', 120));
    }
    Console.SetCursorPosition(0, 0);
    Console.Write(sb.ToString());
    Console.SetCursorPosition(0, 0);
    Debug.WriteLine(sw.ElapsedMilliseconds);
}

