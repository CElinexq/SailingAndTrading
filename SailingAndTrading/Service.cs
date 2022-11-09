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
        /// 用Linq获取XML文档信息，并获取产品product的所有信息
        /// </summary>
        /// <returns>30种商品信息</returns>
        public static List<Product> GetAllProductInfo()
        {
            List<Product> productList = new List<Product>();
            string filePath = @"RawData\ProductRawData.xml";
            XElement xml = XElement.Load(filePath);
            var productListXml = xml.Descendants("Product");
            foreach (XElement p in productListXml)
            {
                Product product = new Product();
                product.Id = int.Parse(p.Element("Id").Value);
                product.Name = p.Element("Name").Value;
                product.Space = int.Parse(p.Element("Space").Value);
                product.Weight = int.Parse(p.Element("Weight").Value);
                product.SourceIsland_Id = int.Parse(p.Element("SourceIsland").Value);
                productList.Add(product);
            }
            return productList;
        }

            /// <summary>
            /// 用Linq获取XML文档信息，并获取岛屿的5个信息
            /// </summary>
            /// <returns>获得15个岛屿所有信息</returns>
            public static List<Island> GetAllIslandsInfo()
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
            foreach (Island island in GetAllIslandsInfo())
            {
                Coordination c=island.Coordination;
                coordinationList.Add(c);
            }
            return coordinationList;
            
        }

    }
}
