using Newtonsoft.Json;
using System;
using System.Reflection;
using System.Xml;
using WebServices.Logs;

namespace WebServices.Controller
{
    public class XmlToJsonController
    {
        /// <summary>
        /// This method is used by the service and the unit tests in order to convert an XML to a JSON after cleaning its nodes.
        /// </summary>
        /// <param name="xmlString"></param>
        /// <returns></returns>
        public string XmlToJson(string xmlString)
        {
            try
            {
                // Load XML from string
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(xmlString);

                //Remove Empty nodes from the XML
                xmlDocument = RemoveEmptyNodes(xmlDocument);

                //The Newtonsoft.Json library is used for this conversion from XML to JSON
                return JsonConvert.SerializeXmlNode(xmlDocument);
            }
            catch (Exception ex)
            {
                Logger.Exception(MethodBase.GetCurrentMethod().Name + " : " + ex.Message.ToString());
                return "Bad Xml format";
            }
        }

        /// <summary>
        /// This method removes all the empty nodes from an XML document
        /// </summary>
        /// <param name="xmlDocument"></param>
        /// <returns></returns>
        public static XmlDocument RemoveEmptyNodes(XmlDocument xmlDocument)
        {

            XmlDocument result = new XmlDocument();
            result.LoadXml(xmlDocument.OuterXml);

            //emptyElements are the empty nodes to remove
            XmlNodeList emptyElements = result.SelectNodes(@"//*[not(node())]");

            for (int i = emptyElements.Count - 1; i >= 0; i--)
            {
                emptyElements[i].ParentNode.RemoveChild(emptyElements[i]);
            }

            return result;
        }
    }
}