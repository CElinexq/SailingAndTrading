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
        public static void ShowMap(List<Coordination> coordinationList)
        {
            var newList = coordinationList.OrderBy(x => x.XCoord).ThenBy(x => x.YCoord).ToList();

            int index = 0;
            for (int i = 0; i < 40; i++)
            {
                string s = new string('.', 100);
                while (index < newList.Count && i == newList[index].XCoord)
                {
                    //体换新字符
                    s = s.Remove(newList[index].YCoord, 1).Insert(newList[index].YCoord, newList[index].Icon.ToString());
                    index++;
                }
                Console.WriteLine(s);
            }
            Console.WriteLine();
            Console.WriteLine(Message);
        }

        public static void ShowMap(int x, int y, char c)
        {

            for (int i = 1; i <= 50; i++)
            {
                string s = new string('#', 100);
                if (i == x)
                {
                    //体换新字符
                    s = s.Remove(y, 1).Insert(y, c.ToString());
                }
                Console.WriteLine(s);

            }
        }
    }
}
