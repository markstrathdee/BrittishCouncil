using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace BrittishCouncil
{
    public partial class Queue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedInUserName"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            var ping = new System.Net.NetworkInformation.Ping();

            var result = ping.Send("54.213.97.231");

            if (result.Status != System.Net.NetworkInformation.IPStatus.Success)
                return;
            {
                LabelTransferReady.Text = "Connected";
                LabelTransferReady.ForeColor = System.Drawing.Color.White;
                LabelTransferReady.BackColor = System.Drawing.Color.Green;
            }
        }
        protected void ButtonRecheckConnection_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.RawUrl);
        }

        protected void ButtonTransferRecordings_Click(object sender, EventArgs e)
        {
            using (CascadeEdgeCaptureDataContext LoadedLocalEvents = new CascadeEdgeCaptureDataContext())
                        {
                            LabelRecordings.Text = "Transferring Recordings - Please Wait";

                            var LocalRecordings = LoadedLocalEvents.TableLocalEvents.Where(TableLocalEvents => TableLocalEvents.LocalEventStatus == 1);

                            foreach (TableLocalEvent RecordingsToOutput in LocalRecordings)
                                {
                                    string fileName = RecordingsToOutput.LocalAssetFileName;
                                    string sourcePath = @"C:\Users\Mark C Strathdee\Documents\Visual Studio 2013\Projects\BrittishCouncil\BrittishCouncil\Uploads\Source\";
                                    string targetPath = @"M:\bc\";

                                    string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
                                    string destFile = System.IO.Path.Combine(targetPath, fileName);

                                    System.IO.File.Copy(sourceFile, destFile, true);

                                    using (CascadeCoreDataContext NewEventEntry = new CascadeCoreDataContext())
                                    {
                                        TableEvent NewEvent = new TableEvent();
                                        NewEvent.CustomerID = RecordingsToOutput.LocalCustomerID;
                                        NewEvent.EventID = RecordingsToOutput.LocalEventID;
                                        NewEvent.EventName = RecordingsToOutput.LocalEventName;
                                        NewEvent.EventDescription = RecordingsToOutput.LocalEventDescription;
                                        NewEvent.EventSite = RecordingsToOutput.LocalEventSite;
                                        NewEvent.AssetFileName = RecordingsToOutput.LocalAssetFileName;
                                        NewEvent.EventStatus = "2";
                                        NewEvent.EventReleaseDate = RecordingsToOutput.LocalEventReleaseDate;
                                        NewEvent.EventDateCreated = DateTime.Now;
                                        NewEventEntry.TableEvents.InsertOnSubmit(NewEvent);
                                        NewEventEntry.SubmitChanges();
                                    }

                                    using (CascadeCoreDataContext NewAssetEntry = new CascadeCoreDataContext())
                                    {
                                        TableAsset NewAsset = new TableAsset();
                                        NewAsset.CustomerID = RecordingsToOutput.LocalCustomerID;
                                        NewAsset.EventID = RecordingsToOutput.LocalEventID;
                                        NewAsset.AssetID = RecordingsToOutput.LocalAssetID;
                                        NewAsset.AssetName = RecordingsToOutput.LocalEventName;
                                        NewAsset.AssetDescription = RecordingsToOutput.LocalEventDescription;
                                        NewAsset.AssetFileName = RecordingsToOutput.LocalAssetFileName;
                                        NewAsset.AssetDateCreated = RecordingsToOutput.LocalEventDateCreated;
                                        NewAssetEntry.TableAssets.InsertOnSubmit(NewAsset);
                                        NewAssetEntry.SubmitChanges();
                                                                                
                                    }

                                    using (CascadeEdgeCaptureDataContext UpdateEventStatus = new CascadeEdgeCaptureDataContext())
                                    {
                                        TableLocalEvent CheckEvent = UpdateEventStatus.TableLocalEvents.SingleOrDefault(TableLocalEvent => TableLocalEvent.LocalEventID == RecordingsToOutput.LocalEventID);
                                        CheckEvent.LocalEventStatus = 2;
                                        CheckEvent.LocalEventDateModified = DateTime.Now;
                                        UpdateEventStatus.SubmitChanges();
                                    }


                                    LabelRecordings.Text = "Transferring Recordings - Please Wait";

                                }

                             LabelRecordings.Text = "The following recordings have been transferred to the central archive.";
                        }
          }
     }
}