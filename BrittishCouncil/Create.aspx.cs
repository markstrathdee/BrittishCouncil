using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic.FileIO;

namespace BrittishCouncil
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedInUserName"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            string NewCustomerGuid = Guid.NewGuid().ToString();
            TextBoxNewEventGUID.Text = NewCustomerGuid;
        }

        /* Removing Button Control Code.

        protected void ButtonCreateReturn_Click(object sender, EventArgs e)
        {
            using (CascadeEdgeCaptureDataContext NewEventEntry = new CascadeEdgeCaptureDataContext())
            {
                TableLocalEvent NewEvent = new TableLocalEvent();
                NewEvent.LocalCustomerID = Session["SessionSelectedCustomerID"].ToString();
                NewEvent.LocalEventID = TextBoxNewEventGUID.Text;
                NewEvent.LocalEventName = TextBoxEventName.Text;
                NewEvent.LocalEventDescription = TextBoxEventDescription.Text;
                NewEvent.LocalEventSite = TextBoxEventLocation.Text;
                NewEvent.LocalEventStatus = 0;
                NewEvent.LocalEventReleaseDate = TextBoxEventDate.Text;
                NewEvent.LocalEventDateCreated = DateTime.Now;
                NewEventEntry.TableLocalEvents.InsertOnSubmit(NewEvent);
                NewEventEntry.SubmitChanges();

                Page.Server.Transfer("Menu.aspx");

            }
        }
        
        protected void ButtonCreateControl_Click(object sender, EventArgs e)
        {
            using (CascadeEdgeCaptureDataContext NewEventEntry = new CascadeEdgeCaptureDataContext())
            {
                TableLocalEvent NewEvent = new TableLocalEvent();
                NewEvent.LocalCustomerID = Session["SessionSelectedCustomerID"].ToString();
                NewEvent.LocalEventID = TextBoxNewEventGUID.Text;
                NewEvent.LocalEventName = TextBoxEventName.Text;
                NewEvent.LocalEventDescription = TextBoxEventDescription.Text;
                NewEvent.LocalEventSite = TextBoxEventLocation.Text;
                NewEvent.LocalEventStatus = 0;
                NewEvent.LocalEventReleaseDate = TextBoxEventDate.Text;
                NewEvent.LocalEventDateCreated = DateTime.Now;
                NewEventEntry.TableLocalEvents.InsertOnSubmit(NewEvent);
                NewEventEntry.SubmitChanges();

                Session["SessionSelectedEventID"] = TextBoxNewEventGUID;

                Page.Server.Transfer("Control.aspx");

            }
        }
         */

        protected void ButtonUploadCameraFile_Click(object sender, EventArgs e)
        {

            if (LocalFileUpload.HasFile)
            {
                string fileName = TextBoxEventLocationFile.Text + "-" + TextBoxNewEventGUID.Text + System.IO.Path.GetExtension(LocalFileUpload.FileName);
                string savePath = @"C:\Users\Mark C Strathdee\Documents\Visual Studio 2013\Projects\BrittishCouncil\BrittishCouncil\Uploads\Source\";
     
                using (CascadeEdgeCaptureDataContext NewEventEntry = new CascadeEdgeCaptureDataContext())
                {
                    TableLocalEvent NewEvent = new TableLocalEvent();
                    NewEvent.LocalCustomerID = Session["SessionSelectedCustomerID"].ToString();
                    NewEvent.LocalEventID = TextBoxNewEventGUID.Text;
                    NewEvent.LocalAssetID = Guid.NewGuid().ToString();
                    NewEvent.LocalEventName = TextBoxEventNameFile.Text;
                    NewEvent.LocalEventDescription = TextBoxEventDescriptionFile.Text;
                    NewEvent.LocalEventSite = TextBoxEventLocationFile.Text;
                    NewEvent.LocalAssetFileName = fileName;
                    NewEvent.LocalEventStatus = 1;
                    NewEvent.LocalEventReleaseDate = TextBoxEventDateFile.Text;
                    NewEvent.LocalEventDateCreated = DateTime.Now;
                    NewEventEntry.TableLocalEvents.InsertOnSubmit(NewEvent);
                    NewEventEntry.SubmitChanges();
                }

                savePath += fileName;
                LocalFileUpload.SaveAs(savePath);

                Page.Server.Transfer("Menu.aspx");

            }
        }
    }
}