using System;
using System.IO;
using System.Xml;

namespace _42_ConsumeData
{
    public static class ConsumeXml
    {
        public static void GetExample()
        {
            const string xmlString = "<?xml version=\"1.0\" encoding=\"UTF - 8\"?><product><description>Product 5</description><price>150.0</price><quantity>500</quantity></product>";

            Console.WriteLine("Showing node by using XmlReader: ");

            using (var stringReader = new StringReader(xmlString))
            {
                using (var xmlReader = XmlReader.Create(stringReader))
                {
                    xmlReader.MoveToContent();

                    xmlReader.ReadStartElement("product");

                    xmlReader.ReadStartElement("description");
                    Console.WriteLine($"Description: {xmlReader.ReadString()}");
                    xmlReader.ReadEndElement();

                    xmlReader.ReadStartElement("price");
                    Console.WriteLine($"Price: {xmlReader.ReadString()}");
                    xmlReader.ReadEndElement();

                    xmlReader.ReadStartElement();
                    Console.WriteLine($"Quantity: {xmlReader.ReadString()}");
                    xmlReader.ReadEndElement();
                }
            }

            var stringWriter = new StringWriter();

            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
            {
                xmlWriter.WriteStartDocument();

                xmlWriter.WriteStartElement("product");

                xmlWriter.WriteElementString("description", "product description");

                xmlWriter.WriteStartElement("price");
                xmlWriter.WriteValue(10.0m);
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("quantity");
                xmlWriter.WriteValue(10);
                xmlWriter.WriteEndElement();

                xmlWriter.WriteEndElement();
                xmlWriter.Flush();
            }

            Console.WriteLine($"Using XmlWiter: \n {stringWriter}");

            var xmlDocument = new XmlDocument();

            xmlDocument.LoadXml(xmlString);

            var xmlNodeList = xmlDocument.GetElementsByTagName("product");

            foreach (XmlNode node in xmlNodeList)
            {
                var descriptionXmlNode = node.ChildNodes.Item(0);
                var priceXmlNode = node.ChildNodes.Item(1);
                var quantityXmlNode = node.ChildNodes.Item(2);

                Console.WriteLine($"Using XmlDocument, XmlNodeList - Description: {descriptionXmlNode.InnerText}, Price: {priceXmlNode.InnerText}, Quantity: {quantityXmlNode.InnerText}");
            }

            var xPathNavigator = xmlDocument.CreateNavigator();
            var product = xPathNavigator.SelectSingleNode("product");

            var descriptionNavigatorValue = product.SelectSingleNode("description").Value;
            var priceNavigatorValue = product.SelectSingleNode("price").Value;
            var quantityNavigatorValue = product.SelectSingleNode("quantity").Value;

            Console.WriteLine($"Using XmlDocument, XPathNavigator - Description: {descriptionNavigatorValue}, Price: {priceNavigatorValue}, Quantity: {quantityNavigatorValue}");

            Console.WriteLine(stringWriter.ToString());

        }
    }
}
