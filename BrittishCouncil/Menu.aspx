<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="BrittishCouncil.Menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <!--<h2>Create a Recording</h2><br />
    Start creating a new recording by clicking on this button.<br />
    <br />
    <asp:Button ID="ButtonCreateRecording" runat="server" Text="Create" OnClick="ButtonCreateRecording_Click" /><br />
    <p>
    <h2>Control a Recording</h2><br />
    Start recording.<br />
    <br />
    <asp:Button ID="ButtonControlRecording" runat="server" Text="Control" OnClick="ButtonControlRecording_Click" /><br />-->
    <h2>Sessions Ready for Cloud Archive</h2>
    <p>You can edit or delete planning recordings here.  To sync these files, press the "Sync" button above.</p>

        <asp:LinqDataSource ID="LinqDataSourceSessionsReady" runat="server" ContextTypeName="BrittishCouncil.CascadeEdgeCaptureDataContext" EnableDelete="True" EnableInsert="True" EnableUpdate="True" EntityTypeName="" OrderBy="LocalEventReleaseDate" TableName="TableLocalEvents" Where="LocalEventStatus == @LocalEventStatus">
            <WhereParameters>
                <asp:Parameter DefaultValue="1" Name="LocalEventStatus" Type="Int32" />
            </WhereParameters>
    </asp:LinqDataSource>

        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="LinqDataSourceSessionsReady">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" Visible="False" />
                <asp:BoundField DataField="LocalCustomerID" HeaderText="LocalCustomerID" SortExpression="LocalCustomerID" Visible="False" />
                <asp:BoundField DataField="LocalEventID" HeaderText="LocalEventID" SortExpression="LocalEventID" Visible="False" />
                <asp:BoundField DataField="LocalEventName" HeaderText="Name" SortExpression="LocalEventName" />
                <asp:BoundField DataField="LocalEventDescription" HeaderText="Description" SortExpression="LocalEventDescription" />
                <asp:BoundField DataField="LocalEventSite" HeaderText="Site" SortExpression="LocalEventSite" />
                <asp:BoundField DataField="LocalEventStatus" HeaderText="LocalEventStatus" SortExpression="LocalEventStatus" Visible="False" />
                <asp:BoundField DataField="LocalEventReleaseDate" HeaderText="Recording Date" SortExpression="LocalEventReleaseDate" />
                <asp:BoundField DataField="LocalEventDateCreated" HeaderText="Created" SortExpression="LocalEventDateCreated" />
                <asp:BoundField DataField="LocalEventDateModified" HeaderText="LocalEventDateModified" SortExpression="LocalEventDateModified" Visible="False" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            </Columns>
        </asp:GridView>

    <h2>Search for a local recording</h2>
    <p>Looking for a recording done on this system?&nbsp; Enter a keyword and press search.</p>
    <p>
    <asp:TextBox ID="TextBoxSearch" runat="server"></asp:TextBox> 
    </p>
    <p>
    <asp:Button ID="ButtonSearch" runat="server" Text="Search" OnClick="ButtonSearch_Click" />
    </p>

        <asp:Label ID="LabelSearchResults" runat="server" Text="Search Results will display here."></asp:Label>


</asp:Content>
