using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SailingAndTrading
{
    internal class Service
    {
        /// <summary>
        /// 用Linq获取XML文档信息，并截取岛屿坐标数据 赋值给Coordination坐标类
        /// </summary>
        /// <returns>15个岛屿坐标</returns>
        public static List<Coordination> GetXMlInfo()
        {
            List<Coordination> coordinationList = new List<Coordination>();
            string filePath = @"RawData\IslandRawData.xml";
            XElement xe = XElement.Load(filePath); //加载XMl文档，获得根元素Islands
            IEnumerable<XElement> islandList=xe.Descendants("Island"); //找出根元素Islands所有子类元素Island，放入集合list
            foreach (XElement ele in islandList)
            {
                Coordination c = new Coordination((int)ele.Element("Coordination").Element("XCoord"), (int)ele.Element("Coordination").Element("YCoord"), '0');
                coordinationList.Add(c);
            }
            return coordinationList;
        }

        public static void ShowIslandInfo()
        {

        }
    }
}
