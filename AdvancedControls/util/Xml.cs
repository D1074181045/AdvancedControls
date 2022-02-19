using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AdvancedControls.util
{
    class Xml
    {
        private XmlDocument xDoc;
        private string xmlStr;
        private string errMsg;

        public string ErrMsg
        {
            get
            {
                string temp = this.errMsg;
                this.errMsg = null;
                return temp;
            }
        }
        
        public Boolean HasError()
        {
            return (this.errMsg != null && this.errMsg.Length > 0);
        }

        public Xml(string xml)
        {
            this.xmlStr = xml;
            this.xDoc = new XmlDocument();
            this.errMsg = null;

            try
            {
                this.xDoc.LoadXml(this.xmlStr);
            }
            catch (Exception e)
            {
                this.errMsg = string.Format("[ERROR] Xml constructor: {0}::{1}", e.GetType().ToString(), e.Message);
            }
        }

        public string getTagValue(string value)
        {
            XmlNodeList nodes = this.xDoc.DocumentElement.SelectNodes("/dwml/data/parameters/temperature");
            foreach (XmlNode node in nodes)
            {
                if (node.SelectSingleNode("name").InnerText == "Temperature")
                    return node.SelectSingleNode(value).InnerText;
            }
            return "ERROR";
        }
    }
}
