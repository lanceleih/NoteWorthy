using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;

namespace CeeSharp
{
    public partial class SiteMaster : MasterPage
    {
        private const string AntiXsrfTokenKey = "__AntiXsrfToken";
        private const string AntiXsrfUserNameKey = "__AntiXsrfUserName";
        private string _antiXsrfTokenValue;

        protected void Page_Init(object sender, EventArgs e)
        {
            // The code below helps to protect against XSRF attacks
            var requestCookie = Request.Cookies[AntiXsrfTokenKey];
            Guid requestCookieGuidValue;
            if (requestCookie != null && Guid.TryParse(requestCookie.Value, out requestCookieGuidValue))
            {
                // Use the Anti-XSRF token from the cookie
                _antiXsrfTokenValue = requestCookie.Value;
                Page.ViewStateUserKey = _antiXsrfTokenValue;
            }
            else
            {
                // Generate a new Anti-XSRF token and save to the cookie
                _antiXsrfTokenValue = Guid.NewGuid().ToString("N");
                Page.ViewStateUserKey = _antiXsrfTokenValue;

                var responseCookie = new HttpCookie(AntiXsrfTokenKey)
                {
                    HttpOnly = true,
                    Value = _antiXsrfTokenValue
                };
                if (FormsAuthentication.RequireSSL && Request.IsSecureConnection)
                {
                    responseCookie.Secure = true;
                }
                Response.Cookies.Set(responseCookie);
            }

            Page.PreLoad += master_Page_PreLoad;
            if (Session["HiddenNav"] != null)
            {
                var hideNav = Session["HiddenNav"];
                if (hideNav.Equals("hide"))
                {
                    navIcons.Visible = false;
                    Session["HiddenNav"] = "show";
                }
                else
                {
                    navIcons.Visible = true;
                }
            }
        }

        protected void master_Page_PreLoad(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Set Anti-XSRF token
                ViewState[AntiXsrfTokenKey] = Page.ViewStateUserKey;
                ViewState[AntiXsrfUserNameKey] = Context.User.Identity.Name ?? String.Empty;
            }
            else
            {
                // Validate the Anti-XSRF token
                if ((string)ViewState[AntiXsrfTokenKey] != _antiXsrfTokenValue
                    || (string)ViewState[AntiXsrfUserNameKey] != (Context.User.Identity.Name ?? String.Empty))
                {
                    throw new InvalidOperationException("Validation of Anti-XSRF token failed.");
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_LoggingOut(object sender, LoginCancelEventArgs e)
        {
            Context.GetOwinContext().Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
        }

        /// <summary>
        /// Redirect users to Login page or Manage page if it's logged in
        /// </summary>
        /// <param name="sender">Account Icon Button</param>
        /// <param name="e">Clicked</param>
        protected void AccountBtn_Click(object sender, ImageClickEventArgs e)
        {
            if (Context.User.Identity.GetUserName() != null && Context.User.Identity.IsAuthenticated)
                Response.Redirect("~/Account/Manage");
            else
                Response.Redirect("~/Account/Login");
        }

        /// <summary>
        /// Redirect to Login page or Acheivements page if it's logged in
        /// </summary>
        /// <param name="sender">Achievement Icon Button</param>
        /// <param name="e">Clicked</param>
        protected void AchievementBtn_Click(object sender, ImageClickEventArgs e)
        {
            if (Context.User.Identity.GetUserName() != null && Context.User.Identity.IsAuthenticated)
                Response.Redirect("~/Achievements");
            else
                Response.Redirect("~/Account/Login");
        }

        /// <summary>
        /// Redirect to Tutorial page
        /// </summary>
        /// <param name="sender">Tutorial Icon Button</param>
        /// <param name="e">Clicked</param>
        protected void TutorialBtn_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Tutorial");
        }

        /// <summary>
        /// Redirect to Game (Level) page
        /// </summary>
        /// <param name="sender">Game Icon Button</param>
        /// <param name="e">Clicked</param>
        protected void PlayBtn_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Game");
        }
    }

}