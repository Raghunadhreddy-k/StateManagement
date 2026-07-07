using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class SessionState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Counter"] == null)
            {
                Session["Counter"] = 0;
                lblCount.Text = "Counter:" + Session["Counter"].ToString();
            }
        }

        protected void lblIncrement_Click(object sender, EventArgs e)
        {
            int Counter = (int)Session["Counter"];
            Counter++;
            Session["Counter"] = Counter;
            lblCount.Text = "Counter: " + Counter.ToString();
        }
    }
}