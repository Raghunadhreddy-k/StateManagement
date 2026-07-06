using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class QueryString1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = Request.QueryString["username"];
            string password = Request.QueryString["password"];
            
            lblDisplay.Text = "Username: " + username + "<br/>Password: " + password;
            if(username != null && password != null)
            {
                lblDisplay.Text += "<br/> Query String values are received successfully.";
            }
        }
    }
}