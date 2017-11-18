using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CeeSharp
{
    /// <summary>
    /// COMP4952 Project
    /// Author: Teah Elaschuk
    /// Code behind for InGame page: Work in progress
    /// gets game type and data from query strings
    /// </summary>
    public partial class InGame : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["GameType"] != null 
                && Request.QueryString["Level"] != null)
            {
                Label_title.Text = "<h1>" 
                    + Request.QueryString["GameType"].ToString() 
                    + ": " + Request.QueryString["Level"].ToString()
                    + "</h1>";
            }
        }
    }
}