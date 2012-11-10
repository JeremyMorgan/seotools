using System;
using System.Linq;
using System.Web;
using System.Net;
using System.IO;
using System.Xml;
using System.Text;

namespace seotools.blog_ping
{

    public class Pinger
    {
        // The URL where the ping will be sent
        private string _PingUrl = String.Empty;
        public string PingUrl { get { return _PingUrl; } set { _PingUrl = value; } }

        //The URL of the blog
        private string _BlogUrl = String.Empty;
        public string BlogUrl { get { return _BlogUrl; } set { _BlogUrl = value; } }

        // The name of the blog
        private string _BlogName = String.Empty;
        public string BlogName { get { return _BlogName; } set { _BlogName = value; } }

        // Send the ping
        public string Send()
        {

            // Create a web request to PingUrl
            HttpWebRequest webreqPing = (HttpWebRequest)WebRequest.Create(PingUrl);

            // Set the properties of the request
            webreqPing.Method = "POST";
            webreqPing.ContentType = "text/xml";

            // Get the stream for the web request
            Stream streamPingRequest = (Stream)webreqPing.GetRequestStream();

            // Create an XML text writer that writes to the web request's stream
            XmlTextWriter xmlPing = new XmlTextWriter(streamPingRequest, Encoding.UTF8);

            // Build the ping, using the BlogName and BlogUrl
            xmlPing.WriteStartDocument();
            xmlPing.WriteStartElement("methodCall");
            xmlPing.WriteElementString("methodName", "weblogUpdates.ping");
            xmlPing.WriteStartElement("params");
            xmlPing.WriteStartElement("param");
            xmlPing.WriteElementString("value", BlogName);
            xmlPing.WriteEndElement();
            xmlPing.WriteStartElement("param");
            xmlPing.WriteElementString("value", BlogUrl);
            xmlPing.WriteEndElement();
            xmlPing.WriteEndElement();
            xmlPing.WriteEndElement();

            // Close the XML text writer, flusing the XML to the stream
            xmlPing.Close();

            // Send the request and store the response, then get the response's stream
            HttpWebResponse webrespPing = (HttpWebResponse)webreqPing.GetResponse();

            StreamReader streamPingResponse = new StreamReader(webrespPing.GetResponseStream());

            // Store the result in a string
            string strResult = streamPingResponse.ReadToEnd();

            // Close the respone's stream and the response itself
            streamPingResponse.Close();
            webrespPing.Close();

            // Return the response (as a string)
            return strResult;
        }

    }


}