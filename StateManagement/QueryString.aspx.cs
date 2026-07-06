using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class QueryString : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtUserName.Text;
            string Passwors = txtPassword.Text;
            
            Response.Redirect("QueryString1.aspx?username=" + name + "&password=" + Passwors);
        }
    }
}