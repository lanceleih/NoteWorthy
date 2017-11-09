using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CeeSharp
{
    public partial class Game : System.Web.UI.Page
    {

        private const int INTERVAL_SUFFIX = 8;      // used to cut the linkButton_ suffix from the IDs of the interval selection buttons
        private const int ARPEGGIO_SUFFIX = 12;     // used to cut the linkButton_arp_ suffix

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void IntervalSelectBtn_Click(object sender, EventArgs e)
        {
            if (sender is LinkButton)
            {
                string s = (sender as LinkButton).ID;
                Session["HiddenNav"] = "hide";
                Response.Redirect("~/InGame.aspx?GameType=interval&Level=" + s.Substring(INTERVAL_SUFFIX));
            }
        }

        protected void ArpeggioSelectBtn_Click(object sender, EventArgs e)
        {
            if (sender is LinkButton)
            {
                string s = (sender as LinkButton).ID;
                Session["HiddenNav"] = "hide";
                Response.Redirect("~/InGame.aspx?GameType=arpeggio&Level=" + s.Substring(ARPEGGIO_SUFFIX));
            }
        }
    }
}