using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SailingAndTrading
{
    internal class Map
    {
        public static string Message { get; set; }
        /// <summary>
        /// 根据坐标list来生成整张地图
        /// </summary>
        /// <param name="coordinationList">8个坐标list集合，即8座岛屿</param>
        public static void ShowMap(List<Coordination> coordinationList)
        {
            var newList = coordinationList.OrderBy(x => x.XCoord).ThenBy(x => x.YCoord).ToList();

            int index = 0;
            for (int i = 0; i < 40; i++)
            {
                //生成100个字符.，生在一行，用new string方法
                string s = new string('.', 100);
                while (index < newList.Count && i == newList[index].XCoord)
                {
                    //替换新字符，用remove删除并insert添加新字符
                    s = s.Remove(newList[index].YCoord, 1).Insert(newList[index].YCoord, newList[index].Icon.ToString());
                    index++;
                }
                Console.WriteLine(s);
            }
            Console.WriteLine();
            Console.WriteLine(Message);
        }
        /// <summary>
        /// ShowMap重载
        /// </summary>
        /// <param name="x">岛屿横坐标</param>
        /// <param name="y">岛屿纵坐标</param>
        /// <param name="c">岛屿字符显示结果</param>
        public static void ShowMap(int x, int y, char c)
        {

            for (int i = 1; i <= 50; i++)
            {
                string s = new string('#', 100);
                if (i == x)
                {
                    //替换新字符
                    s = s.Remove(y, 1).Insert(y, c.ToString());
                }
                Console.WriteLine(s);

            }
        }
    }
}
