// See https://aka.ms/new-console-template for more information
using SailingAndTrading;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;


Stopwatch sw = Stopwatch.StartNew();
//从XML文档，Service类中获取 15个岛屿坐标
List<Coordination> coordinationList=Service.GetIslandCoordInfo();

//新建一条船，船只坐标放入地图
Ship ship = new Ship();
coordinationList.Add(ship.ShipCoord);
//显示 船只初始 位置
Map.ShowMap(coordinationList);
//移动箭头 改变 船坐标 位置
bool flag = true;
int count=0;
while (flag)
{
    ship.ShipMoving(Console.ReadKey());
    count++;
    ConsoleClear();
Console.WriteLine($"船只移动次数：{count}");
    Map.ShowMap(coordinationList);
    /*每步移动后 都检查船只和岛屿的位置是否一致，来判断是否已经进入某个岛屿,
     *如果位置重合，flag为false 跳出移动循环，进入新的界面
    */
    flag = ship.InIsland(Service.GetAllIslandsInfo()).isTrue; 
}
ConsoleClear();

//进入岛屿后，显示岛屿信息
var island = ship.InIsland(Service.GetAllIslandsInfo()).island;
Console.WriteLine($"欢迎来到{island.Name}");
Console.WriteLine(island.Information);
//获取岛屿提供的商品信息
Console.WriteLine("商品名称：");
List<Product> ps=island.AllSellingProduct;
foreach (Product product in ps)
{
    Console.WriteLine(product.Name);
}









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

