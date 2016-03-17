<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="BrittishCouncil.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    
    <style>
		#body {
			max-width: 700px
		}
	</style>
    
    <h2>Capture Recording Live</h2>
    <table class="form">
        <tr>
            <td>Event Name</td>
            <td>
                <asp:TextBox ID="TextBoxEventName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Event Description</td>
            <td>
                <asp:TextBox ID="TextBoxEventDescription" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Location Recorded At</td>
            <td>
                <asp:TextBox ID="TextBoxEventLocation" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Recording Date</td>
            <td>
                <asp:TextBox ID="TextBoxEventDate" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="TextBoxNewEventGUID" runat="server" Visible="False"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="ButtonCreateControl" runat="server" OnClick="ButtonCreateControl_Click" Text="Create &amp; Control" />
                <asp:Button ID="ButtonCreateReturn" runat="server" OnClick="ButtonCreateReturn_Click" Text="Create &amp; Return" />
            </td>
        </tr>
    </table>

    <h2>Upload Existing Recording from a Camera</h2>
    <table class="form">
        <tr>
            <td>Event Name</td>
            <td>
                <asp:TextBox ID="TextBoxEventNameFile" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Event Description</td>
            <td>
                <asp:TextBox ID="TextBoxEventDescriptionFile" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Location Recorded At</td>
            <td>
                <asp:TextBox ID="TextBoxEventLocationFile" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Recording Date</td>
            <td>
                <asp:TextBox ID="TextBoxEventDateFile" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="TextBox5" runat="server" Visible="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Select a Recording</td> 
            <td>
                <asp:FileUpload ID="FileUploadXML" runat="server" />
             </td>
        </tr>
            <td><asp:TextBox ID="TextBox6" runat="server" Visible="False"></asp:TextBox></td>
            <td><asp:Button ID="ButtonUploadCameraFile" runat="server" OnClick="ButtonUploadCameraFile_Click" Text="Create &amp; Upload" /></td>
        </tr>
    </table>
</asp:Content>
