using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SailingAndTrading
{
    public class Island
    {
        public int Id { get; set; }
        public Coordination Coordination { get; set; }
        public string Name { get; set; }
        public List<Product> CurrentSellingProduct { get; set; }
        public string Information { get; set; }
        public List<Product> AllSellingProduct { get; set; }
        public Island(int Id, string name, string information, string allSellingProductText, Coordination coordination)
        {
            this.Id = Id;
            this.Name = name;
            this.Information = information;
            this.AllSellingProduct = textToAllSellingProduct(allSellingProductText);
            this.Coordination = coordination;
        }

        /// <summary>
        /// 将XElement Island信息<AllSellingProduct> 的string信息 转换成 list
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private List<Product> textToAllSellingProduct(string s)
        {
            //TODO:  将XElement Island信息<AllSellingProduct> 的string信息 转换成 list
            //throw new NotImplementedException();
            return new List<Product>();
        
        }

    }

}
