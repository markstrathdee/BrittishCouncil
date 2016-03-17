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
    <h2>Sessions Ready for Recording</h2>
    <p>You can edit or delete planning recordings here.</p>

        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="EventID" DataSourceID="LinqDataSourceSessionsReadyToRecord">
            <Columns>
                <asp:BoundField DataField="EventID" HeaderText="EventID" ReadOnly="True" SortExpression="EventID" Visible="False" />
                <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" SortExpression="CustomerID" Visible="False" />
                <asp:BoundField DataField="EventName" HeaderText="Name" SortExpression="EventName" />
                <asp:BoundField DataField="EventDescription" HeaderText="Description" SortExpression="EventDescription" />
                <asp:BoundField DataField="EventDateCreated" HeaderText="Date Created" SortExpression="EventDateCreated" />
                <asp:BoundField DataField="EventReleaseDate" HeaderText="Recording Date" SortExpression="EventReleaseDate" />
                <asp:BoundField DataField="EventSite" HeaderText="Site" SortExpression="EventSite" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            </Columns>
        </asp:GridView>
        <asp:LinqDataSource ID="LinqDataSourceSessionsReadyToRecord" runat="server" ContextTypeName="BrittishCouncil.CascadeEdgeCaptureDataContext" EnableDelete="True" EnableUpdate="True" EntityTypeName="" OrderBy="EventDateCreated" TableName="TableEvents" Where="EventStatus == @EventStatus">
            <WhereParameters>
                <asp:Parameter DefaultValue="0" Name="EventStatus" Type="String" />
            </WhereParameters>
        </asp:LinqDataSource>

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
