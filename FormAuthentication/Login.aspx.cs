using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormAuthentication
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                HttpCookie cookie = System.Web.Security.FormsAuthentication.GetAuthCookie(Request.Form["name"], false);
                
                Response.Cookies.Add(cookie);
                var targetUrl = Request.QueryString["ReturnUrl"];
                if (string.IsNullOrEmpty(targetUrl))
                {
                    targetUrl = "Default.aspx";
                }

                Response.Redirect(targetUrl);
            }
        }
    }
}