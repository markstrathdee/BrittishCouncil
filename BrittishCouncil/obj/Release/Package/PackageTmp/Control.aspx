<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Control.aspx.cs" Inherits="BrittishCouncil.Control" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script src="http://jwpsrv.com/library/g47wNLcTEeOAlSIACi0I_Q.js"></script>
    <style>
		#body {
			max-width: 2000px
		}
	</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
        <h2>Start this Recording Session</h2>
        <p>
            Please select an event from the drop down list below.</p>
            <p>
            <asp:DropDownList ID="DropDownListSelectEvent" runat="server" AppendDataBoundItems="True" AutoPostBack="True" DataSourceID="LinqDataSourceSelectEvent" DataTextField="EventName" DataValueField="EventID">
                        <asp:ListItem>Select an Event</asp:ListItem>
                    </asp:DropDownList>
                    <asp:LinqDataSource ID="LinqDataSourceSelectEvent" runat="server" ContextTypeName="BrittishCouncil.CascadeEdgeCaptureDataContext" EntityTypeName="" TableName="TableEvents" Where="EventStatus == @EventStatus">
                        <WhereParameters>
                            <asp:Parameter DefaultValue="0" Name="EventStatus" Type="String" />
                        </WhereParameters>
                    </asp:LinqDataSource>
               </p>
    <table id="videoControl">
        <tr>
            <td>
                <asp:Label ID="LabelCamera1Status" runat="server" Text="Ready" BackColor="#009933" ForeColor="White"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LabelCamera2Status" runat="server" Text="Ready" BackColor="#009933" ForeColor="White"></asp:Label>
            </td>
            <td>
                <asp:Label ID="LabelCamera3Status" runat="server" Text="Ready" BackColor="#009933" ForeColor="White"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="cameraTitle">Camera 1</td>
            <td class="cameraTitle">Camera 2</td>
            <td class="cameraTitle">Camera 3</td>
        </tr>
        <tr>
<td>
<div id='playercamera1'></div>
<script type='text/javascript'>
    jwplayer('playercamera1').setup({
        file: 'http://pdxedge1.sherpadm.com:1935/liveoriginedge/camera1/playlist.m3u8',
        image: '//www.longtailvideo.com/content/images/jw-player/lWMJeVvV-876.jpg',
        width: '100%',
        aspectratio: '16:9',
        mute: 'true',
        autostart: 'true'
    });
</script>
</td>
<td>
<div id='playercamera2'></div>
<script type='text/javascript'>
    jwplayer('playercamera2').setup({
        file: 'http://pdxedge1.sherpadm.com:1935/liveoriginedge/camera2/playlist.m3u8',
        image: '//www.longtailvideo.com/content/images/jw-player/lWMJeVvV-876.jpg',
        width: '100%',
        aspectratio: '16:9',
        mute: 'true',
        autostart: 'true'
    });
</script>
</td>
<td>
<div id='playercamera3'></div>
<script type='text/javascript'>
    jwplayer('playercamera3').setup({
        file: 'http://pdxedge1.sherpadm.com:1935/liveoriginedge/camera3/playlist.m3u8',
        image: '//www.longtailvideo.com/content/images/jw-player/lWMJeVvV-876.jpg',
        width: '100%',
        aspectratio: '16:9',
        mute: 'true',
        autostart: 'true'
    });
</script>
            </td>
        </tr>
        <tr>
            <td>
                    <asp:Button ID="ButtonStartRecordingC1" runat="server" OnClick="ButtonStartRecordingC1_Click" Text="Start Recording" />
                    </td>
            <td>
                    <asp:Button ID="ButtonStartRecordingC2" runat="server" OnClick="ButtonStartRecordingC2_Click" Text="Start Recording" />
                    </td>
            <td>
                    <asp:Button ID="ButtonStartRecordingC3" runat="server" OnClick="ButtonStartRecordingC3_Click" Text="Start Recording" />
                    </td>
        </tr>
        <tr>
            <td>
                    <asp:Button ID="ButtonStopRecordingC1" runat="server" OnClick="ButtonStopRecordingC1_Click" Text="Stop Recording" />

                </td>
            <td>
                    <asp:Button ID="ButtonStopRecordingC2" runat="server" OnClick="ButtonStopRecordingC2_Click" Text="Stop Recording" />
                </td>
            <td>
                    <asp:Button ID="ButtonStopRecordingC3" runat="server" OnClick="ButtonStopRecordingC3_Click" Text="Stop Recording" />
                </td>
        </tr>
        </table>
    <p>
    <h2>Camera Controls</h2>
        <table class="buttons">
            <tr>
                <td>
    <asp:Button ID="ButtonReloadCameras" runat="server" OnClick="ButtonReloadCameras_Click" Text="Reload All Cameras" />
                </td>
                <td>
                    <asp:Button ID="ButtonStartAllCameras" runat="server" Text="Start All Cameras" OnClick="ButtonStartAllCameras_Click" />
                </td>
                <td>
                    <asp:Button ID="ButtonStopAllCameras" runat="server" Text="Stop All Cameras" OnClick="ButtonStopAllCameras_Click" />
                </td>
            </tr>
        </table>
        <p>
    <h2>Close this Recording Session</h2>
            <table class="buttons">
                <tr>
                    <td>
                        <asp:Button ID="ButtonCloseSubmitQueue" runat="server" OnClick="ButtonCloseSubmitQueue_Click" Text="End Recording &amp; Place in Queue" />
                    </td>
                    <td>
                        <asp:Label ID="LabelAlarmEventStatus" runat="server" Text=" "></asp:Label>
                    </td>
                </tr>
        </table>
</asp:Content>
