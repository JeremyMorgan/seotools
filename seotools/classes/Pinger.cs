using System;
using System.Linq;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Xml;
using System.Text;

namespace Seotools.classes
{
    public class Pinger
    {
        //The URL of the blog
        private string _BlogUrl = String.Empty;
        public string BlogUrl
        {
            get
            {
                return _BlogUrl;
            }
            set
            {
                _BlogUrl = value;
            }
        }

        // The name of the blog
        private string _BlogName = String.Empty;
        public string BlogName
        {
            get
            {
                return _BlogName;
            }
            set
            {
                _BlogName = value;
            }
        }

        // the list of blogs
        private readonly List<string> siteList = new List<string>();

        // the results to be returned
        string returnlist;

        // in case someone hits the button too many times ;)
        //private bool pingerSubmitted = false;

        public Pinger()
        {
            // since the list isn't changing for now, we'll load it in the constructor
            siteList.Add("http://ping.blogs.yandex.ru/RPC2");
            siteList.Add("http://google.com/ping/RPC2");
            siteList.Add("http://blogsearch.google.co.th/ping/RPC2");
            siteList.Add("http://www.blogsearch.google.ru/ping/RPC2");
            siteList.Add("http://www.blogsearch.google.co.ve/ping/RPC2");
            siteList.Add("http://www.blogsearch.google.de/ping/RPC2");
            siteList.Add("http://www.blogsearch.google.gr/ping/RPC2");
            siteList.Add("http://www.blogpeople.net/ping");
            siteList.Add("http://blogsearch.google.be/ping/RPC2");
            siteList.Add("http://xping.pubsub.com/ping/");
            siteList.Add("http://blogsearch.google.ae/ping/RPC2");
            siteList.Add("http://blogsearch.google.at/ping/RPC2");
            siteList.Add("http://blogsearch.google.com.sa/ping/RPC2");
            siteList.Add("http://api.my.yahoo.co.jp/RPC2");
            siteList.Add("http://ping.pubsub.com/ping");
            siteList.Add("http://www.blogsearch.google.ca/ping/RPC2");
            siteList.Add("http://blogsearch.google.co.ma/ping/RPC2");
            siteList.Add("http://blogsearch.google.sk/ping/RPC2");
            siteList.Add("http://www.ping.blo.gs");
            siteList.Add("http://www.blogsearch.google.com.au/ping/RPC2");
            siteList.Add("http://blogsearch.google.co.id/ping/RPC2");
            siteList.Add("http://www.blogsearch.google.pt/ping/RPC2");
            siteList.Add("http://www.blogsearch.google.ro/ping/RPC2");
            siteList.Add("http://www.blogsearch.google.co.in/ping/RPC2");
            siteList.Add("http://rpc.aitellu.com");
            siteList.Add("http://blogsearch.google.com.br/ping/RPC2");
            siteList.Add("http://www.blogsearch.google.com.sg/ping/RPC2");
            siteList.Add("http://ping.bitacoras.com/");
            siteList.Add("http://www.blogsearch.google.com/ping/RPC2");
            siteList.Add("http://ping.blo.gs/");
            siteList.Add("http://www.blogsearch.google.co.cr/ping/RPC2");
            siteList.Add("http://www.blogsearch.google.co.hu/ping/RPC2");
            siteList.Add("http://www.blogsearch.google.co.za/ping/RPC2");
            siteList.Add("http://pingoo.jp/ping");
            siteList.Add("http://www.blogsearch.google.nl/ping/RPC2");
            siteList.Add("http://blogsearch.google.co.in/ping/RPC2");
            siteList.Add("http://ping.feedburner.com");
            siteList.Add("http://rpc.reader.livedoor.com/ping");
            siteList.Add("http://blogsearch.google.co.za/ping/RPC2");
            siteList.Add("http://blogsearch.google.co.cr/ping/RPC2");
            siteList.Add("http://ping.myblog.jp/");
            siteList.Add("http://www.blogsearch.google.com.ua/ping/RPC2");
            siteList.Add("http://www.blogsearch.google.es/ping/RPC2");
            siteList.Add("http://www.blogsearch.google.lt/ping/RPC2");
            siteList.Add("http://blogsearch.google.com.pe/ping/RPC2");
            siteList.Add("http://www.blogsearch.google.fi/ping/RPC2");
            siteList.Add("http://snipsnap.org/RPC2");
            siteList.Add("http://blogsearch.google.lt/ping/RPC2");
            siteList.Add("http://blogsearch.google.co.il/ping/RPC2");
            siteList.Add("http://www.blogsearch.google.fr/ping/RPC2");
            siteList.Add("http://snipsnap.org");
            siteList.Add("http://blogsearch.google.com.tw/ping/RPC2");
            siteList.Add("http://ping.bitacoras.com");
            siteList.Add("http://rpc.odiogo.com/ping/");
            siteList.Add("http://blogsearch.google.com.au/ping/RPC2");
            siteList.Add("http://blogsearch.google.com.tr/ping/RPC2");
            siteList.Add("http://www.blogsearch.google.jp/ping/RPC2");
            siteList.Add("http://www.blogsearch.google.com.vn/ping/RPC2");
            siteList.Add("http://zhuaxia.com/rpc/server.php");
            siteList.Add("http://ping.wordblog.de/");
            siteList.Add("http://rpc.pingomatic.com");
            siteList.Add("http://blogsearch.google.cl/ping/RPC2");
            siteList.Add("http://www.blo.gs/ping.php");
            siteList.Add("http://blogsearch.google.ch/ping/RPC2");
            siteList.Add("http://rpc.twingly.com");
            siteList.Add("http://blogsearch.google.us/ping/RPC2");
            siteList.Add("http://www.blogsearch.google.be/ping/RPC2");
            siteList.Add("http://blogsearch.google.com.sg/ping/RPC2");
            siteList.Add("http://blogsearch.google.pt/ping/RPC2");
            siteList.Add("http://www.blogsearch.google.it/ping/RPC2");
            siteList.Add("http://blogsearch.google.com.ua/ping/RPC2");
            siteList.Add("http://blogsearch.google.se/ping/RPC2");
            siteList.Add("http://blog.youdao.com/ping/RPC2");
            siteList.Add("http://www.blogsearch.google.co.nz/ping/RPC2");
            siteList.Add("http://blogsearch.google.com.ar/ping/RPC2");
            siteList.Add("http://blogpeople.net/servlet/weblogUpdates");
            siteList.Add("http://www.blogsearch.google.at/ping/RPC2");
            siteList.Add("http://www.blogsearch.google.se/ping/RPC2");
            siteList.Add("http://blo.gs/ping.php");
            siteList.Add("http://www.blogsearch.google.com.ar/ping/RPC2");
            siteList.Add("http://ping.myblog.jp");
            siteList.Add("http://blogsearch.google.ca/ping/RPC2");
            siteList.Add("http://www.blogsearch.google.co.id/ping/RPC2");
            siteList.Add("http://www.blogsearch.google.co.ma/ping/RPC2");
            siteList.Add("http://blogsearch.google.hr/ping/RPC2");
            siteList.Add("http://www.snipsnap.org");
            siteList.Add("http://blogsearch.google.gr/ping/RPC2");
            siteList.Add("http://blogsearch.google.fi/ping/RPC2");
            siteList.Add("http://www.blogsearch.google.sk/ping/RPC2");
            siteList.Add("http://blogsearch.google.de/ping/RPC2");
            siteList.Add("http://blogsearch.google.co.hu/ping/RPC2");
            siteList.Add("http://www.zhuaxia.com/rpc/server.php");
            siteList.Add("http://blogsearch.google.co.ve/ping/RPC2");
            siteList.Add("http://www.blogsearch.google.co.th/ping/RPC2");
            siteList.Add("http://blogsearch.google.com.my/ping/RPC2");
            siteList.Add("http://www.blogsearch.google.com.uy/ping/RPC2");
            siteList.Add("http://www.blogsearch.google.hr/ping/RPC2");
            siteList.Add("http://audiorpc.weblogs.com/RPC2");
            siteList.Add("http://blogsearch.google.com.uy/ping/RPC2");
            siteList.Add("http://www.blogsearch.google.com.co/ping/RPC2");
            siteList.Add("http://www.blogsearch.google.ie/ping/RPC2");
            siteList.Add("http://rpc.pingomatic.com/");
            siteList.Add("http://xping.pubsub.com/ping");
            siteList.Add("http://www.blogsearch.google.co.jp/ping/RPC2");
            siteList.Add("http://ping.wordblog.de");
            siteList.Add("http://blogsearch.google.com.mx/ping/RPC2");
            siteList.Add("http://blogsearch.google.com.co/ping/RPC2");
            siteList.Add("http://ping.rss.drecom.jp");
            siteList.Add("http://xmlrpc.bloggernetz.de/RPC2");
            siteList.Add("http://syndic8.com/xmlrpc.php");
            siteList.Add("http://www.blogsearch.google.com.tw/ping/RPC2");
            siteList.Add("http://www.blogsearch.google.com.sa/ping/RPC2");
            siteList.Add("http://www.blogsearch.google.com.pe/ping/RPC2");
            siteList.Add("http://blogsearch.google.com.vn/ping/RPC2");
            siteList.Add("http://blog.goo.ne.jp/XMLRPC");
            siteList.Add("http://rpc.twingly.com/");
            siteList.Add("http://blogsearch.google.pl/ping/RPC2");
            siteList.Add("http://ping.fc2.com");
            siteList.Add("http://blogsearch.google.fr/ping/RPC2");
            siteList.Add("http://rpc.weblogs.com/RPC2");
            siteList.Add("http://ping.blogs.yandex.ru/RPC2");
            siteList.Add("http://www.blogsearch.google.com.my/ping/RPC2");
            siteList.Add("http://www.bloglines.com/ping");
            siteList.Add("http://ping.blo.gs");
            siteList.Add("http://ping.fc2.com/");
            siteList.Add("http://serenebach.net/rep.cgi");
            siteList.Add("http://www.blogsearch.google.co.il/ping/RPC2");
            siteList.Add("http://blogsearch.google.jp/ping/RPC2");
            siteList.Add("http://www.blogsearch.google.cl/ping/RPC2");
            siteList.Add("http://www.blogpeople.net/servlet/weblogUpdates");
            siteList.Add("http://www.blogsearch.google.ch/ping/RPC2");
            siteList.Add("http://ping.feedburner.com/");
            siteList.Add("http://www.ping.wordblog.de");
            siteList.Add("http://blogsearch.google.com.do/ping/RPC2");
            siteList.Add("http://services.newsgator.com/ngws/xmlrpcping.aspx");
            siteList.Add("http://www.blogsearch.google.pl/ping/RPC2");
            siteList.Add("http://www.blogsearch.google.bg/ping/RPC2");
            siteList.Add("http://blogsearch.google.ru/ping/RPC2");
            siteList.Add("http://www.blogsearch.google.co.uk/ping/RPC2");
            siteList.Add("http://blogsearch.google.es/ping/RPC2");
            siteList.Add("http://www.blogsearch.google.ae/ping/RPC2");
            siteList.Add("http://www.blogsearch.google.com.mx/ping/RPC2");
            siteList.Add("http://blogsearch.google.nl/ping/RPC2");
            siteList.Add("http://www.blogsearch.google.com.tr/ping/RPC2");
            siteList.Add("http://blog.with2.net/ping.php");
            siteList.Add("http://blogsearch.google.co.nz/ping/RPC2");
            siteList.Add("http://www.blogsearch.google.com.do/ping/RPC2");
            siteList.Add("http://blogsearch.google.it/ping/RPC2");
            siteList.Add("http://blogsearch.google.bg/ping/RPC2");
            siteList.Add("http://blogpeople.net/ping");
            siteList.Add("http://www.blogsearch.google.com.br/ping/RPC2");
            siteList.Add("http://blogsearch.google.co.jp/ping/RPC2");
            siteList.Add("http://www.serenebach.net/rep.cgi");
            siteList.Add("http://ping.bloggers.jp/rpc");
            siteList.Add("http://www.blogsearch.google.us/ping/RPC2");
            siteList.Add("http://www.snipsnap.org/RPC2");
            siteList.Add("http://rpc.bloggerei.de/ping/");
            siteList.Add("http://blogsearch.google.ie/ping/RPC2");
            siteList.Add("http://blogsearch.google.ro/ping/RPC2");
            siteList.Add("http://blogsearch.google.co.uk/ping/RPC2");
            siteList.Add("http://blogsearch.google.com/ping/RPC2");
        }
         
        public string Send()
        {
            foreach (string url in siteList)
            {
                DoSendPing(url);
                returnlist += "Pinged: " + url + "<br>";
            }

            return returnlist;
        }

        // Send the ping
        public string DoSendPing(string pingUrl)
        {
            // Create a web request to PingUrl
            HttpWebRequest webreqPing = (HttpWebRequest)WebRequest.Create(pingUrl);

            // Set the properties of the request
            webreqPing.Method = "POST";
            webreqPing.ContentType = "text/xml";

            // Get the stream for the web request
            Stream streamPingRequest = webreqPing.GetRequestStream();

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
            try
            {
                HttpWebResponse webrespPing = (HttpWebResponse)webreqPing.GetResponse();
                StreamReader streamPingResponse = new StreamReader(webrespPing.GetResponseStream());
             
                // Store the result in a string
                string strResult = streamPingResponse.ReadToEnd();

                // Close the respone's stream and the response itself
                streamPingResponse.Close();
                webrespPing.Close();

                return strResult;
            }
            catch (Exception ex)
            {
                // do nothing for now
                return "FAILED";
            }
            // Return the response (as a string)
        }
    }
}