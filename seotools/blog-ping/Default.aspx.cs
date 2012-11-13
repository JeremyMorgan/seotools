using System;
using System.Linq;
using Seotools.classes;

namespace Seotools.blog_ping
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ResultPanel.Visible = false;
            
            if (IsPostBack)
            {
                // create new pinger
                Pinger ourPinger = new Pinger();

                ourPinger.BlogName = WebsiteName.Text;
                ourPinger.BlogUrl = WebsiteUrl.Text;

                if ((WebsiteName.Text != "") && (WebsiteUrl.Text != ""))
                {
                    LabelMessage.Text = "<b>Starting Pinger - This process can take up to 5 minutes, please be patient.</b>";
                    ResultPanel.Visible = true;
                    LabelResults.Text += ourPinger.Send();
                }
                else
                {
                    LabelMessage.Text = "<p style=\"color:red;\"><b>Error! You must fill out both fields</b></p>";
                }
            }
        }
    }
}