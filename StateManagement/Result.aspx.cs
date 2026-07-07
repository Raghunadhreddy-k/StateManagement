using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class Result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie reqcookie = Request.Cookies["UserInfo"];
            if (reqcookie != null)
            {
                string username = reqcookie["username"];
                string password = reqcookie["password"];
                lblResult.Text = "Username: " + username + "<br/>Password: " + password;
            }
            else
            {
                lblResult.Text = "No cookie found.";
            }
        }
    }
}