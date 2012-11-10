using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace seotools.blog_ping
{
    public partial class Default : System.Web.UI.Page
    {
       

        protected void Page_Load(object sender, EventArgs e)
        {
            ResultPanel.Visible = false;
            
 
            if (IsPostBack)
              {
                  string ourUrl = WebsiteUrl.Text;
                  string ourWebsiteName = WebsiteName.Text;
                  //string ourPingUrl = WebsitePingUrl.Text;
                  Pinger ourPinger = new Pinger();

                  
                  ourPinger.BlogName = WebsiteName.Text;
                  ourPinger.BlogUrl = WebsiteUrl.Text;
                  //ourPinger.PingUrl = ourPingUrl;
                  string txt = WebsitePingUrl.Text;
                  string[] lst = txt.Split(new Char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                  foreach (string line in lst)
                  {
                      ourPinger.PingUrl = line;
                      ourPinger.Send();
                      LabelResults.Text += "Pinged: " + line + "<br>";                      
                  }

                  //LabelResults.Text += ourPingUrl += ourPinger.Send();

                  ResultPanel.Visible = true;
                  
              }

        }

    }
}