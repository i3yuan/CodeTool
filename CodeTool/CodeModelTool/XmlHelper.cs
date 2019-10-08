using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CodeModelTool
{
    public class XmlHelper
    {
        /// <summary>
        /// 修改key-value或新增key-value
        /// </summary>
        /// <param name="xmlPath"></param>
        /// <param name="AppKey"></param>
        /// <param name="AppValue"></param>
        public static void SetXmlFileValue(string xmlPath,string AppKey,string AppValue)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(xmlPath);
            XmlNode xNode;
            XmlElement xElem1;
            XmlElement xElem2;

            xNode = xDoc.SelectSingleNode("//appSettings");

            xElem1 = (XmlElement)xNode.SelectSingleNode("//add[@key='" + AppKey + "']");
            if(xElem1!=null)
            {
                xElem1.SetAttribute("value", AppValue);
            }
            else
            {
                xElem2 = xDoc.CreateElement("add");
                xElem2.SetAttribute("key", AppKey);
                xElem2.SetAttribute("value", AppValue);
                xNode.AppendChild(xElem2);
            }
            xDoc.Save(xmlPath);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="xmlPath"></param>
        /// <param name="AppKey"></param>
        /// <returns></returns>
        public static string GetXmlFileValue(string xmlPath,string AppKey)
        {
            string strValue = "";
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(xmlPath);
            XmlNode xNode;
            XmlElement xElem1;

            xNode = xDoc.SelectSingleNode("//appSettings");

            xElem1 = (XmlElement)xNode.SelectSingleNode("//add[@key='" + AppKey + "']");
            if (xElem1 != null)
            {
                strValue = xElem1.GetAttribute("value");
            }
            else
            {
              
            }
            return strValue;
        }

       
           
    }
    
}
