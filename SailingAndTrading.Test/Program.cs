// See https://aka.ms/new-console-template for more information
using System.Xml.Linq;


string filePath = @"C:\Users\cocox\source\repos\SailingAndTrading\SailingAndTrading\RawData\ProductRawData.xml";
XElement xml = XElement.Load(filePath);
IEnumerable<XElement> productListXml = xml.Descendants("Product");
foreach (XElement product in productListXml)
{ 
    Console.WriteLine(int.Parse(product.Element("Id").Value));
}


