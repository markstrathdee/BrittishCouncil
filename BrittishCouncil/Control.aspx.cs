using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;

namespace BrittishCouncil
{
    public partial class Control : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedInUserName"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }
            protected void ButtonStartRecordingC1_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://phillaptop-pc:8086/livestreamrecord?app=cascadeorigin&streamname=camera1&action=startRecording");
            request.Method = "GET";
            request.Credentials = new NetworkCredential("mark@trustsherpa.com", "H455elblad");
        
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stm = response.GetResponseStream();
            LabelCamera1Status.Text = "Recording";
            LabelCamera1Status.ForeColor = System.Drawing.Color.White;
            LabelCamera1Status.BackColor = System.Drawing.Color.Red;
        }

            protected void ButtonStopRecordingC1_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://phillaptop-pc:8086/livestreamrecord?app=cascadeorigin&streamname=camera1&action=stopRecording");
            request.Method = "GET";
            request.Credentials = new NetworkCredential("mark@trustsherpa.com", "H455elblad");

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stm = response.GetResponseStream();
            LabelCamera1Status.Text = "Ready";
            LabelCamera1Status.ForeColor = System.Drawing.Color.White;
            LabelCamera1Status.BackColor = System.Drawing.Color.Green;
        }
            protected void ButtonStartRecordingC2_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://phillaptop-pc:8086/livestreamrecord?app=cascadeorigin&streamname=camera2&action=startRecording");
            request.Method = "GET";
            request.Credentials = new NetworkCredential("mark@trustsherpa.com", "H455elblad");

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stm = response.GetResponseStream();
            LabelCamera2Status.Text = "Recording";
            LabelCamera2Status.ForeColor = System.Drawing.Color.White;
            LabelCamera2Status.BackColor = System.Drawing.Color.Red;
        }

            protected void ButtonStopRecordingC2_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://phillaptop-pc:8086/livestreamrecord?app=cascadeorigin&streamname=camera2&action=stopRecording");
            request.Method = "GET";
            request.Credentials = new NetworkCredential("mark@trustsherpa.com", "H455elblad");

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stm = response.GetResponseStream();
            LabelCamera2Status.Text = "Ready";
            LabelCamera2Status.ForeColor = System.Drawing.Color.White;
            LabelCamera2Status.BackColor = System.Drawing.Color.Green;
        }
            protected void ButtonStartRecordingC3_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://phillaptop-pc:8086/livestreamrecord?app=cascadeorigin&streamname=camera3&action=startRecording");
            request.Method = "GET";
            request.Credentials = new NetworkCredential("mark@trustsherpa.com", "H455elblad");

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stm = response.GetResponseStream();
            LabelCamera3Status.Text = "Recording";
            LabelCamera3Status.ForeColor = System.Drawing.Color.White;
            LabelCamera3Status.BackColor = System.Drawing.Color.Red;
        }

        protected void ButtonStopRecordingC3_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://phillaptop-pc:8086/livestreamrecord?app=cascadeorigin&streamname=camera3&action=stopRecording");
            request.Method = "GET";
            request.Credentials = new NetworkCredential("mark@trustsherpa.com", "H455elblad");

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stm = response.GetResponseStream();
            LabelCamera3Status.Text = "Ready";
            LabelCamera3Status.ForeColor = System.Drawing.Color.White;
            LabelCamera3Status.BackColor = System.Drawing.Color.Green;
        }

        protected void ButtonReloadCameras_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.RawUrl);
        }

        protected void ButtonStartAllCameras_Click(object sender, EventArgs e)
        {
            HttpWebRequest request1 = (HttpWebRequest)WebRequest.Create("http://phillaptop-pc:8086/livestreamrecord?app=cascadeorigin&streamname=camera1&action=startRecording");
            request1.Method = "GET";
            request1.Credentials = new NetworkCredential("mark@trustsherpa.com", "H455elblad");

            HttpWebResponse response1 = (HttpWebResponse)request1.GetResponse();
            Stream stm1 = response1.GetResponseStream();
            LabelCamera1Status.Text = "Recording";
            LabelCamera1Status.ForeColor = System.Drawing.Color.White;
            LabelCamera1Status.BackColor = System.Drawing.Color.Red;

            HttpWebRequest request2 = (HttpWebRequest)WebRequest.Create("http://phillaptop-pc:8086/livestreamrecord?app=cascadeorigin&streamname=camera2&action=startRecording");
            request2.Method = "GET";
            request2.Credentials = new NetworkCredential("mark@trustsherpa.com", "H455elblad");

            HttpWebResponse response2 = (HttpWebResponse)request2.GetResponse();
            Stream stm2 = response2.GetResponseStream();
            LabelCamera2Status.Text = "Recording";
            LabelCamera2Status.ForeColor = System.Drawing.Color.White;
            LabelCamera2Status.BackColor = System.Drawing.Color.Red;

            HttpWebRequest request3 = (HttpWebRequest)WebRequest.Create("http://phillaptop-pc:8086/livestreamrecord?app=cascadeorigin&streamname=camera3&action=startRecording");
            request3.Method = "GET";
            request3.Credentials = new NetworkCredential("mark@trustsherpa.com", "H455elblad");

            HttpWebResponse response = (HttpWebResponse)request3.GetResponse();
            Stream stm3 = response.GetResponseStream();
            LabelCamera3Status.Text = "Recording";
            LabelCamera3Status.ForeColor = System.Drawing.Color.White;
            LabelCamera3Status.BackColor = System.Drawing.Color.Red;
        }

        protected void ButtonStopAllCameras_Click(object sender, EventArgs e)
        {
            HttpWebRequest request1 = (HttpWebRequest)WebRequest.Create("http://phillaptop-pc:8086/livestreamrecord?app=cascadeorigin&streamname=camera1&action=stopRecording");
            request1.Method = "GET";
            request1.Credentials = new NetworkCredential("mark@trustsherpa.com", "H455elblad");

            HttpWebResponse response1 = (HttpWebResponse)request1.GetResponse();
            Stream stm1 = response1.GetResponseStream();
            LabelCamera1Status.Text = "Ready";
            LabelCamera1Status.ForeColor = System.Drawing.Color.White;
            LabelCamera1Status.BackColor = System.Drawing.Color.Green;

            HttpWebRequest request2 = (HttpWebRequest)WebRequest.Create("http://phillaptop-pc:8086/livestreamrecord?app=cascadeorigin&streamname=camera2&action=stopRecording");
            request2.Method = "GET";
            request2.Credentials = new NetworkCredential("mark@trustsherpa.com", "H455elblad");

            HttpWebResponse response2 = (HttpWebResponse)request2.GetResponse();
            Stream stm2 = response2.GetResponseStream();
            LabelCamera2Status.Text = "Ready";
            LabelCamera2Status.ForeColor = System.Drawing.Color.White;
            LabelCamera2Status.BackColor = System.Drawing.Color.Green;

            HttpWebRequest request3 = (HttpWebRequest)WebRequest.Create("http://phillaptop-pc:8086/livestreamrecord?app=cascadeorigin&streamname=camera3&action=stopRecording");
            request3.Method = "GET";
            request3.Credentials = new NetworkCredential("mark@trustsherpa.com", "H455elblad");

            HttpWebResponse response = (HttpWebResponse)request3.GetResponse();
            Stream stm3 = response.GetResponseStream();
            LabelCamera3Status.Text = "Ready";
            LabelCamera3Status.ForeColor = System.Drawing.Color.White;
            LabelCamera3Status.BackColor = System.Drawing.Color.Green;
        }

        protected void ButtonCloseSubmitQueue_Click(object sender, EventArgs e)
        {
            using (CascadeEdgeCaptureDataContext UpdateEventStatus = new CascadeEdgeCaptureDataContext())
            {
                TableLocalEvent CheckEvent = UpdateEventStatus.TableLocalEvents.SingleOrDefault(TableLocalEvent => TableLocalEvent.LocalEventID == DropDownListSelectEvent.Text);
                CheckEvent.LocalEventStatus = 1;
                CheckEvent.LocalEventDateModified = DateTime.Now;
                UpdateEventStatus.SubmitChanges();
            }

            HttpWebRequest request1 = (HttpWebRequest)WebRequest.Create("http://phillaptop-pc:8086/livestreamrecord?app=cascadeorigin&streamname=camera1&action=stopRecording");
            request1.Method = "GET";
            request1.Credentials = new NetworkCredential("mark@trustsherpa.com", "H455elblad");

            HttpWebResponse response1 = (HttpWebResponse)request1.GetResponse();
            Stream stm1 = response1.GetResponseStream();
            LabelCamera1Status.Text = "Ready";
            LabelCamera1Status.ForeColor = System.Drawing.Color.White;
            LabelCamera1Status.BackColor = System.Drawing.Color.Green;

            HttpWebRequest request2 = (HttpWebRequest)WebRequest.Create("http://phillaptop-pc:8086/livestreamrecord?app=cascadeorigin&streamname=camera2&action=stopRecording");
            request2.Method = "GET";
            request2.Credentials = new NetworkCredential("mark@trustsherpa.com", "H455elblad");

            HttpWebResponse response2 = (HttpWebResponse)request2.GetResponse();
            Stream stm2 = response2.GetResponseStream();
            LabelCamera2Status.Text = "Ready";
            LabelCamera2Status.ForeColor = System.Drawing.Color.White;
            LabelCamera2Status.BackColor = System.Drawing.Color.Green;

            HttpWebRequest request3 = (HttpWebRequest)WebRequest.Create("http://phillaptop-pc:8086/livestreamrecord?app=cascadeorigin&streamname=camera3&action=stopRecording");
            request3.Method = "GET";
            request3.Credentials = new NetworkCredential("mark@trustsherpa.com", "H455elblad");

            HttpWebResponse response = (HttpWebResponse)request3.GetResponse();
            Stream stm3 = response.GetResponseStream();
            LabelCamera1Status.Text = "Ready";
            LabelCamera3Status.ForeColor = System.Drawing.Color.White;
            LabelCamera3Status.BackColor = System.Drawing.Color.Green;

            Response.Redirect("Queue.aspx");
        }
    }
}