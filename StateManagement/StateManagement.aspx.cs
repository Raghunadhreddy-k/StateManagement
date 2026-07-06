using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class StateManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ViewState["Counter"] = 0;
                lblCount.Text = "Counter:0";
            }
        }

        protected void btmImcrement_click(object sender, EventArgs e)
        {
            int Counter = (int)ViewState["Counter"];
            Counter++;
            ViewState["Counter"] = Counter;
            lblCount.Text = "Counter:" + Counter.ToString();
        }
    }
}