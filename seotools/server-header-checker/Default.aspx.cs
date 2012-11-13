using System;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;

namespace Seotools.server_header_checker
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if (IsPostBack)
            {
                string url = WebsiteUrl.Text.ToString();

                if (!String.IsNullOrEmpty(url))
                {
                    string responseString = String.Empty;

                    try
                    {
                        HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                        // Sends the HttpWebRequest and waits for response.
                        HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
                        // Displays all the headers present in the response received from the URI.                    
                        for (int i = 0; i < myHttpWebResponse.Headers.Count; ++i)
                        {
                            responseString += "<br><strong>" + myHttpWebResponse.Headers.Keys[i] + "</strong>: " + myHttpWebResponse.Headers[i];
                        }
                        responseString += "<br><br>";
                    }
                    catch (Exception postEx)
                    {
                        LabelDisplay.Text = postEx.ToString();
                    }

                    LabelDisplay.Text = "Response: " + responseString;
                }
            }
        }

        public string DoPing(string url)
        {

            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();
            string responseString;

            // Use the default Ttl value which is 128, // but change the fragmentation behavior.
            options.DontFragment = true;

            // Create a buffer of 32 bytes of data to be transmitted. 
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 120;
            
            PingReply reply = pingSender.Send(url, timeout, buffer, options);
            
            if (reply.Status == IPStatus.Success)
            {
                //responseString: "Address: {0}", reply.Address.ToString();
                responseString = "Success";
                //Console.WriteLine("RoundTrip time: {0}", reply.RoundtripTime);
                //Console.WriteLine("Time to live: {0}", reply.Options.Ttl);
                //Console.WriteLine("Don't fragment: {0}", reply.Options.DontFragment);
                //Console.WriteLine("Buffer size: {0}", reply.Buffer.Length);
            }
            else
            {
                responseString = "fail";

            }
            return responseString;
        }
    }
}