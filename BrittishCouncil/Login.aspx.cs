using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BrittishCouncil
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
            protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            using (CascadeEdgeCaptureDataContext LoginCheck = new CascadeEdgeCaptureDataContext())
            {
                TableLocalAdmin Verify = LoginCheck.TableLocalAdmins.FirstOrDefault(TableLocalAdmin => TableLocalAdmin.LocalAdminEmail == TextBoxUserName.Text && TableLocalAdmin.LocalAdminPassword == TextBoxPassword.Text);

                if (Verify == null)
                {
                    LabelAlertEmail.Text = "Sorry, incorrect Email Address or Password";
                    LabelAlertPassword.Text = "Sorry, incorrect Email Address or Password";
                }

                else
                {
                    Session["LoggedInUserName"] = TextBoxUserName.Text;
                    Session["SessionSelectedCustomerID"] = "a110b2a3-9529-43c3-b5fb-92778df20544";
                    Response.Redirect("Menu.aspx");
                }
            }
        }
    }
}