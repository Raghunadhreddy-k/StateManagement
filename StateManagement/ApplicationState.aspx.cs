using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class ApplicationState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if(Application["Counter"] == null)
                {
                    Application["Counter"] = 0;
                    lblCount.Text = "Counter: " + Application["Counter"].ToString();
                }
            }
        }

        protected void btnIncrement_Click(object sender, EventArgs e)
        {
            int counter = (int)Application["Counter"];
            counter++;
            Application["Counter"] = counter;
            lblCount.Text = "Counter: " + counter.ToString();
        }
    }
}