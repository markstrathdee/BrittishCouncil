using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BrittishCouncil
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedInUserName"] == null)
            {
                Response.Redirect("Login.aspx");
            }

        }

        protected void ButtonCreateRecording_Click(object sender, EventArgs e)
        {
            Response.Redirect("Create.aspx");
        }

        protected void ButtonControlRecording_Click(object sender, EventArgs e)
        {
            Response.Redirect("Control.aspx");
        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
           
        }

    }
}