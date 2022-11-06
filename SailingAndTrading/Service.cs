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
        /// 用Linq获取XML文档信息，并获取岛屿的5个信息
        /// </summary>
        /// <returns>获得15个岛屿所有信息</returns>
        public static List<Island> GetIslandsInfo()
        {
            List<Island> islandList = new List<Island>();
            string filePath = @"RawData\IslandRawData.xml";
            XElement xe = XElement.Load(filePath); //加载XMl文档，获得根元素Islands
            IEnumerable<XElement> islandListXe=xe.Descendants("Island"); //找出根元素Islands所有子类元素Island，放入集合list
            foreach (XElement ele in islandListXe)
            {
                Island island = new Island((int)ele.Element("Id"), 
                    (string)ele.Element("Name"), 
                    (string)ele.Element("Information"), 
                    (string)ele.Element("AllSellingProduct"), 
                    ToCoordiantnion((int)ele.Element("Coordination").Element("XCoord"), (int)ele.Element("Coordination").Element("YCoord")));
                islandList.Add(island);
            }
            return islandList;
        }
        /// <summary>
        /// 将 在岛屿信息中 截取的坐标x,y，赋值给坐标
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        static Coordination ToCoordiantnion(int x, int y)
        {
            char c = '0';
            Coordination co=new Coordination(x,y,c);
            return co;
        }
        /// <summary>
        /// 用GetIslandsInfo()方法获得15个岛屿全部信息
        /// </summary>
        /// <returns>获取15个岛屿的坐标</returns>
        public static List<Coordination> GetIslandCoordInfo()
        {
            List<Coordination> coordinationList = new List<Coordination>();
            foreach (Island island in GetIslandsInfo())
            {
                Coordination c=island.Coordination;
                coordinationList.Add(c);
            }
            return coordinationList;
            
        }


        //可以删除
        public static List<Coordination> GetXMlInfo1()
        {
            List<Coordination> coordinationList = new List<Coordination>();
            string filePath = @"RawData\IslandRawData.xml";
            XElement xe = XElement.Load(filePath); //加载XMl文档，获得根元素Islands
            IEnumerable<XElement> islandList = xe.Descendants("Island"); //找出根元素Islands所有子类元素Island，放入集合list
            foreach (XElement ele in islandList)
            {
                Coordination c = new Coordination((int)ele.Element("Coordination").Element("XCoord"), (int)ele.Element("Coordination").Element("YCoord"), '0');
                coordinationList.Add(c);
            }
            return coordinationList;
        }
    }
}
