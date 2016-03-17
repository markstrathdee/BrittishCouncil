<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Queue.aspx.cs" Inherits="BrittishCouncil.Queue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Transfer Recordings to Cloud Archive</h2>
            This page allows you to transfer/upload recordings from this system to the cloud platform archive.&nbsp;&nbsp; The process is a simple 2 step operation, verify the Transfer Status says &quot;Connected&quot;, then press &quot;Transfer Recordings&quot;.
            <H3>Platform Connection Status: <asp:Label ID="LabelTransferReady" runat="server" ForeColor="White" Text="Not Connected" BackColor="#CC3300"></asp:Label>
    <asp:Label ID="LabelRecordings" runat="server" Text=" "></asp:Label>
    </H3><br />
    The following recordings are prepared to transfer.&nbsp; If the indicator above states &quot;Not Connected&quot;, join this system to either a Wired or WiFi Network.&nbsp; You should plan to allow for an hour or more per presentation to transfer to the Archive Platform.&nbsp; Once the upload begins, this system must remain powered on and this web page open.
    <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="LinqDataSourceShowQueuedRecordings" AllowPaging="True">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" Visible="False" />
            <asp:BoundField DataField="LocalCustomerID" HeaderText="LocalCustomerID" SortExpression="LocalCustomerID" Visible="False" />
            <asp:BoundField DataField="LocalEventID" HeaderText="LocalEventID" SortExpression="LocalEventID" Visible="False" />
            <asp:BoundField DataField="LocalEventName" HeaderText="Name" SortExpression="LocalEventName" />
            <asp:BoundField DataField="LocalEventDescription" HeaderText="Description" SortExpression="LocalEventDescription" />
            <asp:BoundField DataField="LocalEventSite" HeaderText="Site" SortExpression="LocalEventSite" />
            <asp:BoundField DataField="LocalEventStatus" HeaderText="LocalEventStatus" SortExpression="LocalEventStatus" Visible="False" />
            <asp:BoundField DataField="LocalEventReleaseDate" HeaderText="Recording Date" SortExpression="LocalEventReleaseDate" />
            <asp:BoundField DataField="LocalEventDateCreated" HeaderText="LocalEventDateCreated" SortExpression="LocalEventDateCreated" Visible="False" />
            <asp:BoundField DataField="LocalEventDateModified" HeaderText="Date Modified" SortExpression="LocalEventDateModified" />
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        </Columns>
    </asp:GridView>
    <asp:LinqDataSource ID="LinqDataSourceShowQueuedRecordings" runat="server" ContextTypeName="BrittishCouncil.CascadeEdgeCaptureDataContext" EntityTypeName="" TableName="TableLocalEvents" Where="LocalEventStatus == @LocalEventStatus" EnableDelete="True" EnableUpdate="True" OrderBy="LocalEventReleaseDate">
        <WhereParameters>
            <asp:Parameter DefaultValue="1" Name="LocalEventStatus" Type="Int32" />
        </WhereParameters>
    </asp:LinqDataSource>
    <p>
    <asp:Button ID="ButtonTransferRecordings" runat="server" Text="Transfer Recordings" OnClick="ButtonTransferRecordings_Click" />
    <asp:Button ID="ButtonRecheckConnection" runat="server" OnClick="ButtonRecheckConnection_Click" Text="Recheck Connection" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
